List<string> guardarNomes = [];

while (true)
{
    MostrarMenu();
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            if (guardarNomes.Count >= 5)
            {
                Console.WriteLine("Lotação maxima");
            }

            else
            {
                Console.WriteLine("Digite seu nome: ");
                string nome1 = Console.ReadLine();
                if (guardarNomes.Contains(nome1))
                {
                    Console.WriteLine($"{nome1} já existe na lista");
                }
                else
                {
                    Console.WriteLine($"{nome1} adicionado na lista");
                    guardarNomes.Add(nome1);
                }
            }
            break;

        case "2":
            Console.WriteLine("Digite seu nome: ");
            string nome2 = Console.ReadLine();
            if (guardarNomes.Contains(nome2))
            {
                Console.WriteLine($"{nome2} existe na lista e foi removido.");
                guardarNomes.Remove(nome2);

            }
            else
            {
                Console.WriteLine("nome não existe na lista!!");
            }
            break;

        case "3":
            Console.WriteLine("--- LISTA DE VIPs ---");
            foreach (string convidado in guardarNomes)
            {
                Console.WriteLine(convidado);
            }
            Console.WriteLine($"tem {guardarNomes.Count} pessoas");
            break;

        case "4":
            Console.WriteLine("finalizando sistema.");
            return;
    }
}

void MostrarMenu()
{
    Console.WriteLine("=== MENU ===");
    Console.WriteLine("1 - ADD");
    Console.WriteLine("2 - REMOVER");
    Console.WriteLine("3 - LISTAR");
    Console.WriteLine("4 - SAIR");
    Console.WriteLine("Digite uma opção:");
}