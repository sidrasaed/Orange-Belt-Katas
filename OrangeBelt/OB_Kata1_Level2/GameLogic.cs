namespace OB_Kata1_Level2;

public class GameLogic
{
    public static void PlayerTurn(Character warrior, Character healer)
    {
        if (warrior.Health < 50)
        {
            Console.WriteLine($"{warrior.Name}'s health is low, so it's attacking first");
            warrior.PrimaryAction.Invoke();
        }
        else
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
}