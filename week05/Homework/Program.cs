using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine();

        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Josue Zenif");
        assignment1.GetStudentName();

        assignment1.SetTopic("Web Development");
        assignment1.GetTopic();
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math = new MathAssignment("Josue Zenif", "Web Development", "Section 7.4", "Problems 12-20");
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("Josue Zenif", "Web development", "Programming with classes");
        Console.WriteLine(writing.GetWritingInformation());

        Console.WriteLine();
    }
}