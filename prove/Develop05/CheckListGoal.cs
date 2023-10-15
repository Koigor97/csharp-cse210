
public class CheckListGoal : Goal
{
    private string _typeOfGoal;
    private int _amountCompleted = 0;
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
        if (isComplete() && GetAmountCompleted() == _target)
        {
            AddSetPointToCurrentPoint();
            SetCheckMark();
        }
        else
        {
            AddSetPointToCurrentPoint();
            SetAmountCompleted();
        }
    }

    public override bool isComplete(bool param = false)
    {
        return param;
    }

    public override string GetDetailsString()
    {
        return $"{GetCheckMark()} {_shortName} - {_description} -- Progress status {GetAmountCompleted()}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_typeOfGoal}: {_shortName} | {_description} | {_setPoints} | {_bonus} | {_target} | {GetAmountCompleted()}";
    }

    public void SetAmountCompleted()
    {
        _amountCompleted++;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
}