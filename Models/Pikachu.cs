public class Pikachu : IPokemon
{

    public Pikachu()
    {
        Name = "Pikachu";
        Health = 260;
        Attack = 70;
        MaxHealth = 260;
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