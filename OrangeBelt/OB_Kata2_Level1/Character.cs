namespace OB_Kata2;

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }

    // Declare an event by declaring "HealthChanged" delegate.
    public event Action<Character> HealthChanged;

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }

        Console.WriteLine($"{Name} took {damage} damage. Remaining health: {Health}");

        // Trigger the HealthChanged event
        OnHealthChanged();
    }

    // Trigger the HealthChanged event
    private void OnHealthChanged()
    {
        HealthChanged?.Invoke(this);
    }
}
