namespace OB_Kata1_Level2;

public class WarriorRole
{
    public Action AttackAction { get; private set; }
    public Action PrimaryAction { get; private set; }

    public WarriorRole(string name, int health)
    {
        AttackAction = () => Console.WriteLine($"{name} attacked");
        PrimaryAction = () =>
        {
            if (health < 50)
            {
                Console.WriteLine($"{name} is attacking first due to low health!");
                AttackAction.Invoke();
            }
            else
            {
                Console.WriteLine($"{name} is standing by with health: {health}");
            }
        };
    }
}