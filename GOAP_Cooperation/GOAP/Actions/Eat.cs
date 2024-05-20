using System.Numerics;
using GOAP_Cooperation.Entity;

public class Eat : BaseAction
{
    public Eat(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.Food};
        ResultType = ActionType.Eat;
        Name = "Eat";
    }
}