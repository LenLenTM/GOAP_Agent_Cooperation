public class Fishing : BaseAction
{
    public Fishing(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.FishingRod};
        ResultType = ActionType.Ingredients;
        Name = "Fishing";
    }
}