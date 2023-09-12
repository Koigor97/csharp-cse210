using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUser()
        {
            Console.Write("What is your name: ");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite/lucky number: ");
            return int.Parse(Console.ReadLine());
        }

        static int SqureNumber(int num)
        {
            return num * num;
        }

        static void DisplayResult(string theName, int squareNum)
        {
            Console.WriteLine($"{theName}, the square of your number is {squareNum}");
        }

        static void MainFunction()
        {
            DisplayWelcome();

            string userName = PromptUser();
            int userNumber = PromptUserNumber();
            int numberSquared = SqureNumber(userNumber);

            DisplayResult(userName, numberSquared);
        }

        MainFunction();

    }
}