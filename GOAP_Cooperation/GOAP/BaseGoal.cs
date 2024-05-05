using System;

public interface IGoal
{
    void UpdatePriority();
    void Initialize();
    object GetGoalValue();
}
public class BaseGoal : IGoal
{
    public string name = "BaseGoal";
    public int priority = -1;
    public GOAP_Entity entity;
    public List<ActionType> GoalType = new(){ActionType.Idle};

    public BaseGoal(GOAP_Entity goapEntity)
    {
        entity = goapEntity;
    }

    public virtual void UpdatePriority()
    {
        priority = priority;
    }

    public virtual void Initialize()
    {
        
    }

    public virtual object GetGoalValue()
    {
        return new object();
    }

    
}