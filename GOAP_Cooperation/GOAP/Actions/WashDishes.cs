using GOAP_Cooperation.Entity;

namespace GOAP_Cooperation.GOAP.Actions;

public class WashDishes : BaseAction
{
    public WashDishes(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.None};
        ResultType = ActionType.CleanDishes;
        Name = "WashDishes";
    }
}