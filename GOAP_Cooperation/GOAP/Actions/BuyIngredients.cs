public class BuyIngredients : BaseAction
{
    public BuyIngredients(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.Money};
        ResultType = ActionType.Ingredients;
        Name = "BuyIngredients";
    }
}