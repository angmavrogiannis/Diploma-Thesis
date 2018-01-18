<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesParName = New System.Windows.Forms.TextBox()
        Me.cmdAddDesPar = New System.Windows.Forms.Button()
        Me.cmdSolve = New System.Windows.Forms.Button()
        Me.cmdDelDesPar = New System.Windows.Forms.Button()
        Me.lstDesPars = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstDesParType = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdAssignValue = New System.Windows.Forms.Button()
        Me.cmdDelValue = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtValueEntry = New System.Windows.Forms.TextBox()
        Me.lstValues = New System.Windows.Forms.ListBox()
        Me.txtValueEntry2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstValues2 = New System.Windows.Forms.ListBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdDelValue2 = New System.Windows.Forms.Button()
        Me.txtEq = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txtDesParName
        '
        Me.txtDesParName.Location = New System.Drawing.Point(86, 110)
        Me.txtDesParName.Name = "txtDesParName"
        Me.txtDesParName.Size = New System.Drawing.Size(210, 26)
        Me.txtDesParName.TabIndex = 1
        '
        'cmdAddDesPar
        '
        Me.cmdAddDesPar.Location = New System.Drawing.Point(151, 277)
        Me.cmdAddDesPar.Name = "cmdAddDesPar"
        Me.cmdAddDesPar.Size = New System.Drawing.Size(51, 31)
        Me.cmdAddDesPar.TabIndex = 2
        Me.cmdAddDesPar.Text = "Add"
        Me.cmdAddDesPar.UseVisualStyleBackColor = True
        '
        'cmdSolve
        '
        Me.cmdSolve.Location = New System.Drawing.Point(137, 790)
        Me.cmdSolve.Name = "cmdSolve"
        Me.cmdSolve.Size = New System.Drawing.Size(99, 31)
        Me.cmdSolve.TabIndex = 3
        Me.cmdSolve.Text = "Solve"
        Me.cmdSolve.UseVisualStyleBackColor = True
        '
        'cmdDelDesPar
        '
        Me.cmdDelDesPar.Location = New System.Drawing.Point(453, 277)
        Me.cmdDelDesPar.Name = "cmdDelDesPar"
        Me.cmdDelDesPar.Size = New System.Drawing.Size(73, 31)
        Me.cmdDelDesPar.TabIndex = 4
        Me.cmdDelDesPar.Text = "Delete"
        Me.cmdDelDesPar.UseVisualStyleBackColor = True
        '
        'lstDesPars
        '
        Me.lstDesPars.FormattingEnabled = True
        Me.lstDesPars.ItemHeight = 20
        Me.lstDesPars.Location = New System.Drawing.Point(444, 110)
        Me.lstDesPars.Name = "lstDesPars"
        Me.lstDesPars.Size = New System.Drawing.Size(92, 144)
        Me.lstDesPars.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(382, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Available Design Parameters"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(151, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Type"
        '
        'lstDesParType
        '
        Me.lstDesParType.FormattingEnabled = True
        Me.lstDesParType.ItemHeight = 20
        Me.lstDesParType.Items.AddRange(New Object() {"Real Constant", "Real Continuous", "Real Discrete"})
        Me.lstDesParType.Location = New System.Drawing.Point(86, 184)
        Me.lstDesParType.Name = "lstDesParType"
        Me.lstDesParType.Size = New System.Drawing.Size(210, 64)
        Me.lstDesParType.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(90, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Design Parameters"
        '
        'cmdAssignValue
        '
        Me.cmdAssignValue.Location = New System.Drawing.Point(137, 505)
        Me.cmdAssignValue.Name = "cmdAssignValue"
        Me.cmdAssignValue.Size = New System.Drawing.Size(74, 31)
        Me.cmdAssignValue.TabIndex = 10
        Me.cmdAssignValue.Text = "Assign"
        Me.cmdAssignValue.UseVisualStyleBackColor = True
        '
        'cmdDelValue
        '
        Me.cmdDelValue.Location = New System.Drawing.Point(392, 505)
        Me.cmdDelValue.Name = "cmdDelValue"
        Me.cmdDelValue.Size = New System.Drawing.Size(74, 31)
        Me.cmdDelValue.TabIndex = 11
        Me.cmdDelValue.Text = "Delete"
        Me.cmdDelValue.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Value Entry"
        '
        'txtValueEntry
        '
        Me.txtValueEntry.Location = New System.Drawing.Point(86, 440)
        Me.txtValueEntry.Name = "txtValueEntry"
        Me.txtValueEntry.Size = New System.Drawing.Size(68, 26)
        Me.txtValueEntry.TabIndex = 13
        '
        'lstValues
        '
        Me.lstValues.FormattingEnabled = True
        Me.lstValues.ItemHeight = 20
        Me.lstValues.Location = New System.Drawing.Point(386, 375)
        Me.lstValues.Name = "lstValues"
        Me.lstValues.Size = New System.Drawing.Size(92, 124)
        Me.lstValues.TabIndex = 14
        '
        'txtValueEntry2
        '
        Me.txtValueEntry2.Location = New System.Drawing.Point(200, 440)
        Me.txtValueEntry2.Name = "txtValueEntry2"
        Me.txtValueEntry2.Size = New System.Drawing.Size(68, 26)
        Me.txtValueEntry2.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "min value"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "max value"
        '
        'lstValues2
        '
        Me.lstValues2.FormattingEnabled = True
        Me.lstValues2.ItemHeight = 20
        Me.lstValues2.Location = New System.Drawing.Point(502, 375)
        Me.lstValues2.Name = "lstValues2"
        Me.lstValues2.Size = New System.Drawing.Size(92, 124)
        Me.lstValues2.TabIndex = 18
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(386, 787)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 34)
        Me.cmdClose.TabIndex = 19
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdDelValue2
        '
        Me.cmdDelValue2.Location = New System.Drawing.Point(511, 505)
        Me.cmdDelValue2.Name = "cmdDelValue2"
        Me.cmdDelValue2.Size = New System.Drawing.Size(75, 31)
        Me.cmdDelValue2.TabIndex = 20
        Me.cmdDelValue2.Text = "Delete"
        Me.cmdDelValue2.UseVisualStyleBackColor = True
        '
        'txtEq
        '
        Me.txtEq.Location = New System.Drawing.Point(270, 567)
        Me.txtEq.Name = "txtEq"
        Me.txtEq.Size = New System.Drawing.Size(114, 26)
        Me.txtEq.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(306, 705)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 20)
        Me.Label8.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(93, 567)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Insert Equation"
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(270, 790)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 31)
        Me.cmdClear.TabIndex = 26
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(92, 602)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Population Size"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(78, 637)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(179, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Selection Percentage %"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(270, 602)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 26)
        Me.TextBox1.TabIndex = 30
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(270, 634)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(114, 26)
        Me.TextBox2.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(81, 737)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 20)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Number of Iterations"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(270, 737)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(114, 26)
        Me.TextBox4.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(388, 352)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 20)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "min values"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(507, 352)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 20)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "max values"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(354, 375)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 20)
        Me.Label16.TabIndex = 37
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(354, 396)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 20)
        Me.Label17.TabIndex = 38
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(354, 416)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 20)
        Me.Label18.TabIndex = 39
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(354, 436)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 20)
        Me.Label19.TabIndex = 40
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(354, 456)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(0, 20)
        Me.Label20.TabIndex = 41
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(354, 476)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 20)
        Me.Label21.TabIndex = 42
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(477, 569)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(126, 24)
        Me.CheckBox1.TabIndex = 43
        Me.CheckBox1.Text = "Maximization"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(477, 604)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(122, 24)
        Me.CheckBox2.TabIndex = 44
        Me.CheckBox2.Text = "Minimization"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(477, 668)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(215, 24)
        Me.CheckBox3.TabIndex = 45
        Me.CheckBox3.Text = "Roulette Wheel Selection"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(93, 672)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 20)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Crossover Point"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(81, 705)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(157, 20)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Mutation Percentage"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(270, 672)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(114, 26)
        Me.TextBox3.TabIndex = 48
        Me.TextBox3.Text = "Optional" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(270, 704)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(114, 26)
        Me.TextBox5.TabIndex = 49
        Me.TextBox5.Text = "Optional"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 842)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEq)
        Me.Controls.Add(Me.cmdDelValue2)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lstValues2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtValueEntry2)
        Me.Controls.Add(Me.lstValues)
        Me.Controls.Add(Me.txtValueEntry)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdDelValue)
        Me.Controls.Add(Me.cmdAssignValue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstDesParType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstDesPars)
        Me.Controls.Add(Me.cmdDelDesPar)
        Me.Controls.Add(Me.cmdSolve)
        Me.Controls.Add(Me.cmdAddDesPar)
        Me.Controls.Add(Me.txtDesParName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Optimization App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDesParName As TextBox
    Friend WithEvents cmdAddDesPar As Button
    Friend WithEvents cmdSolve As Button
    Friend WithEvents cmdDelDesPar As Button
    Friend WithEvents lstDesPars As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstDesParType As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdAssignValue As Button
    Friend WithEvents cmdDelValue As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtValueEntry As TextBox
    Friend WithEvents lstValues As ListBox
    Friend WithEvents txtValueEntry2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lstValues2 As ListBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdDelValue2 As Button
    Friend WithEvents txtEq As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmdClear As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
