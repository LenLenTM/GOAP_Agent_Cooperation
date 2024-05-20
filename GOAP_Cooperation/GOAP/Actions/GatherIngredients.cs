using GOAP_Cooperation.Entity;

public class GatherIngredients : BaseAction
{
    public GatherIngredients(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.None};
        ResultType = ActionType.Ingredients;
        Name = "GatherIngredients";
    }

    public override bool CheckPreconditions()
    {
        return Entity.LivesOnFarm;
    }
}