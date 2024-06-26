﻿/*using System;
using System.Linq;
using System.Numerics;

public class Sleeping_GOAP : BaseAction
{
    public Vector3 PreconditionValue;
    private double targetTiredness;

    public Sleeping_GOAP(GOAP_Entity goapEntity) : base(goapEntity)
    {
        PreconditionType = typeof(Vector3);
        ResultType = typeof(Sleep);
        name = "Sleeping";
    }
        
    public override void Initialize(object initializer)
    {
        targetTiredness = (double)initializer;
    }
    
    public override void InitializePreConValue()
    {
        PreconditionValue = new Vector3(1, 1, 1);
    }

    public override bool Action()
    {
        entity.Sleep.Tiredness -= 0.00454 * World.Speed;
                
        return entity.Hunger.Hungry <= targetTiredness;
    }
    
    public override object GetPreconditionValue()
    {
        return PreconditionValue;
    }
}*/