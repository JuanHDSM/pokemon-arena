public class SelectedPokemon
{
    public static IPokemon? Pokemon()
    {

        Console.Clear();
        Console.WriteLine("Escolha seu pokemon");
        Console.WriteLine("1 - Charmander");
        Console.WriteLine("2 - Bulbassauro");
        Console.WriteLine("3 - Squirtle");
        Console.WriteLine("0 - Voltar para o menu principal");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                {
                    IPokemon charmander = new Charmander();
                    return charmander;
                }

            case 2:
                {
                    IPokemon bulbassauro = new Bulbassauro();
                    return bulbassauro;
                }
            case 3:
                {
                    IPokemon squirtle = new Squirtle();
                    return squirtle;
                }

            case 0:  MainMenu.Show();return null;

            case -1:
                {
                    IPokemon pikachu = new Pikachu();
                    return pikachu;
                }
            default: Console.WriteLine("Tá viajando rapá, te mostrei as opções disponíveis!"); Console.WriteLine("Ah você está tentando desbloquear o pikachu! HEHEHE, Acho que vai demorar um pouco."); return null;
        }
    }
}