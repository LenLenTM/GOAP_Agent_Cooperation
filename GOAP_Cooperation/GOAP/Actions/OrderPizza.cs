using GOAP_Cooperation.Entity;

public class OrderPizza : BaseAction
{
    public OrderPizza(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.Money};
        ResultType = ActionType.Food;
        Name = "OrderPizza";
    }
}