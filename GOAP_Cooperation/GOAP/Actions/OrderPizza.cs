public class OrderPizza : BaseAction
{
    public OrderPizza(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.Money};
        ResultType = ActionType.Food;
        Name = "OrderPizza";
    }
}