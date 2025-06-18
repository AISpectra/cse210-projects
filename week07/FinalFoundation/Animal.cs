public abstract class Animal
{
    private string _name;

    public Animal(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract string MakeSound();
}
