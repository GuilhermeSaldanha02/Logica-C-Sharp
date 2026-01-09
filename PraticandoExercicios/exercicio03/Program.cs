Console.WriteLine("--------------------------------------------------");
Console.WriteLine("== Loja de Produtos ==");

string produto = "Leito";
Console.WriteLine($"Produto: {produto}");

int quantidadeEstoque = 50;
Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");

int quantidadeSolicitada = 30;
Console.WriteLine($"Quantidade solicitada: {quantidadeSolicitada}");

int estoqueMinimo = 20;
Console.WriteLine($"Estoque mínimo: {estoqueMinimo}");

Console.WriteLine($"Quantidade disponível? {quantidadeSolicitada <= quantidadeEstoque}");
Console.WriteLine($"Estoque abaixo do mínimo? {quantidadeEstoque < estoqueMinimo}");
Console.WriteLine($"Estoque após venda abaixo do mínimo? {quantidadeEstoque - quantidadeSolicitada < estoqueMinimo}");

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("== Loja de Promoções ==");
string doce = "Chocolate";
Console.WriteLine($"Doce: {doce}");

decimal precoDoce = 8.50m;
Console.WriteLine($"Preço do doce: R$ {precoDoce}");

int quantidadeDoceEstoque = 100;
Console.WriteLine($"Quantidade em estoque: {quantidadeDoceEstoque}");

DateTime dataValida = new DateTime(2026, 02, 01);
Console.WriteLine($"Validade: {dataValida}");
Console.WriteLine($"Data atual: {DateTime.Now}");
Console.WriteLine($"O produto está em promoção? {precoDoce < 10 && quantidadeDoceEstoque > 50 && (dataValida - DateTime.Now).Days > 30}");

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("== Valdação de compra ==");

decimal valorCompra = 250.00m;
Console.WriteLine($"Valor da compra: R$ {valorCompra}");

decimal valorPago = 300.00m;
Console.WriteLine($"Valor pago: R$ {valorPago}");

bool clienteVip = true;
Console.WriteLine($"Cliente VIP? {clienteVip}");

bool cupomDesconto = false;
Console.WriteLine($"Possui cupom de desconto? {cupomDesconto}");

Console.WriteLine($"Valor pago é suficiente? {valorPago >= valorCompra}");
Console.WriteLine($"Cliente VIP ou possui cupom de desconto? {clienteVip || cupomDesconto}");
Console.WriteLine($"Cliente é vip? {!clienteVip}");
Console.WriteLine($"Cliente tem acesso a desconto especial? {clienteVip && cupomDesconto}");


Console.WriteLine("--------------------------------------------------");
Console.WriteLine("== Valdação complexa ==");

string produtoEletronico = "Notebook Gamer";
Console.WriteLine($"Produto: {produtoEletronico}");

decimal precoEletronico = 4500.00m;
Console.WriteLine($"Preço: {precoEletronico}");

int estoqueEletronico = 5;
Console.WriteLine($"Estoque: {estoqueEletronico}");

int quantidadeSolicitada = 2;
Console.WriteLine($"Quantidade Solicitada: {quantidadeSolicitada}");

bool creditoCliente = true;
Console.WriteLine($"Cliente tem credito? {creditoCliente}");

decimal limiteCredito = 5000.00m;
Console.WriteLine($"Qual limite de credito do cliente? {limiteCredito}");

bool blackFriday = true;
Console.WriteLine($"Está na Black Friday? {blackFriday}");

Console.WriteLine($"Venda aprovada? { (estoqueEletronico >= quantidadeSolicitada) && ( (creditoCliente && limiteCredito >= precoEletronico * quantidadeSolicitada) || blackFriday ) }");

