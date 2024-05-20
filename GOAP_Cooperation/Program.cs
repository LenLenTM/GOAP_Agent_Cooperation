using GOAP_Cooperation;
using GOAP_Cooperation.Entity;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nScenario 1");
        ScenarioEditor.Scenario1();
        World world = new World(new List<GoapEntity>() { ScenarioEditor.mainChar, ScenarioEditor.cook, ScenarioEditor.friend, ScenarioEditor.bankAgent });
        ScenarioEditor.mainChar.Update();
        
        Console.WriteLine("\nScenario 2");
        ScenarioEditor.Scenario2();
        world = new World(new List<GoapEntity>() { ScenarioEditor.mainChar, ScenarioEditor.cook, ScenarioEditor.friend, ScenarioEditor.bankAgent });
        ScenarioEditor.mainChar.Update();
        
        Console.WriteLine("\nScenario 3");
        ScenarioEditor.Scenario3();
        world = new World(new List<GoapEntity>() { ScenarioEditor.mainChar, ScenarioEditor.cook, ScenarioEditor.friend, ScenarioEditor.bankAgent });
        ScenarioEditor.mainChar.Update();
        
        Console.WriteLine("\nScenario 4");
        ScenarioEditor.Scenario4();
        world = new World(new List<GoapEntity>() { ScenarioEditor.mainChar, ScenarioEditor.cook, ScenarioEditor.friend, ScenarioEditor.bankAgent });
        ScenarioEditor.mainChar.Update();
    }
}