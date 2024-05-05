public class LendFishingRod : BaseAction
{
    public LendFishingRod(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.None};
        ResultType = ActionType.FishingRod;
        Name = "Lend a fishing rod";
    }

    public override bool CheckPreconditions()
    {
        return Entity.IsInInventory(typeof(FishingRod));
    }
}