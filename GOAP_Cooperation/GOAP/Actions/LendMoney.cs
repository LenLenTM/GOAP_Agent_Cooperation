using GOAP_Cooperation.Entity;

public class LendMoney : BaseAction
{
    public LendMoney(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.None};
        ResultType = ActionType.Money;
        Name = "Lend Money";
    }
}