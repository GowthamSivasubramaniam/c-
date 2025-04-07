public class Person
{
    public String name;
    public int age;
    public Person(String name, int age)
    {
      this.name=name;
      this.age=age;
    }
    public void introduce()
    {
        Console.WriteLine("Hi, I'm "+this.name + " and I'm "+this.age+" years old. ");
    }
    
}