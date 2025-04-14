public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string ID { get; set; }

    public Student(string name, int age, string id)
    {
        Name = name;
        Age = age;
        ID = id;
    }

    public override string ToString()
    {
        return Name;
    }
}
