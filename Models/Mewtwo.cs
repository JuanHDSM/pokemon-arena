public class Mewtwo : IPokemon
{

    public Mewtwo()
    {
        Name = "Mewtwo";
        Health = 550;
        Attack = 60;
        MaxHealth = 550;
        
    }

    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int MaxHealth { get; set; }


    public void Boost ()
    {
        Health += Health * 10 / 100;
        Attack += Attack * 10 / 100;

    }

    public override string ToString()
    {
        return $"Nome: {Name}, Vida máxima: {Health}, Atack: {Attack}";
    }
}