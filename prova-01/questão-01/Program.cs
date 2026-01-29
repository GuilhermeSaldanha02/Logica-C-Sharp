List<string> produtos = [];
List<decimal> precos = [];
List<int> quantidades = [];

decimal valorTotalEstoque = 0;
decimal maiorPreco = 0;
string nomeProdutoMaisCaro = "";
int menorQuantidade = int.MaxValue;
string nomeProdutoMenorEstoque = "";

for (int i = 0; i < 5; i++)
{

    string nome = LerTexto("Digite o nome do produto:");
    produtos.Add(nome);


    decimal preco = LerDecimal("Digite o preço do produto:");
    precos.Add(preco);

    int quantidade = LerInt("Digite a quantidade em estoque:");
    quantidades.Add(quantidade);
}

for (int i = 0; i < produtos.Count; i++)
{
    valorTotalEstoque += precos[i] * quantidades[i];


    if (precos[i] > maiorPreco)
    {
        maiorPreco = precos[i];
        nomeProdutoMaisCaro = produtos[i];
    }


    if (quantidades[i] < menorQuantidade)
    {
        menorQuantidade = quantidades[i];
        nomeProdutoMenorEstoque = produtos[i];
    }
}
Console.WriteLine("\n=== RELATÓRIO DE PRODUTOS ===");
Console.WriteLine($"Valor Total em Estoque: R$ {valorTotalEstoque}");
Console.WriteLine($"Produto Mais Caro: {nomeProdutoMaisCaro} (R$ {maiorPreco})");
Console.WriteLine($"Produto com Menor Estoque: {nomeProdutoMenorEstoque} ({menorQuantidade} un)");


string LerTexto(string mensagem)
{
    Console.WriteLine(mensagem);
    string entrada = Console.ReadLine();

    while (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("Erro! O campo não pode ser vazio. Tente de novo:");
        entrada = Console.ReadLine();
    }
    return entrada;
}

decimal LerDecimal(string mensagem)
{
    Console.WriteLine(mensagem);
    string entrada = Console.ReadLine();
    decimal numero;


    while (!decimal.TryParse(entrada, out numero) || numero <= 0)
    {
        Console.WriteLine("Erro! Digite um valor numérico maior que zero.");
        entrada = Console.ReadLine();
    }
    return numero;
}

int LerInt(string mensagem)
{
    Console.WriteLine(mensagem);
    string entrada = Console.ReadLine();
    int numero;


    while (!int.TryParse(entrada, out numero) || numero < 0)
    {
        Console.WriteLine("Erro! Digite um número inteiro válido (não negativo).");
        entrada = Console.ReadLine();
    }
    return numero;
}