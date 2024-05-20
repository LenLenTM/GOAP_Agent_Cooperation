using GOAP_Cooperation.Entity;

public class BuyIngredients : BaseAction
{
    public BuyIngredients(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.Money};
        ResultType = ActionType.Ingredients;
        Name = "BuyIngredients";
    }
}