
using System;

public class TallGuy : IDunk {
    public string _Name;
    public double _Height;

    public TallGuy (string name, double hieght)
    {
        _Name = name;
        _Height = hieght;
    }
    public void TalkAboutYourself()
    {
        Console.WriteLine($"My name is {_Name} and I'm {_Height} inches tall.");
    }

    public string DunkWordsToSay
    {
        get { return "Double beepbop 🥴";}
    }

    public string SwirlyDunk()
    {
        return "ElSquirlTorDunkdo...!!!";
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        TallGuy tallGuy = new (name: "Samuel", hieght: 6.7);
        tallGuy.TalkAboutYourself();

        Console.WriteLine($"{tallGuy._Name} is gonna go {tallGuy.DunkWordsToSay} on you. {tallGuy.SwirlyDunk()} mode.. activated ✅");

    }
}


