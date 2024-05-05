public class World
{
    public static int Speed = 2;
    public static DateTime Time;
    public static List<GOAP_Entity> Entities;

    public World(List<GOAP_Entity> entities)
    {
        DateTime today = DateTime.Now;
        Time = new DateTime(today.Year, today.Month, today.Day, 8, 0, 0);
        Entities = entities;
    }

    private void Update()
    {
        Time = Time.AddSeconds(1 * Speed);

        /*if (Time.ToString("HH:mm").Equals("00:00"))
        {
            GOAP_Entity.Work.Work2Do = 50;
        }*/

    }
}