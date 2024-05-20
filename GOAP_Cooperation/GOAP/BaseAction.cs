using System;
using GOAP_Cooperation.Entity;

public interface IBaseAction
{
        bool CheckPreconditions();
}

public class BaseAction : IBaseAction
{
        public ActionType ResultType = ActionType.None;
        public List<ActionType> PreconditionType = new(){ActionType.None};
        public GoapEntity Entity;
        public string Name = "BaseAction";
        public int Cost = 0;
        public string Owner;

        public BaseAction(GoapEntity goapEntity, int cost)
        {
                Entity = goapEntity;
                Cost = cost;
        }
        
        public virtual bool CheckPreconditions()
        {
                return true;
        }
}