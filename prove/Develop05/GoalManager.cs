

public class GoalManager
{
    private List<Goal> _goals = new ();
    private int _score;

    private string _folderPath = "savefolder/";

    public GoalManager()
    {

    }

    public void Start()
    {
        string theMenu = "1. Create New Goal ⚽️ | 2. List Goals 📝 | 3. Save Goals 🗳️ | 4. Load Goals ♽ | 5. Record Event ✍🏼 | 6. Quit ❌\n";
        bool isAppOn = true;

        do
        {
            Console.WriteLine(theMenu);
            Console.Write("Select a choice from the menu: ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
           {
                CreateGoal();
           }
           else if (userChoice == 2)
           {
                ListGoalDetails();
           }
           else if (userChoice == 3)
           {
                SaveGoal();
           }
           else if (userChoice == 4)
           {
                LoadGoals();
           }
           else if (userChoice == 5)
           {
                RecordEvent();
           }
           else if (userChoice == 6)
           {
                isAppOn =false;
                break;
           }

        } while (isAppOn);
    }

    private  void DisplayPlayerPoint()
    {

    }

    private void ListGoalNames()
    {

    }

    private void ListGoalDetails()
    {

    }

    private void CreateGoal()
    {
        string[] goalTypes = {"Simple Goal", "Eternal Goals", "Checklist Goals"};
        Console.WriteLine($"The types of goals are: 1. {goalTypes[0]} | 2. {goalTypes[1]} | 3. {goalTypes[2]}\n");
        Console.Write("What type of goal do you want create?: ");
        int typeOfGoal = int.Parse(Console.ReadLine()) - 1;

        if (typeOfGoal == 0)
        {
            SimpleGoal simpleGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[typeOfGoal]);
            _goals.Add(simpleGoal);
        }
        else if (typeOfGoal == 1)
        {
           EternalGoal eternalGoal = new (name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[typeOfGoal]);
           _goals.Add(eternalGoal);
        }
        else if (typeOfGoal == 2)
        {
            CheckListGoal checkListGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[typeOfGoal], target: SetCheckListCount(), bonus: SetBonusPoint());
            _goals.Add(checkListGoal);
        }
        else
        {
            Console.WriteLine("Invalid: This option does not exist.");
        }
    }

    private void RecordEvent()
    {

    }

    private void SaveGoal()
    {

    }

    private void LoadGoals()
    {

    }

////////////////////////////////////////////////////////////////////////////////
///////// Helper functions
    private string SetGoalName()
    {
        Console.Write("\nWhat is the name of the goal? : ");
        string _goalname = Console.ReadLine();
        return _goalname;
    }

    private int SetGoalPoint()
    {
        Console.Write("Enter the amount of point you want to achieve: ");
        int _goalPoint = int.Parse(Console.ReadLine());
        return _goalPoint;
    }

    private string SetGoalDescription()
    {
        Console.Write("Write a short description of the goal: ");
        string _goalDescription = Console.ReadLine();
        return _goalDescription;
    }

    private int SetBonusPoint()
    {
        Console.Write("Enter the amount of bonus point you want to achieve for this goal: ");
        int _bonusPoint = int.Parse(Console.ReadLine());
        return _bonusPoint;
    }

    private int SetCheckListCount()
    {
        Console.Write("How many times do you want to set for this goal to be completed? : ");
        int _checklistCount = int.Parse(Console.ReadLine());
        return _checklistCount;
    }
    
}