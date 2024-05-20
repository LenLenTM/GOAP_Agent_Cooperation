using GOAP_Cooperation.Entity;

namespace GOAP_Cooperation.GOAP.Goals;

public class Idle : BaseGoal
{
    public Idle(GoapEntity goapEntity) : base(goapEntity)
    {
        name = "Idle";
        GoalType = new(){ActionType.Idle};
    }

    public override void UpdatePriority()
    {
    }

    public override void Initialize()
    {
    }
    
    public override object GetGoalValue()
    {
        return null;
    }
}