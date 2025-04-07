# Working with Collections and LINQObjective:Requirements:

## Objective
- - Create a student management console application.
- Define a `Student` class with properties such as `Name`, `Grade`, and `Age`.
- Populate a collection (e.g., a `List<Student>`) with sample data.
- Use LINQ to:
    - Filter students who have a grade above a certain threshold.
    - Sort the filtered results by name or grade.
- Display the filtered and sorted list.

### Program Overview 

 This is a simple C# console application demonstrating basic object-oriented programming and LINQ queries. The program allows users to:
- Add student records.
- Filter students based on their grade.
- Sort results by name and grade.

---

## ✅  Features

1. **Object-Oriented Programming (OOP)**
   - Implements a `Student` class with properties: `name`, `age`, and `grade`.

2. **User Interaction**
   - Menu-driven interface to add, filter, or exit.
   - Handles invalid inputs with proper error checking.

3. **LINQ Operations**
   - Uses LINQ to filter students by grade threshold.
   - Applies ordering using `OrderBy` and `ThenBy`.

4. **String & Collection Manipulation**
   - Utilizes `List<Student>` to store student data.
   - Uses string methods like `Trim()` and `ToUpper()` to sanitize input.

---
## 📝 Example Output
```sh
Options 

  1 : Add new student 
  2 : Filter students with grade 
  3 : Exit 


Enter Option : 1      

Enter the Student Name: Gowtham
Enter the Age: 22
Enter the Grade (A/B/C...): A
Student Added Successfully

 
Options 

  1 : Add new student 
  2 : Filter students with grade 
  3 : Exit 


Enter Option : 1

Enter the Student Name: Gowtham
Enter the Age: 21
Enter the Grade (A/B/C...): B
Student Added Successfully

 
Options 

  1 : Add new student 
  2 : Filter students with grade 
  3 : Exit 


Enter Option : Gowtham
Enter valid Option
 
Options 

  1 : Add new student 
  2 : Filter students with grade 
  3 : Exit 


Enter Option : 1

Enter the Student Name: Gowtham   
Enter the Age: 21
Enter the Grade (A/B/C...): A
Student Added Successfully

 
Options 

  1 : Add new student 
  2 : Filter students with grade 
  3 : Exit 


Enter Option : 2

Enter the grade Threshold to filter:B
Gowtham-22-A
Gowtham-21-A
Gowtham-21-B


 
Options 

  1 : Add new student 
  2 : Filter students with grade 
  3 : Exit 


Enter Option : 3

Thank You
```




