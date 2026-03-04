using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine();

        int userNumber = 1;
        int sum = 0;
        int largest = 0;
        List<int> numberList = new List<int>();

        while (userNumber != 0)
        {
            Console.Write("Enter a number, type 0 when finished. ");
            string number = Console.ReadLine();
            userNumber = int.Parse(number);

            if (userNumber == 0)
            {
                int listNumbers = numberList.Count();
                int average = sum / listNumbers;

                Console.WriteLine($"The sum of your numbers is {sum}");
                Console.WriteLine($"The average is {average}");
                Console.WriteLine($"The largest number is {largest}");
            }

            sum += userNumber;
            numberList.Add(userNumber);

            if (userNumber > largest)
            {
                largest = userNumber;
            }
        }
    }
}