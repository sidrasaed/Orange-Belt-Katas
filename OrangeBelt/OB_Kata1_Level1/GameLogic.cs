namespace OB_Kata1_Level1;

public class GameLogic
{
    private const int HealthThreshold = 50;

    public static void PerformAction(Character warrior, Character healer)
    {
        if (warrior.Health < HealthThreshold)
        {
            Console.WriteLine($"{warrior.Name}'s health is low, so it's attacking first");
            warrior.PrimaryAction.Invoke();
        }
        else
        {
            HealCharacter(warrior, healer);
        }
    }

    private static void HealCharacter(Character warrior, Character healer)
    {
        if (warrior.Health < healer.Health)
        {
            Console.WriteLine($"{healer.Name} is healing {warrior.Name} who has the lowest health...");
        }
        else
        {
            Console.WriteLine($"{healer.Name} is healing {healer.Name} who has the lowest health...");
        }
        healer.PrimaryAction.Invoke();
    }
}