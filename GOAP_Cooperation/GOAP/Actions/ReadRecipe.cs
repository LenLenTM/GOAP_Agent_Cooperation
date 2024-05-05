namespace GOAP_Cooperation.GOAP.Actions;

public class ReadRecipe : BaseAction
{
    public ReadRecipe(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.Food};
        ResultType = ActionType.None;
        Name = "Eat";
    }

    public override bool CheckPreconditions()
    {
        return Entity.IsInInventory(typeof(CookBook));
    }
}