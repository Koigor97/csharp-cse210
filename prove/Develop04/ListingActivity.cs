// The Listing Class as well nherits from the Asset class. It allows the user to list down things/notes based on randomly generated prompts.

public class Listing : Activity
{
    private string _activityName = "Listing";
    private string _introMsg = "This activity will guide you in listing your thoughts and feelings in response to a given prompt. It's a helpful way to reflect on your experiences and gain clarity on your emotions.";
    private string _listFileName = "list.txt";
    private List<string> _UsedListingPrompt = new ();
    private List<string> _userInputs = new ();

    public Listing()
    {
    }

    private void DisplayListItem()
    {
        WelcomeMsg(_activityName, _introMsg);
        int interval = GetSessionTime() / 3;
        Console.WriteLine($"List as many responses you can to the following prompt:\n\n---- {GetPrompt(_UsedListingPrompt, _listFileName)} ----");
        Console.Write("You may begin in: ");
        CountDown(GetTimer());
        do
        {
          Console.Write("> ");
          string listResponse = Console.ReadLine();
          _userInputs.Add(listResponse);
          interval--;
        } while (interval > 0);
    }

    private void ListAmount()
    {
        Console.WriteLine($"You listed {_userInputs.Count} items!");
        CompletionMsg(GetSessionTime(), _activityName);
    }

    public void Run()
    {
        DisplayListItem();
        ListAmount();
    }
}


// "This activity will guide you in listing your thoughts and feelings in response to a given prompt. It's a helpful way to reflect on your experiences and gain clarity on your emotions."