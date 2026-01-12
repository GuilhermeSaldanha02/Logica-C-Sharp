Console.WriteLine("----------------------------------------------");

Console.WriteLine("SISTEMA DE DESCONTOS:");
decimal valorCompra = 350m;
Console.WriteLine($"Valor original: {valorCompra:C}");


if(valorCompra > 500)
{
    decimal valor20 = valorCompra*0.20m;
    Console.WriteLine($"Desconto Aplicado: 20%");
    Console.WriteLine($"Valor do Desconto: {valor20:C}");  
    Console.WriteLine($"Valor Final: {valorCompra-valor20:C}");  
}
else if(valorCompra >= 300)
{
    decimal valor15 = valorCompra*0.15m;
    Console.WriteLine($"Desconto Aplicado: 15%");
    Console.WriteLine($"Valor do Desconto: {valor15:C}");
    Console.WriteLine($"Valor Final: {valorCompra-valor15:C}");
}
else if(valorCompra >= 100)
{
    decimal valor10 = valorCompra*0.10m;
    Console.WriteLine($"Desconto Aplicado: 10%");
    Console.WriteLine($"Valor do Desconto: {valor10:C}");
    Console.WriteLine($"Valor Final: {valorCompra-valor10:C}");
}
else
{
    Console.WriteLine("Sem desconto!");
    Console.WriteLine($"Valor da compra: {valorCompra:C}");
}

Console.WriteLine("----------------------------------------------");
Console.WriteLine("SISTEMA DE CLASSIFICAÇÃO:");
string nomeCliente = "Maria Silva";
Console.WriteLine($"Nome do cliente: {nomeCliente}");

decimal gastoMes = 2800.00m;
Console.WriteLine($"Total gasto no mês: {gastoMes:C}");

bool tempoCliente = true;
Console.WriteLine($"É cliente a mais de 1 ano: {tempoCliente}");


if(gastoMes >= 5000.00m)
{
    Console.WriteLine("Cliente Diamente: 25% de desconto + frete grátis");
}
else if (gastoMes > 2000.00m && gastoMes < 5000.00m && tempoCliente == true)
{
    Console.WriteLine("Cliente Ouro: 15% de desconto + frete grátis");
}
else if (gastoMes > 1000.00m && gastoMes < 1999.99m)
{
    Console.WriteLine("Cliente Prata: 10% de desconto");
}
else
{
    Console.WriteLine("Cliente Bronze: 5% de desconto");
}

Console.WriteLine("----------------------------------------------");
Console.WriteLine("SISTEMA DE VALIDAÇÃO DE VENDA:");

string produtoTv = "Smart TV 50 polegadas";
Console.WriteLine ($"Produto: {produtoTv}");

decimal precoTv = 2200.00m;
Console.WriteLine($"Preço: {precoTv:C}");

int estoqueTv = 3;
Console.WriteLine($"Estoque: {estoqueTv}");

int quantidadeSolicitada = 2;
Console.WriteLine($"Quantidade: {quantidadeSolicitada}");

bool creditoCliente = true;
Console.WriteLine($"Cliente tem limite de crédito: {creditoCliente}");

decimal limiteDisponivel = 3000.00m;
Console.WriteLine($"Limite disponivel: {limiteDisponivel:C}");

string[] formaPagamento = {"dinheiro","debito","credito","pix"};
Console.WriteLine($"Forma de pagamento: {formaPagamento[2]}");

decimal totalCompra = (precoTv*quantidadeSolicitada);
Console.WriteLine($"Total da compra{totalCompra:C}");

if (quantidadeSolicitada > estoqueTv) 
{
    Console.WriteLine("VENDA RECUSADA: Não temos estoque suficiente.");
}
else if (totalCompra > limiteDisponivel) 
{
    Console.WriteLine("VENDA RECUSADA: Limite do cartão insuficiente.");
}
else 
{
    Console.WriteLine("VENDA APROVADA: Parabéns pela compra!");
}

Console.WriteLine("----------------------------------------------");
Console.WriteLine("SISTEMA DE ALERTA DE ESTOQUE:");

string produtoGrao = "Arroz 5Kg";
Console.WriteLine($"Produto: {produtoGrao}");

int quantidadeGrao = 15;
Console.WriteLine($"Quantidade de estoque: {quantidadeGrao}");

int estoqueMinimoGrao = 20;
Console.WriteLine($"Estoque mínimo: {estoqueMinimoGrao}");

int estoqueMaximoGrao = 100;
Console. WriteLine($"Estoque Máximo: {estoqueMaximoGrao}");

int diasEntrega = 3;
Console.WriteLine($"Dias para próxima entrega: {diasEntrega}");

if (quantidadeGrao < estoqueMinimoGrao  && diasEntrega > 5)
{
Console.WriteLine("alerta: Critico");
}
else if (quantidadeGrao < estoqueMinimoGrao && diasEntrega <= 5)
{
Console.WriteLine("alerta: Atenção");
}
else if (quantidadeGrao >= estoqueMinimoGrao && quantidadeGrao <= estoqueMaximoGrao)
{
Console.WriteLine("alerta: Normal");   
}
else {Console.WriteLine("alerta: Estoque acima do maximo.");
}