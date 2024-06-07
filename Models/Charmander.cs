public class Charmander : IPokemon
{


    public Charmander()
    {
        Name = "Charmander";
        Health = 245;
        Attack = 75;
        MaxHealth = 245;
    }

    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int MaxHealth { get; set; }

    

    public override string ToString()
    {
        return $"Nome: {Name}, Vida máxima: {Health}, Atack: {Attack}";
    }
}