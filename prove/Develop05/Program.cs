using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------------Welcome to the Eternal Goal Setting Quest App-----------------\n");
        GoalManager goalManager = new();
        goalManager.Start();
    }
}