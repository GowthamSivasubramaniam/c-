# Generics and Interfaces with a Repository PatternObjective:Requirements:

## Objective
- Implement a generic in-memory repository to perform CRUD operations.
- Define an interface (e.g., `IRepository<T>`) with methods like `Add`, `Get`, `Update`, and `Delete`.
- Create a generic class that implements this interface.
- Use type constraints if necessary (e.g., where `T : class` or implementing a specific interface).
- Write a simple console UI to demonstrate the repository with a sample entity (e.g., `Product` or `Student`).



---
## 📝 Example Output
```sh
Options 

  1 : Add new Product 
  2 : Remove product with id 
  3 : Display products 
  4 : Exit 


Enter Option : 1

Enter the Product Name: mobile
Enter the Price: 1234445
Product Added Successfully

 
Options 

  1 : Add new Product 
  2 : Remove product with id 
  3 : Display products 
  4 : Exit 


Enter Option : 1

Enter the Product Name: laptop
Enter the Price: 123232312
Product Added Successfully

 
Options 

  1 : Add new Product 
  2 : Remove product with id 
  3 : Display products 
  4 : Exit 


Enter Option : 3
 Id: 0 Item :mobile - Rs.1234445
 Id: 1 Item :laptop - Rs.123232312
 
Options 

  1 : Add new Product 
  2 : Remove product with id 
  3 : Display products 
  4 : Exit 


Enter Option : 2

Enter the id:1
Removed item


 
Options 

  1 : Add new Product 
  2 : Remove product with id 
  3 : Display products 
  4 : Exit 


Enter Option : 3
 Id: 0 Item :mobile - Rs.1234445
 
Options 

  1 : Add new Product 
  2 : Remove product with id 
  3 : Display products 
  4 : Exit 


Enter Option : 4

Thank You
