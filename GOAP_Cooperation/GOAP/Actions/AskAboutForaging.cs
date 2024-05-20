using GOAP_Cooperation.Entity;

public class AskAboutForaging : BaseAction
{
    public AskAboutForaging(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.None};
        ResultType = ActionType.ForagingKnowledge;
        Name = "Ask a person how to forage";
    }
}