public class Student 
{
    public string name;

    public Student(string name)
    {
        this.name = name;
    }

    public string StudentHello()
    {
        return $"Hello, my name is {this.name}";
    }
}