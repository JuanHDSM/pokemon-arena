public interface IPokemon
{
    public string Name { get; set;}
    public int Health { get; set;}
    public int Attack { get; set; }

    public int MaxHealth { get; set; }

    void Boost ()
    {
        Health += MaxHealth * 7 / 100;
        Attack += Attack * 5 / 100;

    }

    void Heal() => Health += MaxHealth * 5 / 100;

}