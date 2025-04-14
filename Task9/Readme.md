# Reflection and Custom AttributesObjective:Requirements:

## Objective
- Build an application that discovers and executes methods based on custom attributes.
- Define a custom attribute (e.g., `[Runnable]`).
- Create several classes with methods decorated with the `[Runnable]` attribute.
- Use reflection to scan the current assembly for methods marked with `[Runnable]`.
- Invoke the discovered methods dynamically and display their outputs.


## 📝 Example Output
```sh
Scanning for methods marked with [Runnable]...

Running: Task1.SayHello
Task1: Hello from SayHello!

[NotRunnable] Found: Task1.NotRunnable 
This won't be run because it's not marked.

Running: Task2.ShowDate
Task2: Today's date is 4/10/2025

All [Runnable] methods executed.
```




