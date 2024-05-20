using GOAP_Cooperation.Entity;

public class GetLeftOvers : BaseAction
{
    public GetLeftOvers(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.None};
        ResultType = ActionType.Food;
        Name = "Get Leftovers";
    }

    public override bool CheckPreconditions()
    {
        return Entity.IsInInventory(typeof(LeftOvers));
    }
}