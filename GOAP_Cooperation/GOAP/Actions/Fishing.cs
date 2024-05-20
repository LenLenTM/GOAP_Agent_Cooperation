using GOAP_Cooperation.Entity;

public class Fishing : BaseAction
{
    public Fishing(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.FishingRod};
        ResultType = ActionType.Ingredients;
        Name = "Fishing";
    }
}