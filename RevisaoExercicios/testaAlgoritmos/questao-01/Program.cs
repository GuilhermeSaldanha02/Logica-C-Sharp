Console.Clear();
string produto;
int quantidade;
decimal preco, subTotal, total, descontoValor;
bool promocaValida;

decimal desconto = 0.12m;
decimal freteFixo = 35.00m;

Console.WriteLine($"Informe o nome do produto: ");
produto = Console.ReadLine();

if (string.IsNullOrWhiteSpace(produto))
{
    Console.WriteLine("Nome do produto inválido. Encerrando o programa.");
    return;
}

Console.WriteLine($"Informe a quantidade do produto");
string quantidadeInput = Console.ReadLine();

bool sucess = int.TryParse(quantidadeInput, out quantidade);
if (!sucess || quantidade <= 0)
{
    Console.WriteLine($"essa {quantidadeInput} é inválida. Encerrando o programa.");
    return;
}

Console.WriteLine($"Informe o preço do produto:");
string precoInput = Console.ReadLine();
if (!decimal.TryParse(precoInput, out preco) || preco <= 0 || string.IsNullOrWhiteSpace(precoInput))
{
    Console.WriteLine($"O preço {precoInput} é inválido. Encerrando o programa.");
    return;
}

bool exit = true;
while (true)
{
    Console.WriteLine($"Informe se tem promoção (s/n)");
    string promocaoInput = Console.ReadLine();

    switch (promocaoInput.ToLower())
    {
        case "s":
            promocaValida = true;
            exit = false;
            break;
        case "n":
            promocaValida = false;
            exit = false;
            break;
        default:
            Console.WriteLine($"Digite s ou n");
            continue;
    }
    break;
}

subTotal = quantidade * preco;

if (subTotal >= 800)
    freteFixo = 0;

descontoValor = subTotal * desconto;

if (promocaValida)
    subTotal -= descontoValor;

total = subTotal + freteFixo;

Console.WriteLine($"Produto: {produto}");
Console.WriteLine($"Preco Unitario: {preco:C}");
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine($"Subtotal: {subTotal:C}");
Console.WriteLine($"Frete: {freteFixo:C}");
Console.WriteLine($"Promocao ativa: {(promocaValida ? "Sim" : "Nao")}");
Console.WriteLine($"Desconto: {descontoValor:C}");
Console.WriteLine($"Total a pagar: {total:C}");