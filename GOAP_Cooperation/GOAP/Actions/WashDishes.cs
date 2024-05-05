namespace GOAP_Cooperation.GOAP.Actions;

public class WashDishes : BaseAction
{
    public WashDishes(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.None};
        ResultType = ActionType.CleanDishes;
        Name = "WashDishes";
    }
}