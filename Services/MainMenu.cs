public class MainMenu
{
    public static void Show() {
        Console.Clear();

        Console.WriteLine("1 - Iniciar batalha");
        Console.WriteLine("2 - Pokedex");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");
        int option = int.Parse(Console.ReadLine());

        switch (option) 
        {
            case 1: Battle.Start(); break;
            case 2: Pokedex.Show(); Console.Read(); break;
            case 3: Environment.Exit(0); break;
            default: Console.WriteLine("Opção inválida tente novamente"); Thread.Sleep(1500); Show(); break;
        }
    }
}