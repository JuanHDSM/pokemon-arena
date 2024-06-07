public class Battle
{
    public int Round { get; set; }

    public static void Start()
    {
        Console.Clear();

        var random = new Random();
        var you = SelectedPokemon.Pokemon();

        Console.WriteLine($"{you.Name} eu escolho você!");
        Console.WriteLine(you);
        IPokemon boss = new Mewtwo();

        while (you.Health > 0 && boss.Health > 0)
        {
            Console.Clear();

            Console.WriteLine(you);
            Console.WriteLine(boss);
            Console.WriteLine();
            Console.WriteLine("1 - Atacar | 2 - Curar | 3 - Melhorar");
            Console.Write("Escolha uma opção: ");
            var action = int.Parse(Console.ReadLine());
            var bossAction = random.Next(1, 3);

            Console.WriteLine();
            switch (action)
            {
                case 1:
                    {
                        boss.Health -= you.Attack;
                        Console.WriteLine("Excelênte ataque!");
                        break;
                    }
                case 2:
                    {
                        you.Heal();
                        Console.WriteLine("Excelente cura!");
                        break;
                    }
                case 3:
                    {
                        you.Boost();
                        Console.WriteLine("Melhorou seus atributos!");
                        break;
                    }
                case 4: MainMenu.Show(); break;
                default: Console.WriteLine("Tá de sacanagem?! só por causa da gracinha perdeu a vez."); break;
            }

            Console.WriteLine();
            Console.WriteLine(you);
            Console.WriteLine(boss);
            Console.WriteLine();

            Thread.Sleep(2000);

            switch (bossAction)
            {
                case 1:
                    {
                        you.Health -= boss.Attack;
                        Console.WriteLine("Ah, não! Mewtwo atacou você!");
                        Thread.Sleep(2000);
                        break;
                    }
                case 2:
                    {
                        boss.Heal();
                        Console.WriteLine("Droga! Meu decidiu recuperar sua saúde dessa vez.");
                        Thread.Sleep(2000);
                        break;
                    }
                case 3:
                    {
                        boss.Boost();
                        Console.WriteLine("Mewtwo melhorou os atributos dele!");
                        Thread.Sleep(2000);
                        break;
                    }
                default: Console.WriteLine(""); break;
            }



            if (boss.Health < 0)
            {
                Console.Clear();
                Console.WriteLine("Parabéns você venceu!");
                Console.WriteLine("Pressione qualquer tecla para voltar para o menu principal...");
                Console.ReadLine();
                MainMenu.Show();
            }

            if (you.Health < 0)
            {
                Console.Clear();
                Console.WriteLine("Que pena você perdeu, tente novemante!");
                Console.WriteLine("Pressione qualquer tecla para voltar para o menu principal...");
                Console.ReadLine();
                MainMenu.Show();
            }

        }

    }
}