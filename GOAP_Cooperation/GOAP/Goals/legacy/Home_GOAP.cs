/*using System;
using System.Numerics;

public class Home_GOAP : BaseGoal
{
    private Vector3 goal = new Vector3();

    public Home_GOAP(GOAP_Entity goapEntity) : base(goapEntity)
    {
        name = "HeadingHome";
        priority = 10;
        GoalType = typeof(Vector3);
    }

    public override object GetGoalValue()
    {
        return goal;
    }

    public override void Initialize()
    {
        goal = new Vector3(1, 1, 1);
    }
}*/