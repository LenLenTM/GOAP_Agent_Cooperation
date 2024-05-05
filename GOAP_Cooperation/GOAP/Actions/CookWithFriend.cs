public class CookWithFriend : BaseAction
{
    public CookWithFriend(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = new List<ActionType>(){ActionType.Ingredients};
        ResultType = ActionType.Recipe;
        Name = "CookWithFriend";
    }
    
    public override bool CheckPreconditions()
    {
        return Entity.IsInInventory(typeof(CookBook));
    }
}