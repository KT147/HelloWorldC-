using System.Collections;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float GPA { get; set; }

    public Student(int id, string name, float GPA)
    {
        this.Id = id;
        this.Name = name;
        thisGPA = GPA;
    }
}

class Main
{
    static void Main(string[] args)
    {
        Hashtable studentsTable = new Hashtable();

        Student stud1 = new Student(1, "Maria", 22);
        Student stud2 = new Student(2, "Joe", 32);
        Student stud3 = new Student(3, "Clara", 42);
        Student stud4 = new Student(4, "Steve", 52);

        studentsTable.Add(stud1.Id, stud1);
        studentsTable.Add(stud2.Id, stud2);
        studentsTable.Add(stud3.Id, stud3);
        studentsTable.Add(stud4.Id, stud4);

        Student storedStudents1 = (Students)Table[1];

        foreach (DictionaryEntry entry in studentsTable)
        {
            Student temp = (Student)entry.Value;
            System.Console.WriteLine("Student ID " + temp.Id);
            System.Console.WriteLine("Student Name " + temp.Name);
             System.Console.WriteLine("Student Gpa " + temp.GPA);
        }
              
    }
}