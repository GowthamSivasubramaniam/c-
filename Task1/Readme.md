# Basic Data Types, Control Structures, and MethodsObjective:Requirements:

## Objective
- Write a console application that calculates the factorial of a given number.
- Read an integer from the user.
- Validate the input (ensure it’s a positive integer).
- Use loops (or recursion) to calculate the factorial.
- Display the result in the console.

## 📌 Overview
This is a simple **Factorial Calculator** implemented in C#. The program calculates the factorial of a given number and displays the result. If the user enters `-1`, the program terminates.

## 🔧 Features
- Computes the factorial of non-negative integers.
- Uses **BigInteger** to handle large factorial values.
- Error handling for invalid inputs.
- Loops continuously until the user decides to exit.

## 🖥️ How It Works
1. The program prompts the user to enter a number.
2. If the number is **0 or 1**, it directly returns `1`.
3. For numbers **greater than 1**, it calculates the factorial using a loop.
4. If the user enters `-1`, the program exits with a **Thank You** message.
5. If the user enters an invalid input (e.g., floating-point numbers or non-numeric values), an error message is displayed.

## 📝 Example Output
```sh
This a Factorial Calculator . If you want end the Calculation enter -1
Enter a Number : 1
The factorial of 1 is :1
Enter a Number : 0
The factorial of 0 is :1
Enter a Number : 2
The factorial of 2 is :2
Enter a Number : 4
The factorial of 4 is :24
Enter a Number : 20
The factorial of 20 is :2432902008176640000
Enter a Number : 30
The factorial of 30 is :265252859812191058636308480000000
Enter a Number : 40
The factorial of 40 is :815915283247897734345611269596115894272000000000
Enter a Number : -1
Thankyou.
```




