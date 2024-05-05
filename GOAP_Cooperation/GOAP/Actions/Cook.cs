﻿namespace GOAP_Cooperation.GOAP.Actions;

public class Cook : BaseAction
{
    public Cook(GOAP_Entity goapEntity, int cost) : base(goapEntity, cost)
    {
        PreconditionType = Entity.IsInInventory(typeof(DishWasher)) ? 
            new List<ActionType>() { ActionType.Recipe } : new List<ActionType>() { ActionType.CleanDishes, ActionType.Recipe };
        ResultType = ActionType.Food;
        Name = "Cook";
    }
}