using System.Numerics;
using GOAP_Cooperation.GOAP.Actions;
using GOAP_Cooperation.GOAP.Goals;

namespace GOAP_Cooperation;

public static class ScenarioEditor
{
    public static GOAP_Entity mainChar;
    public static GOAP_Entity cook;
    public static GOAP_Entity friend;
    public static GOAP_Entity bankAgent;
    
    private static List<BaseAction> mainCharActions;
    private static List<BaseAction> cookActions;
    private static List<BaseAction> friendActions;
    private static List<BaseAction> bankAgentActions;

    public static void Scenario1()
    {
        mainChar = new GOAP_Entity("main", new List<BaseItem>(){new CookBook("Fooding")}, false, new Vector2(0, 0), true);
        cook = new GOAP_Entity("cook", new List<BaseItem>() { new CookBook("Cooking Like A Chef") }, false, new Vector2(2, 2), true);
        friend = new GOAP_Entity("friend", new List<BaseItem>() { new FishingRod("Fishing Rod") }, false, new Vector2(-2, 5), true);
        bankAgent = new GOAP_Entity("bank agent", new List<BaseItem>() { }, false, new Vector2(7, 1), true);
        
        mainCharActions = new()
        {
            new GetLeftOvers(mainChar, 5),
            new GatherIngredients(mainChar, 10),
            new Fishing(mainChar, 12),
            new Foraging(mainChar, 122),
            new BuyIngredients(mainChar, 80),
            new OrderPizza(mainChar, 90),
            new ReadRecipe(mainChar, 4),
            new WashDishes(mainChar, 8),
            new Cook(mainChar, 12),
            new Eat(mainChar, 3)
        };
        
        cookActions = new()
        {
            new AskAboutForaging(cook, 20),
            new AskForRecipe(cook, 4)
        };
        
        friendActions = new()
        {
            new LendFishingRod(friend, 2),
            new LendMoney(friend, 20),
            new CookWithFriend(friend, 14)
        };
        
        bankAgentActions = new()
        {
            new LendMoney(bankAgent, 20)
        };
        
        mainChar.InitGoap(mainCharActions, new List<BaseGoal>(){ new Hungry(mainChar) });
        cook.InitGoap(cookActions, new List<BaseGoal>(){ new Idle(cook) });
        friend.InitGoap(friendActions, new List<BaseGoal>(){ new Idle(friend) });
        bankAgent.InitGoap(bankAgentActions, new List<BaseGoal>(){ new Idle(bankAgent) });
    }
    
    public static void Scenario2()
    {
        mainChar = new GOAP_Entity("main", new List<BaseItem>(){new CookBook("Fooding"), new DishWasher("Dishwasher") }, false, new Vector2(0, 0), true);
        cook = new GOAP_Entity("cook", new List<BaseItem>() { new CookBook("Cooking Like A Chef") }, false, new Vector2(2, 2), true);
        friend = new GOAP_Entity("friend", new List<BaseItem>() { }, false, new Vector2(-2, 5), true);
        bankAgent = new GOAP_Entity("bank agent", new List<BaseItem>() { }, false, new Vector2(7, 1), true);
        
        mainCharActions = new()
        {
            new GetLeftOvers(mainChar, 5),
            new GatherIngredients(mainChar, 10),
            new Fishing(mainChar, 12),
            new Foraging(mainChar, 12),
            new BuyIngredients(mainChar, 8),
            new OrderPizza(mainChar, 30),
            new ReadRecipe(mainChar, 4),
            new WashDishes(mainChar, 8),
            new Cook(mainChar, 12),
            new Eat(mainChar, 3)
        };
        
        cookActions = new()
        {
            new AskAboutForaging(cook, 20),
            new AskForRecipe(cook, 4)
        };
        
        friendActions = new()
        {
            new LendFishingRod(friend, 2),
            new LendMoney(friend, 20),
            new CookWithFriend(friend, 14)
        };
        
        bankAgentActions = new()
        {
            new LendMoney(bankAgent, 20)
        };
        
        mainChar.InitGoap(mainCharActions, new List<BaseGoal>(){ new Hungry(mainChar) });
        cook.InitGoap(cookActions, new List<BaseGoal>(){ new Idle(cook) });
        friend.InitGoap(friendActions, new List<BaseGoal>(){ new Idle(friend) });
        bankAgent.InitGoap(bankAgentActions, new List<BaseGoal>(){ new Idle(bankAgent) });
    }
    
    public static void Scenario3()
    {
        mainChar = new GOAP_Entity("main", new List<BaseItem>(){new CookBook("Fooding"), new DishWasher("Dishwasher") }, false, new Vector2(0, 0), true);
        cook = new GOAP_Entity("cook", new List<BaseItem>() { new CookBook("Cooking Like A Chef") }, false, new Vector2(2, 2), true);
        friend = new GOAP_Entity("friend", new List<BaseItem>() { }, false, new Vector2(-2, 5), true);
        bankAgent = new GOAP_Entity("bank agent", new List<BaseItem>() { }, false, new Vector2(7, 1), true);
        
        mainCharActions = new()
        {
            new GetLeftOvers(mainChar, 5),
            new GatherIngredients(mainChar, 10),
            new Fishing(mainChar, 12),
            new Foraging(mainChar, 12),
            new BuyIngredients(mainChar, 8),
            new OrderPizza(mainChar, 20),
            new ReadRecipe(mainChar, 4),
            new WashDishes(mainChar, 8),
            new Cook(mainChar, 12),
            new Eat(mainChar, 3)
        };
        
        cookActions = new()
        {
            new AskAboutForaging(cook, 20),
            new AskForRecipe(cook, 4)
        };
        
        friendActions = new()
        {
            new LendFishingRod(friend, 2),
            new LendMoney(friend, 20),
            new CookWithFriend(friend, 14)
        };
        
        bankAgentActions = new()
        {
            new LendMoney(bankAgent, 20)
        };
        
        mainChar.InitGoap(mainCharActions, new List<BaseGoal>(){ new Hungry(mainChar) });
        cook.InitGoap(cookActions, new List<BaseGoal>(){ new Idle(cook) });
        friend.InitGoap(friendActions, new List<BaseGoal>(){ new Idle(friend) });
        bankAgent.InitGoap(bankAgentActions, new List<BaseGoal>(){ new Idle(bankAgent) });
    }
    
    public static void Scenario4()
    {
        mainChar = new GOAP_Entity("main", new List<BaseItem>(){new CookBook("Fooding"), new DishWasher("Dishwasher"), new LeftOvers("Pizza") }, false, new Vector2(0, 0), true);
        cook = new GOAP_Entity("cook", new List<BaseItem>() { new CookBook("Cooking Like A Chef") }, false, new Vector2(2, 2), true);
        friend = new GOAP_Entity("friend", new List<BaseItem>() { }, false, new Vector2(-2, 5), true);
        bankAgent = new GOAP_Entity("bank agent", new List<BaseItem>() { }, false, new Vector2(7, 1), true);
        
        mainCharActions = new()
        {
            new GetLeftOvers(mainChar, 5),
            new GatherIngredients(mainChar, 10),
            new Fishing(mainChar, 12),
            new Foraging(mainChar, 12),
            new BuyIngredients(mainChar, 8),
            new OrderPizza(mainChar, 20),
            new ReadRecipe(mainChar, 4),
            new WashDishes(mainChar, 8),
            new Cook(mainChar, 12),
            new Eat(mainChar, 3)
        };
        
        cookActions = new()
        {
            new AskAboutForaging(cook, 20),
            new AskForRecipe(cook, 4)
        };
        
        friendActions = new()
        {
            new LendFishingRod(friend, 2),
            new LendMoney(friend, 20),
            new CookWithFriend(friend, 14)
        };
        
        bankAgentActions = new()
        {
            new LendMoney(bankAgent, 20)
        };
        
        mainChar.InitGoap(mainCharActions, new List<BaseGoal>(){ new Hungry(mainChar) });
        cook.InitGoap(cookActions, new List<BaseGoal>(){ new Idle(cook) });
        friend.InitGoap(friendActions, new List<BaseGoal>(){ new Idle(friend) });
        bankAgent.InitGoap(bankAgentActions, new List<BaseGoal>(){ new Idle(bankAgent) });
    }
}