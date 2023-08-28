// See https://aka.ms/new-console-template for more information
using data_structures.Dynamic_Array;

Console.WriteLine("Hello, World!");
Class1 myTestClass = new Class1();

public class Class1
{
    public class Car
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Car() { }
        public Car(string _name, string _desc)
        {
            this.Description = _desc;
            this.Name = _name;
        }
    }

    public Class1()
    {
        DynamicArray<Car> myCarArr = new DynamicArray<Car>(6);
        myCarArr.Add(new Car(){ Name = "0", Description = ""});
        myCarArr.Add(new Car() { Name = "1", Description = "" });
        myCarArr.Add(new Car() { Name = "2", Description = "" });
        myCarArr.Add(new Car() { Name = "3", Description = "" });
        myCarArr.Add(new Car() { Name = "4", Description = "" });
        myCarArr.Add(new Car() { Name = "5", Description = "" });
        Console.WriteLine(myCarArr.ToString());
        myCarArr.RemoveAt(2);
        foreach(Car item in myCarArr)
        {
            Console.WriteLine(item.Name);
        }
    }
}