namespace OB_Kata1_Level1;

class Program
{
    static void Main(string[] args)
    {
        Action warriorAction = () => Console.WriteLine("The Warrior attacks");
        Action healerAction = () => Console.WriteLine("The Healer heals");
        Character warrior = new Character("Warrior", 55, warriorAction);
        Character healer = new Character("Healer", 45, healerAction);
        Console.WriteLine($"{warrior.Name} and {healer.Name} are ready for action");
        GameLogic.PerformAction(warrior, healer);
    }
}