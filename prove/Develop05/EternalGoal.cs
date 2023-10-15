
public class EternalGoal : Goal
{
    private string _typeOfGoal;

    public EternalGoal(string name, string description, int points, string goal) : base(name, description, points)
    {
        _typeOfGoal = goal;
    }

    public override void RecordEvent()
    {
        
    }

    public override bool isComplete(bool param)
    {
         return param;
    }

    public override string GetStringRepresentation()
    {
        return $"{_typeOfGoal}: {base._shortName} | {base._description} | {base._points}";
    }


}