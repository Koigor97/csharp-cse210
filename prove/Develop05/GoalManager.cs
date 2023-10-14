

public class GoalManager
{
    private List<Goal> _goals = new ();
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        string theMenu = "1. Create New Goal ⚽️ | 2. List Goals 📝 | 3. Save Goals 🗳️ | 4. Load Goals ♽ | 5. Record Event ✍🏼 | 6. Quit ❌\n";
        Console.WriteLine(theMenu);
    }

    
}