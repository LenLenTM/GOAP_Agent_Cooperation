using System;

public interface IBaseAction
{
        bool CheckPreconditions();
}

public class BaseAction : IBaseAction
{
        public ActionType ResultType = ActionType.None;
        public List<ActionType> PreconditionType = new(){ActionType.None};
        public GOAP_Entity Entity;
        public string Name = "BaseAction";
        public int Cost = 0;
        public string Owner;

        public BaseAction(GOAP_Entity goapEntity, int cost)
        {
                Entity = goapEntity;
                Cost = cost;
        }
        
        public virtual bool CheckPreconditions()
        {
                return true;
        }
}