public class LendMoney : BaseAction
{
    public LendMoney(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.None};
        ResultType = ActionType.Money;
        Name = "Lend Money";
    }
}