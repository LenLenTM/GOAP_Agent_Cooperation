using GOAP_Cooperation.Entity;

public class World
{
    public static int Speed = 2;
    public static DateTime Time;
    public static List<GoapEntity> Entities;

    public World(List<GoapEntity> entities)
    {
        DateTime today = DateTime.Now;
        Time = new DateTime(today.Year, today.Month, today.Day, 8, 0, 0);
        Entities = entities;
    }

    private void Update()
    {
        Time = Time.AddSeconds(1 * Speed);
    }
}