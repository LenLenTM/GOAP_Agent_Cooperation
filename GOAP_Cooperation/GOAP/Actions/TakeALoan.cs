public class TakeALoan : BaseAction
{
    public TakeALoan(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.None};
        ResultType = ActionType.Money;
        Name = "Take A Loan";
    }
}