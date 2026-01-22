List<string> tarefas = new List<string>();

while (true)
{
  Console.WriteLine("\n--- MENU ---");
  Console.WriteLine("1 - Adicionar");
  Console.WriteLine("2 - Remover");
  Console.WriteLine("3 - Listar");
  Console.WriteLine("4 - Sair");

  Console.WriteLine("Escolha uma opção:");
  string opcao = Console.ReadLine();

  switch (opcao)
  {
    case "1":
      Console.WriteLine("Digite um nome:");
      string nome = Console.ReadLine();
      tarefas.Add(nome);
      break;

    case "2":
      Console.WriteLine("Digite um nome para remover:");
      string nomeRemover = Console.ReadLine();

      bool conseguiuRemover = tarefas.Remove(nomeRemover);

      if (conseguiuRemover)
      {
        Console.WriteLine("Item removido com sucesso!");
      }
      else
      {
        Console.WriteLine("Item não encontrado (verifique maiúsculas/minúsculas).");
      }
      break;

    case "3":
      Console.WriteLine("--- Lista de Tarefas ---");

      for (int i = 0; i < tarefas.Count; i++)
      {
        Console.WriteLine($"{i} - {tarefas[i]}");
      }
      break;

    case "4":
      Console.WriteLine("Saindo...");
      return;

    default:
      Console.WriteLine("Opção inválida!");
      break;
  }
}