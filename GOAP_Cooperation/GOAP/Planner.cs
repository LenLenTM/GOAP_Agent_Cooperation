using System.Numerics;
using GOAP_Cooperation.Entity;

public class Planner
{
        private List<BaseAction> _plan; // stores the plan for execution and checking the last link in the plan if it still fulfills the current goal

        private BaseGoal _currentGoal;
        private List<BaseAction> availableActions;
        private GoapEntity _planOwner;

        public Planner(GoapEntity entity)
        {
                _planOwner = entity;
        }
        
        public void PlanningAndExecution(List<BaseAction> actions, List<BaseGoal> goals)
        {
                UpdateGoalPriority(goals);
                UpdateGoal(goals);

                if (!(_plan.Count >= 1) || !CheckPlanValid())
                {
                        availableActions = actions;
                        Plan();
                }
                
                PrintPlan();
        }

        private bool CheckPlanValid()
        {
                if (_currentGoal.GoalType.Count > 1)
                {
                        var matching = 0;
                        var typeCount = _currentGoal.GoalType.Count;

                        foreach (var type in _currentGoal.GoalType)
                        {
                                for (int x = 0; x < typeCount; x++)
                                {
                                        if (_plan[x].ResultType == type)
                                        {
                                                matching++;
                                                break;
                                        }
                                }
                        }

                        return matching == typeCount;
                }
                return _currentGoal.GoalType[0] == _plan[0].ResultType;
        }

        private void UpdateGoal(List<BaseGoal> goals)
        {
                var highestPriority = goals.OrderByDescending(g => g.priority).First();

                if (_currentGoal == null || !_currentGoal.name.Equals(highestPriority.name))
                {
                        _currentGoal = highestPriority;
                        _currentGoal.Initialize();
                        _plan = new List<BaseAction>();
                }
        }

        private void UpdateGoalPriority(List<BaseGoal> goals)
        {
                foreach (var goal in goals)
                {
                        goal.UpdatePriority();
                }
        }

        private void Plan()
        {
                var allActions = availableActions;
                
                foreach (var entity in World.Entities)
                {
                        // here we check which entities are nearby and/or are cooperative
                        if (entity.Name.Equals(_planOwner.Name) || !entity.IsCooperative) continue;
                        if (Vector2.Distance(_planOwner.Position, entity.Position) > 10) continue;
                        
                        foreach (var action in entity.GetActions())
                        {
                                var currentAction = action;
                                currentAction.Owner = entity.Name;
                                allActions.Add(currentAction);
                        }
                }
                
                List<BaseAction> plan = new ();

                AddNodes(plan, _currentGoal.GoalType, allActions);
        }

        private void AddNodes(List<BaseAction> plan, List<ActionType> requiredTypes, List<BaseAction> allActions)
        {
                if (PlanIsComplete(plan))
                {
                        _plan = plan;
                        return;
                }
                
                if (requiredTypes.Count == 0) return;
                List<ActionType> nextTypes = requiredTypes.ToList();
                List<BaseAction> nextPlan = plan.ToList();

                var possibleActions = allActions.FindAll(action => action.ResultType == nextTypes[0]);
                nextTypes.RemoveAt(0);

                foreach (var action in possibleActions)
                {
                        var cost = CalculateCost(_plan);
                        if (CalculateCost(nextPlan) + action.Cost > cost && cost != 0) continue;

                        if (!action.CheckPreconditions()) continue;
                        
                        nextPlan.Add(action);

                        var addTypes = action.PreconditionType.Where(action => action != ActionType.None).ToList();
                        var countAddTypes = addTypes.Count;
                        nextTypes.AddRange(addTypes);
                        AddNodes(nextPlan, nextTypes, allActions);

                        nextPlan = plan.ToList();
                        nextTypes.RemoveRange(nextTypes.Count - countAddTypes, countAddTypes);
                }
        }

        private int CalculateCost(List<BaseAction> plan)
        {
                var cost = 0;

                foreach (var action in plan)
                {
                        cost += action.Cost;
                }

                return cost;
        }

        private bool PlanIsComplete(List<BaseAction> plan)
        {
                if (plan.Count == 0) return false;
                List<ActionType> preconditions = new();
                List<ActionType> results = new();

                foreach (var action in plan)
                {
                        preconditions.AddRange(action.PreconditionType);
                        results.Add(action.ResultType);
                }

                preconditions = preconditions.Where(action => action != ActionType.None).ToList();

                return preconditions.All(actionType => preconditions.Count(action => action == actionType) == results.Count(action => action == actionType));
        }

        private void PrintPlan()
        {
                var plan = _plan.ToList();
                int totalCost = 0;
                plan.Reverse();
                string planPrint = "Hungry: -> ";
                foreach (var action in plan)
                {
                        totalCost += action.Cost;
                        if (action.Owner != "main")
                        {
                                planPrint += action.Name + "(" + action.Owner + ")(cost: " + action.Cost + ") -> ";
                        }
                        else
                        {
                                planPrint += action.Name + " -> ";
                        }
                }

                planPrint += "Total cost: " + totalCost;
                Console.WriteLine(planPrint);
        }
}