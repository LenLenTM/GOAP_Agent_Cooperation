using GOAP_Cooperation.Entity;

public class TakeALoan : BaseAction
{
    public TakeALoan(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.None};
        ResultType = ActionType.Money;
        Name = "Take A Loan";
    }
}