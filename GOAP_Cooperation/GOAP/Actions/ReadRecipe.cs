using GOAP_Cooperation.Entity;

namespace GOAP_Cooperation.GOAP.Actions;

public class ReadRecipe : BaseAction
{
    public ReadRecipe(GoapEntity goapEntity, int cost) : base(goapEntity, cost)
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