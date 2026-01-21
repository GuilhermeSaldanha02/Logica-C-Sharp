List<string> convidados = new List<string>();

bool condicao = true;

while(condicao)
{
    Console.WriteLine("Digite seu nome na lista: ");
    string nome = Console.ReadLine();

    if(nome == "sair")
    {
        break;
    }
    convidados.Add(nome);    
}

Console.WriteLine($"Festa fechada com {convidados.Count} convidados!");