using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> listOfNumbers = new();
        int userInput;
        int sum = 0;
        int largestNumber = 0;
        int smallestPositiveNumber = listOfNumbers[0];

        do
        { 
            Console.Write("Enter the number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0) listOfNumbers.Add(userInput);
            
        } while ( userInput != 0);

        foreach (int num in listOfNumbers)
        {
            sum += num;
            largestNumber = num >= largestNumber ? num : largestNumber;
            smallestPositiveNumber =  int.IsPositive(num) ? (num <= smallestPositiveNumber ? num : smallestPositiveNumber) : smallestPositiveNumber;
        }

        double average = sum / listOfNumbers.Count;
        
        Console.WriteLine($"\nThe sum of number in the list is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}\n");
        Console.WriteLine($"The sorted list is ↓:");

        listOfNumbers.Sort();
        foreach (var num in listOfNumbers)
        {
            Console.WriteLine(num);
        }
    }   
}