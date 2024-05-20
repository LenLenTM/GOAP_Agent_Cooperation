using GOAP_Cooperation.Entity;

public class AskForRecipe : BaseAction
{
    public AskForRecipe(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.Ingredients};
        ResultType = ActionType.Recipe;
        Name = "AskForRecipe";
    }
    
    public override bool CheckPreconditions()
    {
        return Entity.IsInInventory(typeof(CookBook));
    }
}