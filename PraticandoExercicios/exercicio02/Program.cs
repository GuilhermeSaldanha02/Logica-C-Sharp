Console.WriteLine("--------------------------------------------------");

Console.WriteLine("== Calculo de venda ==");

string nome = "Notebook";
Console.WriteLine($"Produto: {nome}");

decimal preco = 2500m;
Console.WriteLine($"Preço unitário: R$ {preco}");

int quantidade = 2;
Console.WriteLine($"Quantidade: {quantidade}");

decimal subtotal = preco * quantidade;
Console.WriteLine($"Subtotal: R$ {subtotal}");

decimal valorDesconto = subtotal * 0.10m;
Console.WriteLine($"Desconto (10%): R$ {valorDesconto}");

decimal totalPagar = subtotal - valorDesconto;
Console.WriteLine($"Total a pagar: R$ {totalPagar}");

decimal valorPago = 5000m;
Console.WriteLine($"Valor pago pelo cliente: R$ {valorPago}");

decimal troco = valorPago - totalPagar;
Console.WriteLine($"O troco do cliente foi: R$ {troco}");

decimal parcelas = 3;
Console.WriteLine($"Número de parcelas: {parcelas}");

decimal totalParcelado = totalPagar / parcelas;
Console.WriteLine($"O total de parcelas foi: {totalParcelado}");

decimal sobra =  totalPagar % parcelas;
Console.WriteLine($"Sobrou algo? {sobra}");

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("== Calculo Nova Loja ==");

string produtoMouse = "Mouse";
Console.WriteLine($"Produto: {produtoMouse}");

decimal valorMouse = 4500m;
Console.WriteLine($"Preço unitário: R$ {valorMouse}");

int quantidadeMouse = 5;
Console.WriteLine($"Quantidade: {quantidadeMouse}");

string produtoTeclado = "Teclado";
Console.WriteLine($"Produto: {produtoTeclado}");

decimal valorTeclado = 120.00m;
Console.WriteLine($"Preço unitário: R$ {valorTeclado}");

int quantidadeTeclado = 3;
Console.WriteLine($"Quantidade: {quantidadeTeclado}");

string produtoMonitor = "Monitor";
Console.WriteLine($"Produto: {produtoMonitor}");

decimal valorMonitor = 800.00m;
Console.WriteLine($"Preço unitário: R$ {valorMonitor}");

int quantidadeMonitor = 2;
Console.WriteLine($"Quantidade: {quantidadeMonitor}");

decimal subTotal1 = valorMouse * quantidadeMouse;
Console.WriteLine($"O total Mouse é: R$ {subTotal1}");

decimal subTotal2 = valorTeclado * quantidadeTeclado;
Console.WriteLine($"O total Do Teclado é: R$ {subTotal2}");


decimal subTotal3 = valorMonitor * quantidadeMonitor;
Console.WriteLine($"O total Do Monitor é: R$ {subTotal3}");

decimal totalPagar2 = subTotal1 + subTotal2 + subTotal3;
Console.WriteLine($"O total das três compres é: R$ {totalPagar2}");

decimal desconto2 = 0.15m;
Console.WriteLine($"O desconto aplicado foi de: {desconto2:P}");

decimal totalDesconto2 = totalPagar2 * desconto2;
Console.WriteLine($"O valor total a se pagar com desconto fica: R${totalDesconto2}");