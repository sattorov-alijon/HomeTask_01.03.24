namespace Tasc1;

public class Teacher:Person
{
    public void Explaing()
    {
        System.Console.WriteLine("The teacher is explainging");
    }
    public Teacher(string name):base(name)
    {
        Name=name;
    }
}
