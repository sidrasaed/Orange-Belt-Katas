namespace OB_Kata3_Level1;

public class AbilityContainer<T> where T:IAbility
{
    private List<T> abilities = new List<T>();

    public void AddAbbility(T ability)
    {
        abilities.Add(ability);
    }

    public void RemoveAbbility(T ability)
    {
        abilities.Remove(ability);
    }

    public void DisplayAbility()
    {
        foreach (var ability in abilities)
        {
            Console.WriteLine($"Name: {ability.Name}, Effect: {ability.Effect}");
        }
    }
}