int menu = 3;
Console.WriteLine("Opção selecionada: " + menu);

if (menu == 1)
{Console.WriteLine("Cadastrar Produto:");}
else if (menu == 2)
{
Console.WriteLine("Consultar Estoque");
}
else if(menu == 3)
{
Console.WriteLine("Emitir Relatorio");
}
else
{
Console.WriteLine("Sair");
}

Console.WriteLine("===================");
Console.WriteLine("  Menu Principal  ");
Console.WriteLine("===================");

Console.WriteLine("1 - Cadastrar produto");
Console.WriteLine("2 - Consultar estoque");
Console.WriteLine("3 - Realizar venda");
Console.WriteLine("4 - Emitir relatório");
Console.WriteLine("5 - Sair");


Console.Write("Selecione uma opção: ");
int menu1 = int.Parse(Console.ReadLine());

switch(menu1)
{
case 1:
Console.WriteLine("Cadastrar Produto");
break;

case 2:
Console.WriteLine("Consultar Estoque");
break;

case 3:
Console.WriteLine("Realizar Venda");
break;

case 4:
Console.WriteLine("Emitir Relatorio");
break; 

default:
Console.WriteLine("Sair");
break;
}

Console.WriteLine("===================");
Console.WriteLine("  Categoriração  ");
Console.WriteLine("===================");

Console.WriteLine("A - Alimentos: Validade curta, requer refrigeração");
Console.WriteLine("B - Bebidas: Validade média, armazenamento normal");
Console.WriteLine("E - Eletrônicos: Sem validade, requer cuidado especial");
Console.WriteLine("L - Limpeza: Validade longa, armazenamento normal");
Console.WriteLine("H - Higiene: Validade média, armazenamento normal");

Console.WriteLine("Escolha uma opção:");
string opcao = Console.ReadLine().ToUpper();

switch(opcao)
{
case "A":
Console.WriteLine("Alimentos: Validade curta, requer refrigeração");
break;

case "B":
Console.WriteLine("Bebidas: Validade média, armazenamento normal");
break;

case "E":
Console.WriteLine("Eletrônicos: Sem validade, requer cuidado especial");
break;

case "L":
Console.WriteLine("Limpeza: Validade longa, armazenamento normal");
break;

case "H":
Console.WriteLine("Higiene: Validade média, armazenamento normal");
break;

default:
Console.WriteLine("Opção invalida");
break;
}

Console.WriteLine("===================");
Console.WriteLine("  CÁLCULO DE IMPOSTO  ");
Console.WriteLine("===================");

string produto = "Notebook";
Console.WriteLine("Produto: " + produto);

string categoria = "Eletrônicos";
Console.WriteLine("Categoria: " + categoria);

decimal preco = 3000.00m;
Console.WriteLine("Preço: R$ " + preco.ToString("C"));

decimal impostoAlimentos = 0.05m;
Console.WriteLine("Imposto sobre Alimentos: " + impostoAlimentos.ToString("P"));

decimal impostoBebidas = 0.15m;
Console.WriteLine("Imposto sobre Bebidas: " + impostoBebidas.ToString("P"));

decimal impostoEletronicos = 0.25m;
Console.WriteLine("Imposto sobre Eletrônicos: " + impostoEletronicos.ToString("P"));

decimal impostoLivros = 0.00m;
Console.WriteLine("Imposto sobre Livros: " + impostoLivros.ToString("P"));

decimal impostoOutros = 0.18m;
Console.WriteLine("Imposto sobre Outros: " + impostoOutros.ToString("P"));

switch(categoria)
{
  case "alimentos":
    preco += preco * impostoAlimentos;
    Console.WriteLine("Preço com imposto: R$ " + preco.ToString("C"));
    break;

  case "bebidas":
    preco += preco * impostoBebidas;    
    Console.WriteLine("Preço com imposto: R$ " + preco.ToString("C"));
    break;

  case "Eletrônicos":
    preco += preco * impostoEletronicos;
    Console.WriteLine("Preço com imposto: R$ " + preco.ToString("C"));
    break;

  case "livros":
    preco += preco * impostoLivros;
    Console.WriteLine("Preço com imposto: R$ " + preco.ToString("C"));
    break;

  default:
    preco += preco * impostoOutros;
    Console.WriteLine("Preço com imposto: R$ " + preco.ToString("C"));
    break;
}
Console.WriteLine("===================");
Console.WriteLine("  Prazo de Entrega por Região  ");
Console.WriteLine("===================");

string regiao = Console.ReadLine().ToLower();
Console.WriteLine("Região selecionada: " + regiao);

int norte = 10;
int nordeste = 8;
int centroOeste = 7;
int sudeste = 3;
int sul = 5; 

switch(regiao)
{
  case "norte":
  Console.WriteLine($"A região é: {regiao}");
  Console.WriteLine($"Prazo de entrega: {DateTime.Now.AddDays(norte).ToString("dd/MM/yyyy")} ");
  break;

  case "nordeste":
  Console.WriteLine($"A região é: {regiao}");
  Console.WriteLine($"Prazo de entrega: {DateTime.Now.AddDays(nordeste).ToString("dd/MM/yyyy")} ");
  break;

  case "centroOeste":
  Console.WriteLine($"A região é: {regiao}");
  Console.WriteLine($"Prazo de entrega: {DateTime.Now.AddDays(centroOeste).ToString("dd/MM/yyyy")} ");
  break;

  case "sudeste":
  Console.WriteLine($"A região é: {regiao}");
  Console.WriteLine($"Prazo de entrega: {DateTime.Now.AddDays(sudeste).ToString("dd/MM/yyyy")} ");
  break;

  case "sul":
  Console.WriteLine($"A região é: {regiao}");
  Console.WriteLine($"Prazo de entrega: {DateTime.Now.AddDays(sul).ToString("dd/MM/yyyy")} ");
  break;

  default:
  Console.WriteLine("Região inválida");
  break;
}

Console.WriteLine("===================");
Console.WriteLine("  Sistema Combinado  ");
Console.WriteLine("===================");

string categoriaEletronicos = "Eletrônicos";
Console.WriteLine("Categoria: " + categoriaEletronicos);

string formaPagamento = "Credito";
Console.WriteLine("Forma de Pagamento: " + formaPagamento);

decimal valorProduto = 2000.00m; 
Console.WriteLine("Valor do Produto: R$ " + valorProduto.ToString("C"));


decimal taxaImposto = 0m;
decimal taxaAjustePagamento = 0m;

switch (categoriaEletronicos.ToLower())
{
 case "eletrônicos":
 taxaImposto = 0.25m;
 break;

 case "alimentos":
 taxaImposto = 0.05m;
 break;
 
 case "bebidas":
 taxaImposto = 0.15m;
 break;
 default:
 
 taxaImposto = 0.18m;
 break;
}

switch (formaPagamento.ToLower())
{
  case "dinheiro":
  taxaAjustePagamento = -0.10m;
  break;
  
  case "pix":
  taxaAjustePagamento = -0.05m;
  break;
  
  case "credito":
  taxaAjustePagamento = 0.05m;
  break;
  
  case "debito":
  taxaAjustePagamento = 0.00m;
  break;
}

decimal valorComImposto = valorProduto + (valorProduto * taxaImposto);
decimal valorFinal = valorComImposto + (valorComImposto * taxaAjustePagamento);

Console.WriteLine($"Taxa de Imposto aplicada: {taxaImposto.ToString("P")}");
Console.WriteLine($"Valor com Imposto: {valorComImposto.ToString("C")}");
Console.WriteLine($"Ajuste de Pagamento: {taxaAjustePagamento.ToString("P")}");
Console.WriteLine("===================");
Console.WriteLine($"VALOR FINAL A PAGAR: {valorFinal.ToString("C")}");
Console.WriteLine("===================");
    