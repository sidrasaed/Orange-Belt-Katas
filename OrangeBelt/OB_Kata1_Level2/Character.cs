namespace OB_Kata1_Level2;

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public Action PrimaryAction { get; private set; }

    public Character(string name, int health, Action primaryAction)
    {
        Name = name;
        Health = health;
        PrimaryAction = primaryAction;
    }
}