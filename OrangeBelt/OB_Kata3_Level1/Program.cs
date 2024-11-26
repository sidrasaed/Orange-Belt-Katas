namespace OB_Kata3_Level1;

class Program
{
    static void Main(string[] args)
    {
        AbilityContainer<IAbility> abilityContainer = new AbilityContainer<IAbility>();
        
        var attack = new AttackAbility("Slash Attack ", "Deals 10 damage.");
        var heal = new HealAbility("Healing Light ", "Restores 10 health");
        
        abilityContainer.AddAbbility(attack);
        abilityContainer.AddAbbility(heal);

        Console.WriteLine("Abilities in the container:");
        abilityContainer.DisplayAbility();
    }
    
}