namespace OB_Kata1_Level2;

public class HealerRole
{
    public Action HealAction { get; private set; }
    public Action PrimaryAction { get; private set; }

    public HealerRole(string name, int health)
    {
        HealAction = () => Console.WriteLine($"{name} healed");
        PrimaryAction = () =>
        {
            Console.WriteLine($"{name} is healing the character with the lowest health...");
            HealAction.Invoke();
        };
    }
}