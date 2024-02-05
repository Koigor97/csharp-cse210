namespace refresher;

class Program
{
    static void Main(string[] args)
    {
        Array array = new Array(); 

        string prompt = "What is your name: ";
        Console.Write(prompt);
        string response = Console.ReadLine();

        string output = $"Hello {response}. Nice to meet you";
        Console.WriteLine(output);

        DateTime dateOfBirth = new DateTime(1997, 12, 3);
        Console.WriteLine(dateOfBirth.DayOfWeek);

        int[] Array arrayList = array.GetArray(6);
        foreach (int element in arrayList)
        {
            Console.WriteLine(element);
        }

    }
}
