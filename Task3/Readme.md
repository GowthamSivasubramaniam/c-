# 📋 Task Manager – Basic Collections and String Manipulation

A simple C# console app that demonstrates the use of `List<string>`, loops, user input handling, and basic string methods like `Trim()`.

---

## 🎯 Objective

- Manage a list of tasks (strings) using a console-based UI.
- Use a `List<string>` to store and manipulate items.
- Allow users to:
  - Add a new task
  - Remove a task by ID
  - Display all current tasks
- Apply basic string processing and input validation.

---

## 🧠 Program Overview

### 🏗️ Class Structure

- The app is built within the `Main()` method of the `Program` class.
- No custom class is used — this is a procedural, beginner-friendly approach.

### 📜 Menu System

The program shows a repeating menu with four options:


### ⚙️ Core Logic

- **Add Task:**  
  Prompts for a string input, trims it, and adds it to the list.
- **Remove Task by ID:**  
  Prompts for an index (task ID) and removes the task if it exists.
- **Display Tasks:**  
  Loops through the list and prints tasks with their index values.
- **Exit:**  
  Ends the program gracefully with a thank-you message.

### 🛡️ Input Validation

- Ensures the entered menu option is within range (1–4).
- Prevents removing from an empty list.

---

## 🧾 Sample Output

```sh
Options 

  1 : Add new task 
  2 : Enter id to Remove task 
  3 : Display Tasks 
  4 : Exit 

Enter Option : 1
Enter the Task : Schedule meeting
Task Added Successfully

Enter Option : 3
Task id : 0 task : Schedule meeting

Enter Option : 2
Enter the Task id you want to remove :0
Task 0 removed Successfully

Enter Option : 5
Invalid Option

Enter Option : 4
Thank You
