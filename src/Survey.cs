using System;

namespace InputOutput
{
    public class Survey
    {
        string name, month;
        int age;
        public void MakeSurvey()
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Birth Month: ");
            month = Console.ReadLine();
            Console.WriteLine($"Your name is {name} and you born in {month} and now you are {age} years old.");
        }
    }
}