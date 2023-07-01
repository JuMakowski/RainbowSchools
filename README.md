# RainbowSchools
## Student Management System
This system is divided into three classes: Program, Students, and DataManager. The Program class acts as the entry point and calls the other classes to display student data on the screen.

### Program Class
The Program class contains the Main method, which serves as the starting point of the application. Within the Main method, the program follows the following steps:

Initializes an instance of the DataManager class.
Calls the GetData method of the DataManager class to retrieve student data.
Calls the DisplayStudents method of the DataManager class to display the student data on the screen.

### Students Class
The Students class is a simple class that defines the structure of student data. It does not perform any specific operations or methods related to managing or manipulating student data.

Typically, the Students class would have properties that represent different attributes of a student, such as Name, Age, Grade. These properties define the structure and organization of the student data.

### DataManager Class
The DataManager class is responsible for retrieving student data. In the current implementation, the class has a method called GetData, the GetData method retrieves student data from a text file. The class also provides a method named DisplayStudents, which iterates over the student data and prints it on the screen.

## Step-by-Step Development of the RainbowSchools Student Management System:
### Project Setup:

1. Create a new Visual Studio project and name it "RainbowSchools."

- Add three classes: Program, Students, and DataManager.
Students Class:

2. Define the Students class with properties for Name, Age, and Grade.

- The Students class serves as a model to represent individual student objects.

3. Define the DataManager class responsible for retrieving student data.

- Create a method called GetData to read student data from a text file.

- The GetData method reads the data from a text file, splits it, and fills a Students List objects.

- Create a method called DisplayStudents Method to print student data on the screen.

- The DisplayStudents method iterates over the list of Students objects and prints their details.

4. Program Class:

- Define the Program class with the Main method as the entry point of the application.

- Within the Main method, create an instance of the DataManager class.

- Create an instance of List of Students.

- Call the GetData method of the DataManager class to retrieve student data from the text file.

- Call the DisplayStudents method of the DataManager class to print student data on the screen.

