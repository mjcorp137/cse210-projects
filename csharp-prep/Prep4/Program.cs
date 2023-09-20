using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        //  MY LIST -------
        List<int> numbers = new List<int>();

        // ASK THE USER ------
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;

        // while loop for adding till zero
        while (userNumber != 0){
            Console.Write("Enter number: ");
            string addnumber = Console.ReadLine();
            userNumber = int.Parse(addnumber);
            if (userNumber != 0){
                numbers.Add(userNumber);
            }
        }
        // add all the total
        int sum = 0;
        foreach (int number in numbers){
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // formula for getting the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //getting the highest number
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
    }
}