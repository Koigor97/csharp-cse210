
public class CheckListGoal : Goal
{
    private string _typeOfGoal;
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, string goal, int target, int bonus) : base(name, description, points)
    {
        _typeOfGoal = goal;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool isComplete(bool param)
    {
        throw new NotImplementedException();
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}