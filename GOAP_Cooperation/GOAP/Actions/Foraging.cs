public class Foraging : BaseAction
{
    public Foraging(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.ForagingKnowledge};
        ResultType = ActionType.Ingredients;
        Name = "Foraging";
    }
}