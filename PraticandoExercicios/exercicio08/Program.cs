decimal[] precos = { 45.90m, 120.00m, 8.50m, 250.00m, 15.75m, 89.90m, 5.00m, 180.00m };
int contador = 0;
decimal somaTotal = 0;
int produtoCaros = 0;
decimal produtoMenor = decimal.MaxValue;
decimal produtoMaior = decimal.MinValue;

foreach(decimal preco in precos)
{
Console.WriteLine($"{contador} {preco}");
contador++;
somaTotal += preco;
if(preco > 50.00m)
    {
    produtoCaros++;
    }
if( preco > produtoMaior)
    {
    produtoMaior = preco;    
    }
if(preco < produtoMenor)
    {
        produtoMenor = preco;
    }

}

Console.WriteLine("=== Lista De Produtos ===");
Console.WriteLine($"|Total da compra: {somaTotal:C}|");
Console.WriteLine($"|Quantidade de produtos caros (>50): {produtoCaros}|");
Console.WriteLine($"|O produto menor é: {produtoMenor:C}|");
Console.WriteLine($"|O produto maior é: {produtoMaior:C}|");

Console.WriteLine("---------------------------");

decimal somaValidos = 0;
int contadorProcessados = 0;
int ContadorIgnorados = 0;

foreach(decimal preco in precos)
{
if( preco < 10 || preco > 100)
    {
        ContadorIgnorados++;
        continue;
    }    
    contadorProcessados++;
    somaValidos += preco;

}

Console.WriteLine("=== Resultado ===");
Console.WriteLine($"A soma dos produtos filtrados: {somaValidos}");
Console.WriteLine($"A quantidade de produtos processados foi: {contadorProcessados}");
Console.WriteLine($"A quantidade de produto ignorados foi: {ContadorIgnorados}");

Console.WriteLine("---------------------------");

string[] produtos = { "Arroz", "Feijão", "Macarrão", "Óleo", "Açúcar", "Café", "Leite", "Pão" };

string busca = "Óleo";
int contadorProdutos = 0;
bool encontrado = false;


foreach(String produto in produtos)
{
    contadorProdutos++;
    if(produto == busca)
    {
        encontrado = true;
        break;
    }
}
if (encontrado)
{
    Console.WriteLine("Produto encontrado!");
    Console.WriteLine($"Foram verificados {contadorProdutos} itens até achar.");
}
else
{
    Console.WriteLine("Produto não encontrado na lista.");
    Console.WriteLine($"Total verificado: {contadorProdutos}");
}
Console.WriteLine("---------------------------");

string[] nomes = { "Notebook", "Mouse", "Teclado", "Monitor", "Webcam", "Headset" };
decimal[] precos = { 2500.00m, 45.00m, 120.00m, 800.00m, 150.00m, 200.00m };
int[] estoques = { 5, 50, 30, 8, 15, 20 };
char[] categorias = { 'E', 'E', 'E', 'E', 'E', 'E' };  

decimal valorTotalLoja = 0;

for(int i = 0; i < nomes.Length; i++)
{
if (estoques[i] == 0)
{
    continue;
}
decimal precoFinal = precos[i];
string mensagemDesconto = "";
if (estoques[i] > 20)
{
    precoFinal = precoFinal * 0.90m; 
    mensagemDesconto = "(Desc. 10%)";
}
string alerta = "";
if (estoques[i] < 10)
{
    alerta = "ESTOQUE BAIXO";
}
decimal totalDesteItem = precoFinal * estoques[i];
valorTotalLoja += totalDesteItem;
Console.WriteLine($"Produto: {nomes[i]} ({categorias[i]})");
Console.WriteLine($"Preço: {precoFinal:C} {mensagemDesconto}");
Console.WriteLine($"Estoque: {estoques[i]} un. {alerta}");
Console.WriteLine($"Total Item: {totalDesteItem:C}");
Console.WriteLine("- - - - - - - - -");
}
Console.WriteLine($"VALOR TOTAL DO ESTOQUE: {valorTotalLoja:C}");
Console.WriteLine("-------------------------------------------------");

string[] produtos = { "Produto A", "Produto B", "Produto C", "Produto D", "Produto E" };
decimal[] valores = { 150.00m, 0m, 300.00m, 75.00m, 0m };  
bool[] pagamentoAprovado = { true, false, true, true, false };

Decimal totalVendas = 0m;
int procesadas = 0;
int canceladas = 0;
int i = 0;

foreach(decimal valor in valores)
{
if(valor == 0m)
{
    canceladas++;
    i++;
    continue; 
}

if(pagamentoAprovado[i] == false)
{
    canceladas++;
    i++;
    continue;
}
totalVendas += valor;
procesadas++;
Console.WriteLine($"Venda confirmada: {produtos[i]} - {valor:C}");
if(totalVendas > 500)
{
    Console.WriteLine("META ATINGIDA!");
    break; 
}
i++;
}
Console.WriteLine($"Total: {totalVendas:C} | Processadas: {procesadas} | Canceladas: {canceladas}");
Console.WriteLine("-------------------------------------------------");

string[] produtos = { "Arroz", "Feijão", "Óleo", "Açúcar", "Café" };
decimal[] precos = { 25.00m, 8.50m, 12.00m, 6.00m, 15.00m };
int[] quantidades = { 3, 5, 2, 4, 1 };

decimal totalBruto = 0;

for (int i = 0; i < produtos.Length; i++)
{
    decimal subtotal = precos[i] * quantidades[i];
    totalBruto += subtotal;
    Console.WriteLine($"{produtos[i]}: {quantidades[i]} un x {precos[i]:C} = {subtotal:C}");
}

decimal valorDesconto = 0;

if (totalBruto > 100)
{
    valorDesconto = totalBruto * 0.10m;
}
else if (totalBruto >= 50)
{
    valorDesconto = totalBruto * 0.05m;
}

decimal totalLiquido = totalBruto - valorDesconto;

string categoria = "";

switch (totalLiquido)
{
    case < 50:
        categoria = "Compra Pequena";
        break;
    case <= 150:
        categoria = "Compra Média";
        break;
    default:
        categoria = "Compra Grande";
        break;
}

Console.WriteLine("--------------------------");
Console.WriteLine($"Total Bruto: {totalBruto:C}");
Console.WriteLine($"Desconto Aplicado: -{valorDesconto:C}");
Console.WriteLine($"Total a Pagar: {totalLiquido:C}");
Console.WriteLine($"Status: {categoria}");













