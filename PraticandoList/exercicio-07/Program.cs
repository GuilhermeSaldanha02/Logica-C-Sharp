List<string> playlist = new List<string>();

while (true)
{
  Console.WriteLine("1-Adicionar");
  Console.WriteLine("2-Remover");
  Console.WriteLine("3-Ver Fila");
  Console.WriteLine("4-Sair");

  Console.WriteLine("Escolha um numero:");
  string opcao = Console.ReadLine();

  switch (opcao)
  {
    case "1":
      Console.WriteLine("Digite o nome de uma musica:");
      string Adicionar = Console.ReadLine();
      playlist.Add(Adicionar);
      break;

    case "2":
      Console.WriteLine("Digite o nome de uma musica:");
      string nomeRemover = Console.ReadLine();

      bool conseguiuRemover = playlist.Remove(nomeRemover);
      if (conseguiuRemover)
      {
        Console.WriteLine("Musica removida com sucesso!");
      }
      else
      {
        Console.WriteLine("Item não encontrado (verifique maiúsculas/minúsculas).");
      }
      break;

    case "3":
      Console.WriteLine("--- Lista de Musicas ---");

      for (int i = 0; i < playlist.Count; i++)
      {
        Console.WriteLine($"{i} - {playlist[i]}");
      }
      break;


    case "4":
      Console.WriteLine("Saindo...");
      return;

    default:
      Console.WriteLine("Opção inválida!");
  }
}