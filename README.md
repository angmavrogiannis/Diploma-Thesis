# Diploma-Thesis
Software Tool for Genetic-Algorithm-Based Optimization with Customized User-Inserted Criteria

# Overview
The present study examines the design and creation of a program, capable of receiving computational design equations as input, analyzing them using a suitable parser and optimizing them using Genetic Algorithms. The parser is used during the input of the equations. It allows the input of equations as text and, at a next step, the recognition of the variables and the operational symbols in the text body.

To demonstrate the aforementioned methodology, the simple problem of the stiffness of a cantilever beam and the problem of the minimization of the forces applied onto an object grasped by a robot hand will be the selected case studies.

# How it works

- Run the code on Microsoft Visual Studio. This will open up an optimization graphical user interface. The user must insert the data required to perform either a maximization or a minimization procedure based on a genetic algorithm.

![alt text](https://raw.githubusercontent.com/angmavrogiannis/Diploma-Thesis/master/optimization_app.png)

- Insert the design parameters in the field 'Design Parameters';
- Choose the type of the parameter: Real Constant/Real Continuous/Real Discrete and press 'Add'. A declared parameter can be deleted simply by choosing it and pressing the Delete button which is located right underneath the parameter list.
- Insert a minimum and a maximum value for the declared parameter in the related fields and press the 'Assign' button.
Note: Design Parameters and values can be deleted simply by selecting the name of the parameter or the value to be deleted and then pressing the related 'Delete' button.

- Insert the fitness function/objective function of the optimization problem, which has to contain variables that have already been declared in the previous fields. 
- Clicking on the TextBox named “Insert Equation” the user can see a menu with the supported symbols for the successful declaration of the objective function since the parser used is designed to understand specific symbols for executing mathematical operations.  
- Insert the starting population size for the genetic algorithm as well as the selection percentage in the related fields. The population size must be a positive integer and the percentage must be inserted in the following format: e.g for inserting a 60% selection percentage this is the proper input: 60 
- Choose between a generic method of selection or Roulette Wheel Selection by clicking on the related tickbox. If the user does not choose Roulette Wheel Selection, the fitness function values of the random chromosomes are calculated and sorted using a bubble sort procedure. 
- Choose between 'Maximization' and 'Minimization', depending on the problem you are trying to solve. 
- Optional: Insert a Crossover Point and/or a Mutation Percentage. Otherwise, the program chooses randomly these values and performs the optimization process accordingly.

- Insert number of iterations for the algorithm.
- If all declarations of the required values are submitted successfully, pressing the 'Solve' button performs the optimization procedure. 
-  A successful completion of the optimization process triggers a message which informs the user about the end of the procedure and creates a .txt file containing the consequent number of iterations along with the corresponding best fitness function value per iteration. Opening this file with Microsoft Office Excel and plotting this file, the user can view the results of the optimization process, which constitute of the progression of the fitness function value as the number of iterations increases.

Note: If the number of iterations is large enough (>3000) the procedure might take a while. If the user decides he wants to discard all the values and parameters he declared, he can press the 'Clear' button, which empties all the declared fields.

# Example 1: Maximization of the stiffness of a cantilever beam
![alt text](https://raw.githubusercontent.com/angmavrogiannis/Diploma-Thesis/master/rod.JPG)
