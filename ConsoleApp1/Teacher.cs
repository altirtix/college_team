public class Teacher 
{
    public string name;

    public Teacher(string name)
    {
        this.name = name;
    }

    public string TeacherHello()
    {
        return $"Hello, my name is {this.name}";
    }
}
