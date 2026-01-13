decimal[] precos = {50.00m, 120.00m, 80.00m, 200.00m, 45.00m};

decimal total = 0m;

for (int i = 0; i < precos.Length; i++)
{
    Console.WriteLine($"O produto {i + 1} custa: {precos[i]:C}");
    total += precos[i];
}

Console.WriteLine($"Total da venda: {total:C}");
Console.WriteLine("=============");

int totalAlertas = 0;

for(int i = 1; i <= 10; i++)
{
    int estoque = 15 - i;

    string mensagem = $"Codigo: PRODOO {i} | Estoque: {estoque}";

    if(estoque < 10)
    {
        totalAlertas++;
        mensagem +=  "ALERTA";
    }
    Console.WriteLine(mensagem);
}    

Console.WriteLine($"Total de produtos em alerta: {totalAlertas}");

Console.WriteLine("=============");

decimal valorTotal = 1200.00m;
Console.WriteLine($"O valor total: {valorTotal:C}");
int parcelas = 6;
Console.WriteLine($"O numero de parcelas: {parcelas}");
decimal taxaJuros = 0.02m;
Console.WriteLine($"A taxa de juros é {taxaJuros:P}");
decimal totalPago = 0;

for(int i = 1; i <= 6; i++)
{
decimal baseParcela = valorTotal / parcelas;
decimal fatorJuros = (decimal)Math.Pow(1 + (double)taxaJuros, i);
decimal valorDestaParcela = baseParcela * fatorJuros;
DateTime vencimento = DateTime.Now.AddMonths(i);
totalPago += valorDestaParcela;
Console.WriteLine($"Parcela {i} | Vence: {vencimento:d} | Valor: {valorDestaParcela:C}");
}
Console.WriteLine($"O cliente pagou no final: {totalPago:C}");

Console.WriteLine("=============");

Console.WriteLine("--- INÍCIO DA CONTAGEM ---");

for(int i = 10; i >= 1; i--)
{
    if(i == 1)
    {
        Console.WriteLine($"Faltam {i} dia ÚLTIMO DIA DE PROMOÇÃO!");
    }
    else if (i <= 3)
    {
        Console.WriteLine($"Faltam {i} dia ÚLTIMO DIA DE PROMOÇÃO!");
    }
    else
    {
        Console.WriteLine($"Faltam {i} dias para o fim da promoção");
    }
}

Console.WriteLine("=============");

Random sorteio = new Random();

decimal totalVendas = 0;
int qtdAcima300 = 0;
decimal maiorVenda = 0;
decimal menorVenda = 100000;

for (int i = 1;i <= 20; i++ )
{
    decimal valorVenda;
    if(i % 2 == 0)
    {
        valorVenda = sorteio.Next(200,501);
    }
    else
    {
        valorVenda = sorteio.Next(50, 151);
    }
    totalVendas += valorVenda;
    if (valorVenda > 300)
    {
        qtdAcima300++;
    }
    if (valorVenda > maiorVenda)
    {
        maiorVenda = valorVenda;
    }
    if (valorVenda < menorVenda)
    {
        menorVenda = valorVenda;
    }
    Console.WriteLine($"Venda {i} : {valorVenda:C}");
}
decimal media = totalVendas / 20;

Console.WriteLine($"Total Vendido: {totalVendas:C}");
Console.WriteLine($"Média das Vendas: {media:C}");
Console.WriteLine($"Vendas acima de R$300: {qtdAcima300}");
Console.WriteLine($"Maior Venda: {maiorVenda:C}");
Console.WriteLine($"Menor Venda: {menorVenda:C}");

