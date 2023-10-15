
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
        if (isComplete())
        {
            AddSetPointToCurrentPoint();
            SetCheckMark();
        }
    }

    public override bool isComplete(bool param = false)
    {
        _isComplete = param;
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{_typeOfGoal}: {_shortName} | {_description} | {_setPoints} | {isComplete()}";
    }
}