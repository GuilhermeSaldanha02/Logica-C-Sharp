Console.WriteLine("=== Caixa Automatico===");

decimal totalVendas = 0;
int contador = 1;

while(contador <= 5)
{
    Console.WriteLine($"Informe o {contador} da venda");
    decimal valorVenda = decimal.Parse(Console.ReadLine());

    totalVendas += valorVenda;
    Console.WriteLine($"venda {contador} Registrada: {valorVenda:C}");
    contador++;
}

Console.WriteLine($"Quantidade de vendas: {contador - 1}");
Console.WriteLine($"Total no cofre: {totalVendas:C}");
Console.WriteLine("=========================");

Console.WriteLine("=== Validação de senhas ===");


string senhaCorreta = "loja2026";
int tentativas = 0;
bool conseguiuEntar = false;

while(tentativas < 3 && conseguiuEntar == false)
{
    Console.WriteLine($"Tentativa: {tentativas + 1} de 3. Digite a senha:");
    string usuarioDigitou = Console.ReadLine();

if (usuarioDigitou == senhaCorreta)
{
Console.WriteLine("Sucesso! acesso liberado");
conseguiuEntar = true;
}
else
    {
        tentativas++;
        Console.WriteLine("Senha errada!");

        if(tentativas == 3)
        {
            Console.WriteLine("Bloqueado! Acabaram suas chances.");
        }
    }
}
Console.WriteLine("=========================");

string produtoAgua = "Água mineral";
int estoqueAgua = 45;
int estoqueDesejado = 100;
int quantidadeCaixa = 12;
int contadorCaixas = 0;

while(estoqueAgua <= estoqueDesejado)
{
estoqueAgua += quantidadeCaixa;
contadorCaixas++;
}
int excedente = estoqueAgua - estoqueDesejado;

Console.WriteLine($"Estoque Final: {estoqueAgua}");
Console.WriteLine($"Caixas necessarias: {contadorCaixas}");
Console.WriteLine($"Excedentes: {excedente} unidades");
Console.WriteLine("=========================");

Console.WriteLine("Meta De Vendas");

decimal metaDiaria = 5000.00m;
Console.WriteLine($"A meta diaria é: {metaDiaria}");

decimal[] vendasMeta =
{
    850.00m,1200.00m,650.00m,980.00m,1500.00m,420.00m
};

decimal totalVendido = 0.0m;
int i = 0;

while(totalVendido < metaDiaria && i < vendasMeta.Length)
{
    decimal vendaAtual = vendasMeta[i];
    totalVendido += vendaAtual;
    Console.WriteLine($"venda {i+1}: {vendaAtual:C} (total no cesto: {totalVendido})");
    i++;
}

decimal diferenca = totalVendido - metaDiaria;
decimal media = 0;

if (i > 0)
{
    media = totalVendido / i;
}
Console.WriteLine($"Total Vendido: {totalVendido:C}");
Console.WriteLine($"Vendas necessárias: {i}");
Console.WriteLine($"Média por venda: {media:C}");

if (totalVendido >= metaDiaria)
{
    Console.WriteLine($"META BATIDA! Ultrapassou por: {diferenca:C}");
}
else
{
    Console.WriteLine($"META NÃO ATINGIDA. Faltou: {diferenca * -1:C}");
}
Console.WriteLine("=========================");

int menuEscolha = -1;

while(menuEscolha != 0)
{
    Console.WriteLine("\n=== MENU ===");
    Console.WriteLine("1 - Consultar Estoque");
    Console.WriteLine("2 - Registrar Venda");
    Console.WriteLine("3 - Emitir Relatório");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    menuEscolha = int.Parse(Console.ReadLine());

    switch(menuEscolha)
    {
      case 1:
            Console.WriteLine("Consultando estoque...");
            break; 
        
        case 2:
            Console.WriteLine("Registrando venda...");
            break;
        
        case 3:
            Console.WriteLine("Emitindo relatório...");
            break;
        
        case 0:
            Console.WriteLine("Tchau! Fechando o caixa...");
            break;
        
        default: 
            Console.WriteLine("Opção inválida! O macaco não conhece esse número.");
            break;
    }
}
Console.WriteLine("Sistema encerrado.");