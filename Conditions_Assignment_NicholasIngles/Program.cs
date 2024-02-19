// See https://aka.ms/new-console-template for more information
using System.IO.Pipes;

Console.WriteLine("Pick an option:");
Console.WriteLine("1. Determine the Greater Number");
Console.WriteLine("2. Grade Calculator");
Console.WriteLine("3. Leap Year Checker");
Console.WriteLine("4. Number Classification");
Console.WriteLine("5. Rock, Paper, Scissors Game\n");
string input = Console.ReadLine();

if (input == "1")
{
    Console.Write("\nDetermine the Greater Number selected.\nEnter first number: ");
    string stringnumber1 = Console.ReadLine();
    Console.Write("Enter second number: ");
    string stringnumber2 = Console.ReadLine();

    try
    {
        double number1 = double.Parse(stringnumber1);
        double number2 = double.Parse(stringnumber2);
        if (number1 > number2)
        {
            Console.WriteLine(number1 + " is greater than " + number2 + ".");
        }
        else if (number1 < number2)
        {
            Console.WriteLine(number2 + " is greater than " + number1 + ".");
        }
        else if (number1 == number2)
        {
            Console.WriteLine("Numbers are equal.");
        }
        else
        {
            Console.WriteLine("\nAn error occured. Please try again.");
        }

    }
    catch
    {
        Console.WriteLine("An error occured. Please try again.");
    }

}
else if (input == "2")
{
    Console.Write("\nGrade Calculator selected.\nEnter grade score: ");
    string stringscore = Console.ReadLine();
    try
    {
        double gradescore = double.Parse(stringscore);
        if (gradescore >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (gradescore >= 80 && gradescore < 90)
        {
            Console.WriteLine("Grade: B");
        }
        else if (gradescore >= 70 && gradescore < 80)
        {
            Console.WriteLine("Grade: C");
        }
        else if (gradescore >= 60 && gradescore < 70)
        {
            Console.WriteLine("Grade: D");
        }
        else if (gradescore >= 0 && gradescore < 60)
        {
            Console.WriteLine("Grade: F");
        }
        else
        {
            Console.WriteLine("\nAn error occured. Please try again.");
        }
    }
    catch
    {
        Console.WriteLine("\nAn error occured. Please try again.");
    }
}
else if (input == "3")
{
    Console.Write("\nLeap Year Checker selected.\nEnter year: ");
    string stringyear = Console.ReadLine();
    try
    {
        int year = int.Parse(stringyear);
        bool isLeapYear = year % 4 == 0;
        Console.WriteLine(isLeapYear);
    }
    catch
    {
        Console.WriteLine("\nAn error occured. Please try again.");
    }
}
else if (input == "4")
{
    Console.Write("\nNumber Classification selected.\nEnter number: ");
    string stringclassification = Console.ReadLine();

    try
    {
        double classificationnumber = double.Parse(stringclassification);
        if (classificationnumber > 0)
        {
            Console.WriteLine("Number is positive.");
        }
        else if (classificationnumber < 0)
        {
            Console.WriteLine("Number is negative.");
        }
        else if (classificationnumber == 0)
        {
            Console.WriteLine("Number is zero.");
        }
        else
        {
            Console.WriteLine("\nAn error occured. Please try again.");
        }
    }
    catch
    {
        Console.WriteLine("An error occured. Please try again.");
    }
}
else if (input == "5")
{
    Console.WriteLine("\nRock, Paper, Scissors Game selected.\nRock, Paper, or Scissors?");
    string usermove = Console.ReadLine();

}
else
{
    Console.WriteLine("Invalid input. Try again.");
}