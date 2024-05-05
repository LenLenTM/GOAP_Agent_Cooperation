using System.Numerics;

public class GOAP_Entity
{
    public string Name;
    private List<BaseItem> _inventory;
    public bool LivesOnFarm;

    private List<BaseAction> _actions;
    private List<BaseGoal> _goals;
    private Planner _planner;
    public Vector2 Position;
    public bool IsCooperative;

    public GOAP_Entity(string name, List<BaseItem> inventory, bool livesOnFarm, Vector2 position, bool isCooperative)
    {
        Name = name;
        _inventory = inventory;
        LivesOnFarm = livesOnFarm;
        _planner = new Planner(this);
        Position = position;
        IsCooperative = isCooperative;
    }
    
    public void InitGoap(List<BaseAction> actions, List<BaseGoal> goals)
    {
        _actions = actions;
        _goals = goals;
    }

    public void Update()
    {
        _planner.PlanningAndExecution(_actions, _goals);
    }
    
    /*public void UpdateHunger(double value)
    {
        Hunger.Hungry += value;
    }*/

    public bool IsInInventory(Type type)
    {
        return _inventory.Any(item => item.GetType() == type);
    }

    public List<BaseAction> GetActions()
    {
        return _actions;
    }
}