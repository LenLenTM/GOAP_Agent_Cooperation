public class AskAboutForaging : BaseAction
{
    public AskAboutForaging(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.None};
        ResultType = ActionType.ForagingKnowledge;
        Name = "Ask a person how to forage";
    }
}