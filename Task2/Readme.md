# Simple Object-Oriented Programming (OOP)Objective:Requirements:

## Objective
- Create a `Person` class with properties and methods.
- Define properties such as `Name` and `Age`.
- Implement a method `Introduce()` that prints a personalized greeting.
- Instantiate a few `Person` objects in your `Main` method and call `Introduce()` on each.

### Program Overview 

 **Class Structure**  
   - Assumes there's a `Person` class (not shown in the code) with a constructor that takes `name` and `age` as parameters.
   - The class likely has a method called `introduce()` that prints or returns a self-introduction message.

 **Object Creation**  
   Inside the `Main()` method, **three `Person` objects** are created using:
   ```csharp
   new Person("Name", Age);
   ```
   Example:
   ```csharp
   Person person1 = new Person("Gowtham", 22);
   ```

 **Method Invocation**  
   Each object then calls the `introduce()` method:
   ```csharp
   person1.introduce();
   ```
   This method likely outputs something like:
   ```
   Hi, I'm Gowtham and I'm 22 years old.
   ```

## 📝 Example Output
```sh
Hi, I'm Gowtham and I'm 22 years old. 
Hi, I'm Muthu and I'm 22 years old. 
Hi, I'm Mano and I'm 22 years old. 
```




