public class Squirtle : IPokemon
{

    public Squirtle()
    {
        Name = "Squirtle";
        Health = 270;
        Attack = 60;
        MaxHealth = 270;
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