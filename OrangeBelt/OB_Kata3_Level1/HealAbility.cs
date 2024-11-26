namespace OB_Kata3_Level1;

public class HealAbility : IAbility
{
    public string Name {get; private set;}
    public string Effect {get; private set;}

    public HealAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}