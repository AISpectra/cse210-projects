public class Bird : Animal
{
    public Bird(string name) : base(name) {}

    public override string MakeSound()
    {
        return "Tweet!";
    }
}
