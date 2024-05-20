using GOAP_Cooperation.Entity;

public class Foraging : BaseAction
{
    public Foraging(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.ForagingKnowledge};
        ResultType = ActionType.Ingredients;
        Name = "Foraging";
    }
}