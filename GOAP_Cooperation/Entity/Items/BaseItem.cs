namespace GOAP_Cooperation.Entity.Items;

public abstract class BaseItem
{
    private string _name;

    public BaseItem(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}