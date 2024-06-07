public class Bulbassauro : IPokemon
{

    public Bulbassauro()
    {
        Name = "Bulbassauro";
        Health = 295;
        Attack = 55;
        MaxHealth = 295;
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