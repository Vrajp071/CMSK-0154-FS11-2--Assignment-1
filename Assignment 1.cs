public enum StudentType
{
    Unknown,
    PartTime,
    FullTime
}

public class Student
{
    public int Id { get; set; }
    public StudentType Type { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public static Student CreateStudent(int? id, StudentType type, string firstName, string lastName)
    {
        var student = new Student
        {
            Id = id ?? 0,
            Type = type,
            FirstName = firstName ?? "Unknown",
            LastName = lastName ?? ""
        };
        return student;
    }

    public void OutputStudent()
    {
        Console.WriteLine($"Student : {Id:000} {FirstName} {LastName} ({Type})");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var student1 = Student.CreateStudent(1, StudentType.FullTime, "John", "Anderson");
        student1.OutputStudent();

        var student2 = Student.CreateStudent(2, StudentType.FullTime, "Karen", "Smith");
        student2.OutputStudent();

        var student3 = Student.CreateStudent(3, StudentType.FullTime, "Kevin", "Peters");
        student3.OutputStudent();
    }
}
