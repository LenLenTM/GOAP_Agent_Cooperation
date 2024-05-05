/*using System;
using System.Linq;
using System.Numerics;
using Random = System.Random;

public class LeisureActivity_GOAP : BaseAction
{
    public Vector3 PreconditionValue;
    private int leisureTime;

    public LeisureActivity_GOAP(GOAP_Entity goapEntity) : base(goapEntity)
    {
        PreconditionType = typeof(Vector3);
        ResultType = typeof(Leisure);
        name = "Leisure";
    }
        
    public override void Initialize(object initializer)
    {
        leisureTime = (int)initializer;
    }
    
    public override void InitializePreConValue()
    {
        var random = new Random();

        switch (random.Next(0, 3))
        {
            case 0:
                PreconditionValue = new Vector3(1, 1, 1);
                name = "Watching movie";
                break;
            case 1:
                PreconditionValue = new Vector3(1, 1, 1);
                name = "Meeting friends";
                break;
            case 2:
                PreconditionValue = new Vector3(1, 1, 1);
                name = "Gaming";
                break;
        }
    }

    public override bool Action()
    {
        leisureTime -= 1 * World.Speed;
                
        return leisureTime <= 0;
    }
    
    public override object GetPreconditionValue()
    {
        return PreconditionValue;
    }
}*/