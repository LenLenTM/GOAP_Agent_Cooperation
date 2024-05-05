/*using System;
using System.Linq;
using System.Numerics;

public class Working_GOAP : BaseAction
{
    public Vector3 PreconditionValue;
    private double targetWork;

    public Working_GOAP(GOAP_Entity goapEntity) : base(goapEntity)
    {
        PreconditionType = typeof(Vector3);
        ResultType = typeof(Work);
        name = "Working";
    }
        
    public override void Initialize(object initializer)
    {
        targetWork = (double)initializer;
    }
    
    public override void InitializePreConValue()
    {
        PreconditionValue = new Vector3(1, 1, 1);
    }

    public override bool Action()
    {
        GOAP_Entity.Work.Work2Do -= 0.003 * World.Speed;
                
        return GOAP_Entity.Work.Work2Do <= 1;
    }

    public override object GetPreconditionValue()
    {
        return PreconditionValue;
    }
}*/