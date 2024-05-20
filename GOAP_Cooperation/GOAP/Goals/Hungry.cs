using System;
using GOAP_Cooperation.Entity;

public class Hungry : BaseGoal
{
    private double goal = 0;

    public Hungry(GoapEntity goapEntity) : base(goapEntity)
    {
        name = "Hungry";
        GoalType = new(){ActionType.Eat};
    }

    public override void UpdatePriority()
    {
        priority = 90;
        /*if (entity.Hunger.Hungry > 62 && priority != 90)
        {
            Logger.WriteLog("[Goal] Hunger priority changed to [90].");
            priority = 90;
        }
        else if (entity.Hunger.Hungry <= goal)
        {
            priority = 0;
        }*/
    }

    public override void Initialize()
    {
        //goal = entity.Hunger.Hungry - 40;
    }
    
    public override object GetGoalValue()
    {
        return goal;
    }
}