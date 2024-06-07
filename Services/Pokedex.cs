public class Pokedex
{
    static IPokemon Charmander = new Charmander();
    static IPokemon Bulbassauro = new Bulbassauro();
    static IPokemon Squirtle = new Squirtle();
    static IPokemon Pikachu = new Pikachu();
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine(Charmander);
        Console.WriteLine(Bulbassauro);
        Console.WriteLine(Squirtle);
        Console.WriteLine(Pikachu);
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar para o menu principal...");
        Console.ReadLine();
        MainMenu.Show();
    }
}