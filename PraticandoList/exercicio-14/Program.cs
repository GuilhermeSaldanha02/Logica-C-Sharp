List<string> nomesProdutos = [];
List<double> precosProdutos = [];
List<double> produtosEconomicos = [];
List<double> produtosMedios = [];
List<double> produtosPremium = [];

int quantidade = 0;
bool quantidadeValida = false;

Console.WriteLine("=== SISTEMA DE ESTOQUE ===");


while (!quantidadeValida)
{
    Console.Write("Quantos produtos deseja cadastrar? ");
    string? entrada = Console.ReadLine();

    if (int.TryParse(entrada, out quantidade) && quantidade > 0)
    {
        quantidadeValida = true;
    }
    else
    {
        Console.WriteLine("Isso não é um número válido! Tente de novo.");
    }
}

Console.WriteLine();


for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine($"--- Cadastrando Produto nº {i + 1} ---");

    string nome = "";
    while (true)
    {
        Console.Write("Nome do produto: ");
        string? entradaNome = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(entradaNome))
        {
            nome = entradaNome;
            break;
        }
        Console.WriteLine("Erro! O nome não pode ser vazio.");
    }
    nomesProdutos.Add(nome);

    double preco = 0;
    while (true)
    {
        Console.Write("Preço do produto: ");
        string? entradaPreco = Console.ReadLine();

        if (double.TryParse(entradaPreco, out preco) && preco > 0)
        {
            break;
        }
        Console.WriteLine("Preço inválido! Deve ser numérico e maior que zero.");
    }
    precosProdutos.Add(preco);
}


foreach (double preco in precosProdutos)
{
    if (preco <= 50)
        produtosEconomicos.Add(preco);
    else if (preco <= 150)
        produtosMedios.Add(preco);
    else
        produtosPremium.Add(preco);
}

Console.WriteLine();
Console.WriteLine("=== RELATÓRIO INICIAL (CATEGORIAS) ===");
Console.WriteLine($"Econômicos: {produtosEconomicos.Count} | Médios: {produtosMedios.Count} | Premium: {produtosPremium.Count}");


Console.WriteLine();
Console.WriteLine("=== APLICAÇÃO DE DESCONTOS (PREMIUM) ===");

double percentualDesconto = 0;
while (true)
{
    Console.Write("Informe o % de desconto para produtos Premium (0-100): ");
    if (double.TryParse(Console.ReadLine(), out percentualDesconto) && percentualDesconto >= 0 && percentualDesconto <= 100)
    {
        break;
    }
    Console.WriteLine("Porcentagem inválida.");
}

List<string> produtosDescontados = [];
double totalEconomizado = 0;

for (int i = 0; i < nomesProdutos.Count; i++)
{

    if (precosProdutos[i] > 150)
    {
        double valorOriginal = precosProdutos[i];
        double valorDesconto = valorOriginal * (percentualDesconto / 100);
        double novoPreco = valorOriginal - valorDesconto;


        precosProdutos[i] = novoPreco;

        totalEconomizado += valorDesconto;
        produtosDescontados.Add($"{nomesProdutos[i]}: de {valorOriginal:C} para {novoPreco:C}");
    }
}

Console.WriteLine();
Console.WriteLine($"Desconto aplicado! Total economizado: {totalEconomizado:C}");
if (produtosDescontados.Count > 0)
{
    Console.WriteLine("Itens com desconto:");
    foreach (var item in produtosDescontados)
    {
        Console.WriteLine($" -> {item}");
    }
}
else
{
    Console.WriteLine("Nenhum produto Premium para aplicar desconto.");
}


Console.WriteLine();
Console.WriteLine("=== REMOÇÃO DE PRODUTOS ===");
Console.Write("Digite o nome exato do produto para remover: ");
string? buscaRemover = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(buscaRemover))
{

    int indice = nomesProdutos.FindIndex(n => n.Equals(buscaRemover, StringComparison.OrdinalIgnoreCase));

    if (indice != -1)
    {
        Console.WriteLine($"Encontrado: {nomesProdutos[indice]} | Preço: {precosProdutos[indice]:C}");
        Console.Write("Confirmar remoção? (S/N): ");
        string confirmacao = Console.ReadLine()?.ToUpper() ?? "N";

        if (confirmacao == "S")
        {

            nomesProdutos.RemoveAt(indice);
            precosProdutos.RemoveAt(indice);
            Console.WriteLine("Produto removido!");
        }
        else
        {
            Console.WriteLine("Operação cancelada.");
        }
    }
    else
    {
        Console.WriteLine("Produto não encontrado.");
    }
}


Console.WriteLine();
Console.WriteLine("=== RELATÓRIO FINAL DE ESTOQUE ===");

if (precosProdutos.Count > 0)
{

    double totalEstoque = precosProdutos.Sum();
    double mediaGeral = precosProdutos.Average();
    double maiorPreco = precosProdutos.Max();
    double menorPreco = precosProdutos.Min();


    int indexMaisCaro = precosProdutos.IndexOf(maiorPreco);
    string nomeMaisCaro = nomesProdutos[indexMaisCaro];

    Console.WriteLine();
    Console.WriteLine("--- Lista Atualizada ---");
    for (int i = 0; i < nomesProdutos.Count; i++)
    {
        string status = precosProdutos[i] > mediaGeral ? "(Acima da média)" : "";
        Console.WriteLine($"{i + 1}. {nomesProdutos[i]} - {precosProdutos[i]:C} {status}");
    }

    Console.WriteLine();
    Console.WriteLine("--- Estatísticas ---");
    Console.WriteLine($"Qtd Produtos: {nomesProdutos.Count}");
    Console.WriteLine($"Valor Total: {totalEstoque:C}");
    Console.WriteLine($"Média de Preço: {mediaGeral:C}");
    Console.WriteLine($"Mais Caro: {nomeMaisCaro} ({maiorPreco:C})");
    Console.WriteLine($"Mais Barato: {menorPreco:C}");

    if (totalEstoque > 1000)
    {
        Console.WriteLine();
        Console.WriteLine("*** ALERTA: Valor total do estoque ultrapassou R$ 1.000,00! ***");
    }
}
else
{
    Console.WriteLine("O estoque está vazio.");
}


Console.WriteLine();
Console.WriteLine("=== FILTRO POR FAIXA DE PREÇO ===");
Console.WriteLine("Deseja filtrar produtos? (Enter para pular, S para sim)");
if (Console.ReadLine()?.ToUpper() == "S" && precosProdutos.Count > 0)
{
    double min = 0, max = 0;

    Console.Write("Preço Mínimo: ");
    double.TryParse(Console.ReadLine(), out min);

    Console.Write("Preço Máximo: ");
    double.TryParse(Console.ReadLine(), out max);

    if (min < max)
    {
        var produtosFiltrados = 0;
        double valorFiltrados = 0;

        Console.WriteLine();
        Console.WriteLine($"Produtos entre {min:C} e {max:C}:");

        for (int i = 0; i < nomesProdutos.Count; i++)
        {
            if (precosProdutos[i] >= min && precosProdutos[i] <= max)
            {
                Console.WriteLine($" - {nomesProdutos[i]} ({precosProdutos[i]:C})");
                produtosFiltrados++;
                valorFiltrados += precosProdutos[i];
            }
        }

        if (produtosFiltrados == 0) Console.WriteLine("Nenhum produto encontrado nesta faixa.");
        else
        {
            double porcentagem = (double)produtosFiltrados / nomesProdutos.Count * 100;
            Console.WriteLine($"Representa {porcentagem:F1}% do total de itens.");
        }
    }
    else
    {
        Console.WriteLine("Erro: O mínimo deve ser menor que o máximo.");
    }
}

Console.WriteLine();
Console.WriteLine("Fim do programa.");
Console.ReadKey();