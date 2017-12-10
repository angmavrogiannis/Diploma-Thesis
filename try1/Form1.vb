Public Class Form1
    Dim varCount As Integer = 0
    Dim varType(10) As Integer
    Dim labelCount As Integer = 0
    Dim nod As Integer = 3 'accuracy / number of decimals
    Dim flagMenu As Integer = 0
    Private Sub lstDesPars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDesPars.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDesParType.SelectedIndexChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdAddDesPar.Click
        'Check if type has been declared
        If lstDesParType.SelectedItems.Count = 0 Then
            txtDesParName.Text = "Declare a type !!!!"
            txtDesParName.Focus()
            Exit Sub
        End If
        'Check whether txtDesParName is empty
        If txtDesParName.Text = Nothing Then
            txtDesParName.Text = "Enter a name !!!!"
            txtDesParName.Focus()
            Exit Sub
        End If
        'Check if DP already exists
        If lstDesPars.Items.Count >= 1 Then
            For i = 1 To lstDesPars.Items.Count
                If txtDesParName.Text = lstDesPars.Items(i - 1) Then
                    txtDesParName.Text = "Enter another name !!!!"
                    txtDesParName.Focus()
                    Exit Sub
                End If
            Next
        End If
        If lstDesParType.SelectedIndex = 1 Then
            varType(varCount) = 10 ^ nod 'continuous variable
        Else
            varType(varCount) = 1 'discrete variable
        End If
        lstDesPars.Items.Add(txtDesParName.Text)
        varCount = varCount + 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdDelDesPar.Click
        If lstDesPars.Items.Count = 0 Then
            txtDesParName.Text = "There is nothing here to delete"
        Else
            Dim pos As Integer = lstDesPars.SelectedIndex
            lstDesPars.Items.RemoveAt(pos)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cmdAssignValue.Click
        'Check if user forgot to declare a parameter
        If lstDesPars.Items.Count <= lstValues.Items.Count Or lstDesPars.Items.Count <= lstValues2.Items.Count Then
            txtDesParName.Text = "Enter a value"
            txtDesParName.Focus()
            Exit Sub
        End If
        'Check whether txtValueEntry is empty
        If txtValueEntry.Text = Nothing And txtValueEntry2.Text = Nothing Then
            MsgBox("Enter a minimum and a maximum value!")
        Else
            If txtValueEntry.Text = Nothing Then
                MsgBox("Enter a minimum value!")
                txtValueEntry.Focus()
                Exit Sub
            End If
            If txtValueEntry2.Text = Nothing Then
                MsgBox("Enter a maximum value!")
                txtValueEntry.Focus()
                Exit Sub
            End If
        End If
        lstValues.Items.Add(txtValueEntry.Text)
        lstValues2.Items.Add(txtValueEntry2.Text)
        txtDesParName.Text = ""
        txtValueEntry.Text = ""
        txtValueEntry2.Text = ""
        If labelCount = 0 Then
            Label16.Text = lstDesPars.Items(0)
        ElseIf labelCount = 1 Then
            Label17.Text = lstDesPars.Items(1)
        ElseIf labelCount = 2 Then
            Label18.Text = lstDesPars.Items(2)
        ElseIf labelCount = 3 Then
            Label19.Text = lstDesPars.Items(3)
        ElseIf labelCount = 4 Then
            Label20.Text = lstDesPars.Items(4)
        ElseIf labelCount = 5 Then
            Label21.Text = lstDesPars.Items(5)
        End If
        labelCount = labelCount + 1
    End Sub

    Private Sub cmdDelValue_Click(sender As Object, e As EventArgs) Handles cmdDelValue.Click
        If lstValues.Items.Count = 0 Or lstValues.SelectedIndex = -1 Then
            MsgBox("There is nothing here to delete")
        Else
            Dim pos As Integer = lstValues.SelectedIndex
            lstValues.Items.RemoveAt(pos)
            If pos = 0 Then
                Label16.Text = ""
                labelCount = labelCount - 1
            ElseIf pos = 1 Then
                Label17.Text = ""
                labelCount = labelCount - 1
            ElseIf pos = 2 Then
                Label18.Text = ""
                labelCount = labelCount - 1
            ElseIf pos = 3 Then
                Label19.Text = ""
                labelCount = labelCount - 1
            ElseIf pos = 4 Then
                Label20.Text = ""
                labelCount = labelCount - 1
            ElseIf pos = 5 Then
                Label21.Text = ""
                labelCount = labelCount - 1
            End If
        End If
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdSolve.Click
        If CheckBox1.Checked And CheckBox2.Checked Or CheckBox1.CheckState = 0 And CheckBox2.CheckState = 0 Then
            MsgBox("You need to chose either Maximization or Minimization")
            CheckBox1.CheckState = 0
            CheckBox2.CheckState = 0
        Else
            Dim optFlag As Integer = 0
            If CheckBox2.Checked Then
                optFlag = 1
            End If
            Dim noi As Integer = TextBox4.Text 'number of iterations
            Dim x As Integer = TextBox1.Text 'number of chromosomes needed for the solution
            Dim dlv(varCount, 2) As Integer  'dlv stands for decimal limit values
            Dim fitRes(noi) As Double
            Dim parser As New MathParserNet.Parser
            If lstValues.Items.Count = varCount And lstValues2.Items.Count = varCount Then
                For i = 1 To varCount
                    dlv(i, 1) = lstValues.Items(i - 1) * varType(i - 1)
                    dlv(i, 2) = lstValues2.Items(i - 1) * varType(i - 1)
                Next
                Dim nov(varCount) As Integer 'nov stands for number of values determining the size of the chromosome
                For i = 1 To varCount
                    nov(i) = dlv(i, 2) - dlv(i, 1)
                Next
                Dim ubl(varCount) As String 'ubl stands for upper binary limit
                For i = 1 To varCount
                    ubl(i) = Convert.ToString(nov(i), 2)
                Next
                Dim b(varCount) As Integer 'b stands for bandwith
                For i = 1 To varCount
                    b(i) = Len(ubl(i))
                Next
                Dim bandwith As Integer = b(1)
                For i = 2 To varCount
                    bandwith = bandwith + b(i)
                Next
                Dim values(x, varCount) As Integer 'it's later required for easier calculation of the fitness function
                Dim bvalues(x, varCount) As String
                For i = 1 To x 'initialization of the matrix values so that check for identical chromosome parts is legit
                    For j = 1 To varCount
                        bvalues(i, j) = "0"
                    Next
                Next
                Dim binval As String = "0"
                Dim val As Integer = 0
                For i = 1 To x
                    For k = 1 To varCount
                        Randomize()
                        val = CInt(Int(((nov(k) - 0 + 1) * Rnd()) + 0))
                        binval = Convert.ToString(val, 2)
                        While Len(binval) <> b(k)
                            binval = binval.Insert(0, "0")
                        End While
                        values(i, k) = val
                        bvalues(i, k) = binval
                    Next
                Next
                Dim chr(x) As String 'creates an array which consists of the created chromosomes
                Dim fitness(x) As Double
                For g = 1 To noi
                    For i = 1 To x
                        If g = 1 Then
                            chr(i) = bvalues(i, 1)
                            For j = 2 To varCount
                                chr(i) = chr(i) & bvalues(i, j)
                            Next
                            parser.RemoveAllVariables()
                            For j = 1 To varCount
                                Dim realVal As Double = values(i, j) / varType(j - 1) + lstValues.Items(j - 1)
                                parser.AddVariable(lstDesPars.Items(j - 1), realVal)
                            Next
                            Try
                                fitness(i) = parser.SimplifyDouble(txtEq.Text)
                            Catch ex As Exception
                                MsgBox("Undeclared variables or not supported symbols used ")
                                Exit Sub
                            End Try
                        Else
                            parser.RemoveAllVariables()
                            Dim c As Integer = b(1)
                            Dim realVal1 As Double = Convert.ToInt32(Mid(chr(i), 1, c), 2) / varType(0) + lstValues.Items(0)
                            parser.AddVariable(lstDesPars.Items(0), realVal1)
                            If g = noi And i = x Then
                                MsgBox(realVal1)
                            End If
                            For j = 2 To varCount
                                Dim realVal2 As Double = Convert.ToInt32(Mid(chr(i), c + 1, b(j)), 2) / varType(j - 1) + lstValues.Items(j - 1)
                                parser.AddVariable(lstDesPars.Items(j - 1), realVal2)
                                If g = noi And i = x Then
                                    MsgBox(realVal2)
                                End If
                                c = c + b(j)
                            Next
                            Try
                                fitness(i) = parser.SimplifyDouble(txtEq.Text)
                            Catch ex As Exception
                                MsgBox("Undeclared variables or not supported symbols used ")
                                Exit Sub
                            End Try
                        End If
                    Next
                    Dim n As Integer = x
                    While n <> 0 'bubble sort algorithm implementation
                        Dim newn As Integer = 0
                        If optFlag = 0 Then
                            For i = 2 To n
                                If fitness(i - 1) > fitness(i) Then
                                    Dim temp2 As Double = fitness(i - 1)
                                    fitness(i - 1) = fitness(i)
                                    fitness(i) = temp2
                                    Dim temp3 As String = chr(i - 1)
                                    chr(i - 1) = chr(i)
                                    chr(i) = temp3
                                    newn = i
                                End If
                            Next
                        Else
                            For i = 2 To n
                                If fitness(i - 1) < fitness(i) Then
                                    Dim temp2 As Double = fitness(i - 1)
                                    fitness(i - 1) = fitness(i)
                                    fitness(i) = temp2
                                    Dim temp3 As String = chr(i - 1)
                                    chr(i - 1) = chr(i)
                                    chr(i) = temp3
                                    newn = i
                                End If
                            Next
                        End If
                        n = newn
                    End While
                    fitRes(g) = fitness(x) 'fittness results is gonna be presented on an excel file
                    Dim selno As Integer = Int(TextBox2.Text / 100 * x) 'selno stands for selected number
                    If (x - selno) Mod 2 <> 0 Then 'making sure the number of the non-selected chromosomes is an even number
                        selno = selno + 1
                    End If
                    Dim selchr(selno) As String 'selected chromosomes matrix
                    Dim u As Integer = 1
                    For i = x - selno + 1 To x
                        selchr(u) = chr(i)
                        u = u + 1
                    Next
                    Dim cross(x - selno) As String
                    For i = 1 To x - selno
                        cross(i) = chr(i)
                    Next
                    For i = 1 To x - selno - 1 Step 2 'breeding is being done
                        Dim flag1 As Integer = 0
                        While flag1 = 0
                            Randomize()
                            Dim crp As Integer = CInt(Math.Floor((bandwith - 1) * Rnd())) + 1
                            Dim tempstr As String = cross(i)
                            Dim c1 As String = cross(i)
                            Dim c2 As String = cross(i + 1)
                            c1 = Mid(cross(i), 1, crp) & Mid(cross(i + 1), crp + 1)
                            c2 = Mid(cross(i + 1), 1, crp) & Mid(tempstr, crp + 1)
                            Dim c As String = b(1)
                            Dim tv(varCount) As Integer 'tv stands for test values
                            tv(1) = Convert.ToInt32(Mid(c1, 1, c), 2)
                            For j = 2 To varCount
                                tv(j) = Convert.ToInt32(Mid(c1, c + 1, b(j)), 2)
                                c = c + b(j)
                            Next
                            c = b(1)
                            Dim tv2(varCount) As Integer
                            tv2(1) = Convert.ToInt32(Mid(c2, 1, c), 2)
                            For j = 2 To varCount
                                tv2(j) = Convert.ToInt32(Mid(c2, c + 1, b(j)), 2)
                                c = c + b(j)
                            Next
                            For j = 1 To varCount
                                If tv(j) >= 0 And tv(j) <= nov(j) And tv2(j) >= 0 And tv2(j) <= nov(j) Then
                                    flag1 = 1
                                    If j = varCount Then
                                        cross(i) = c1
                                        cross(i + 1) = c2
                                    End If
                                Else
                                    flag1 = 0
                                    Exit For
                                End If
                            Next
                        End While
                    Next
                    For i = 1 To x - selno
                        chr(i) = cross(i)
                    Next
                    For i = 1 To 2
                        Dim flag2 As Integer = 0
                        While flag2 = 0
                            Randomize()
                            Dim mutChr As Integer = CInt(Math.Floor((x - 1) * Rnd())) + 1
                            Dim mutBit As Integer = CInt(Math.Floor((bandwith - 1) * Rnd())) + 1
                            Dim str As String = chr(mutChr)
                            Dim cr As String = chr(mutChr)
                            If str(mutBit) = "0" Then
                                cr = str.Remove(mutBit, 1).Insert(mutBit, "1")
                            Else
                                cr = str.Remove(mutBit, 1).Insert(mutBit, "0")
                            End If
                            Dim c As String = b(1)
                            Dim tv(varCount) As Integer 'tv stands for test values
                            tv(1) = Convert.ToInt32(Mid(cr, 1, c), 2)
                            For j = 2 To varCount
                                tv(j) = Convert.ToInt32(Mid(cr, c + 1, b(j)), 2)
                                c = c + b(j)
                            Next
                            For j = 1 To varCount
                                If tv(j) >= 0 And tv(j) <= nov(j) Then
                                    flag2 = 1
                                    If j = varCount Then
                                        chr(mutChr) = cr
                                    End If
                                Else
                                    flag2 = 0
                                    Exit For
                                End If
                            Next
                        End While
                    Next
                Next
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("c:\Users\Aggelos\Desktop\results5.txt", True)
                For i = 1 To noi
                    file.WriteLine(fitRes(i))
                Next
                file.Close()
                MsgBox("Optimization Procedure has been concluded.")
            Else
                MsgBox("You need to declare all parameters")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles cmdClose.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles cmdDelValue2.Click
        If lstValues2.Items.Count = 0 Or lstValues2.SelectedIndex = -1 Then
            MsgBox("There is nothing here to delete")
        Else
            Dim pos As Integer = lstValues2.SelectedIndex
            lstValues2.Items.RemoveAt(pos)
            If pos = 0 Then
                Label16.Text = ""
            ElseIf pos = 1 Then
                Label17.Text = ""
            ElseIf pos = 2 Then
                Label18.Text = ""
            ElseIf pos = 3 Then
                Label19.Text = ""
            ElseIf pos = 4 Then
                Label20.Text = ""
            ElseIf pos = 5 Then
                Label21.Text = ""
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles cmdClear.Click
        txtDesParName.Text = ""
        txtEq.Text = ""
        txtValueEntry.Text = ""
        txtValueEntry2.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        lstDesPars.Items.Clear()
        lstValues.Items.Clear()
        lstValues2.Items.Clear()
        Label16.Text = ""
        Label17.Text = ""
        Label18.Text = ""
        Label19.Text = ""
        Label20.Text = ""
        Label21.Text = ""
        CheckBox1.CheckState = 0
        CheckBox2.CheckState = 0
        CheckBox3.CheckState = 0
        varCount = 0
        labelCount = 0
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtEq_TextChanged(sender As Object, e As EventArgs) Handles txtEq.TextChanged
        If txtEq.Focused = True And flagMenu = 0 Then
            MsgBox("Supported Symbols" & vbCrLf & "" & vbCrLf & "() Parenthesis" & vbCrLf &
                   "+ Add symbol" & vbCrLf &
            "- Subtract Symbol" & vbCrLf & "* Multiplication Symbol" & vbCrLf & "/ Divide Symbol" _
             & vbCrLf & "% Modulus Symbol" & vbCrLf & " ^ Exponent Symbol" & vbCrLf &
             "ABS() absolute of a number" & vbCrLf & "SIN() sine of a number" & vbCrLf &
             "COS() cosine of a number" & vbCrLf & "TAN() tangent of a number" & vbCrLf &
             "LOG base 10 logarithm of a number" & vbCrLf & "LOGN natural logarithm of a number")
            flagMenu = 1
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
    End Sub
End Class
