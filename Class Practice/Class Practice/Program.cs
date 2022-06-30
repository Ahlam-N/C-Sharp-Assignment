// See https://aka.ms/new-console-template for more information
class Employee
{
    private string _name;
    public string name
    {
        get => _name; 
        set => _name = value; 
    }
}
class program
{
    public static void Main (string[] args)
    {
        Employee emp = new Employee();
        emp.name = "Sumeya";
       Console.WriteLine(emp.name);
      // emp.name=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine
    }
}
