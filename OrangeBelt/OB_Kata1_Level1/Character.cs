namespace OB_Kata1_Level1;

public class Character
{
    public string Name { get; }
    public int Health { get; }
    public Action PrimaryAction { get; }

    public Character(string name, int health, Action primaryAction)
    {
        Name = name;
        Health = health;
        PrimaryAction = primaryAction;
    }
}