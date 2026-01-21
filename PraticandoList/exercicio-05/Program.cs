List<string> listaVazadas = new List<string>();

listaVazadas.Add("123456");
listaVazadas.Add("admin");
listaVazadas.Add("senha");

for(int i = 0; i < 3; i++)
{
    Console.WriteLine($"--- Cadastrando a {i+1}ª senha ---"); 
    while(true)
    {
        
        Console.WriteLine("Digite a senha:");
        string senha = Console.ReadLine();
        if(listaVazadas.Contains(senha))
        {
            Console.WriteLine("Senha vazada, digite outra");
            continue;
        }
        else
        {
            Console.WriteLine("Senha cadastrada com sucesso!");
            listaVazadas.Add(senha);
            break;
        }
    }
}