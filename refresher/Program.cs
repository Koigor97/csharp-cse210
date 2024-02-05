namespace refresher;

class Program
{
    static void Main(string[] args)
    {
        string prompt = "What is your name: ";
        Console.Write(prompt);
        string response = Console.ReadLine();

        string output = $"Hello {response}. Nice to meet you";
        Console.WriteLine(output);

    }
}
