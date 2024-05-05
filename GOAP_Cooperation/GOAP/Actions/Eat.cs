using System.Numerics;

public class Eat : BaseAction
{
    public Eat(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.Food};
        ResultType = ActionType.Eat;
        Name = "Eat";
    }
}