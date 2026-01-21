List<string> carrinho = new List<string>();

while(true)
{
    Console.WriteLine("Insira os produtos até sair:");
    string compra = Console.ReadLine();

    if(compra == "pagar")
    {
        break;
    }
    carrinho.Add(compra);
}

Console.WriteLine($"Foi feita {carrinho.Count}");