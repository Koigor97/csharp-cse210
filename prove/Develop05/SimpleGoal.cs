
public class SimpleGoal : Goal
{
    private string _typeOfGoal;
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, string goal) : base(name, description, points)
    {
        _typeOfGoal = goal;
    }

    public override void RecordEvent()
    {
        
    }

    public override bool isComplete(bool param = false)
    {
         return _isComplete = param;
    }

    public override string GetStringRepresentation()
    {
        return $"{_typeOfGoal}: {base._shortName} | {base._description} | {base._points} | {isComplete()}";
    }
}