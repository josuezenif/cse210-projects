using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Type in your grade: ");
        string grade = Console.ReadLine();
        float studentGrade = int.Parse(grade);

        if (studentGrade >= 90)
        {
            string letter = "A";
            Console.WriteLine($"Congratulations! You passed the class with an {letter}!");
        }

        else if (studentGrade >= 80 && studentGrade < 90)
        {
            string letter = "B";
            Console.WriteLine($"Congratulations! You passed the class with a {letter}!");
        }

        else if (studentGrade >= 70 && studentGrade < 80)
        {
            string letter = "C";
            Console.WriteLine($"Congratulations! You passed the class with a {letter}!");
        }

        else if (studentGrade >= 60 && studentGrade < 70)
        {
            string letter = "D";
            Console.WriteLine($"Sorry, you did not pass the class! You got a {letter} :(");
        }

        else
        {
            string letter = "F";
            Console.WriteLine($"Sorry, you did not pass! You got an {letter} for FRACASADO!");
        }
    }
}