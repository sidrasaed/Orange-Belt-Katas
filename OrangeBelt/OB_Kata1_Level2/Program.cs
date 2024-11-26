namespace OB_Kata1_Level2;

class Program
{
    static void Main(string[] args)
    {
        var warriorRole = new WarriorRole("Bran", 45);
        var healerRole = new HealerRole("Arin", 90);

        var warrior = new Character("Bran", 45, warriorRole.PrimaryAction);
        var healer = new Character("Arin", 90, healerRole.PrimaryAction);

        Console.WriteLine($"{warrior.Name} and {healer.Name} are ready for action");
        GameLogic.PlayerTurn(warrior, healer);
    }
}