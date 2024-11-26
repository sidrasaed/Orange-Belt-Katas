namespace OB_Kata2;

class Program
{
    static void Main(string[] args)
    {
        // Create two characters
        Character character1 = new Character("Arin", 100);
        Character character2 = new Character("Dalia", 100);

        // Subscribe to the HealthChanged event
        character1.HealthChanged += DisplayHealthChange;
        character2.HealthChanged += DisplayHealthChange;

        // Define the attack action using the delegate
        CharacterAction attackAction = Attack;

        // Perform an attack
        Console.WriteLine($"{character1.Name} is attacking {character2.Name}!");
        attackAction(character2);
    }

    // Event handler for HealthChanged
    static void DisplayHealthChange(Character character)
    {
        Console.WriteLine($"{character.Name}'s health changed. New health: {character.Health}");
    }

    // Attack method using the CharacterAction delegate
    static void Attack(Character character)
    {
        int damage = 10;
        character.TakeDamage(damage);
    }
}