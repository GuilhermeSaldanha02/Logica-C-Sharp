Console.WriteLine("==== Praticano FOR ====");

decimal cofre = 100.00m;
decimal total = 0m; 
for(int i = 1; i <= 12; i++)
{
Console.WriteLine($"|No mês {i} coloquei {cofre}|"); 

total += cofre; 
}
Console.WriteLine($"|O valor total juntado nós 12 meses foi de: {total:C}|");
Console.WriteLine("============================");

Console.WriteLine("==== Microondas ====");
for ( int i = 10; i >= 1; i--)
{
Console.WriteLine($"Esquentando.. faltam {i} segundos");
}
Console.WriteLine("Plim! Comida pronta");

Console.WriteLine("============================");
Console.WriteLine("==== Fiscal de Divisíveis ====");

int totalMultiplosCinco = 0;

for(int i = 1; i <= 50; i++)
{
if(i % 5 == 0)
{
Console.WriteLine($"Encontrei o numero {i}, que é múltiplo de 5");
totalMultiplosCinco+=i;
}
}
Console.WriteLine($"A soma total dos múltiplos de 5 encontrados é: {totalMultiplosCinco}");
Console.WriteLine("============================");

Console.WriteLine("==== Seletor de Promoção ====");
int ganhadores = 0;

for(int i = 1; i <= 50; i++)
{
if(i % 3 == 0 && i % 2 != 0)
{
Console.WriteLine($"O numero {i} é impar");
ganhadores++;
// ganhadores++; serve para saber quantas pessaoas ganharam.
// ganhadores += i;  serve para somar a quantidade sorteado.  
}
}
Console.WriteLine($"O total de ganhadores foi: {ganhadores}");

Console.WriteLine("============================");
Console.WriteLine("==== Análise de Vendas ===");

int quantidadeVendas = 0;
int totalFaturado = 0;

for(int i = 1; i <= 100;i++)
{
if(i >= 50)
{
Console.WriteLine($"O numero é {i}");
quantidadeVendas++;
totalFaturado += i;
}
}
Console.WriteLine($"Foram {quantidadeVendas} vendas grandes!");
Console.WriteLine($"O valor total das vendas foi: {totalFaturado:C}");

Console.WriteLine("============================");
Console.WriteLine("==== Planejamento de Leitura ===");

int quantidadePaginas = 0;
int diaNormal = 15;
int diaDescanso = 5;

for(int i = 1; i <= 30; i++)
{
if(i % 7 == 0)
{
Console.WriteLine($"hoje dia {i} ele {diaDescanso}paginas!");
quantidadePaginas+=diaDescanso;
}
else 
{
Console.WriteLine($"Hoje como é dia {i} ele leu {diaNormal}paginas!");
quantidadePaginas+=diaNormal;
}
}
Console.Write($"No final dos 30 dias ele leu {quantidadePaginas}");
Console.WriteLine("============================");
Console.WriteLine("==== Controle de Reforma ===");

decimal maisBarato = 1000.00m;
decimal maisCaro = 2500.00m;
decimal alerta = 4000.00m;
decimal totalSoma = 0m;

for (int i = 1;i <= 5;i++)
{
    if (i <= 3)
    {
        Console.WriteLine($"O custo do {i} é {maisBarato:C}");
        totalSoma += maisBarato;
    }
    else  
    {
        Console.WriteLine($"O custo do {i} é {maisCaro:C}");
        totalSoma += maisCaro;
    }
    if(totalSoma >= alerta)
    {
Console.WriteLine($"ALERTA NA ETAPA {i}: Total de {totalSoma:C} estourou o orçamento!");    }
}
Console.WriteLine($"A obra custou {totalSoma:C}");

Console.WriteLine("============================");
Console.WriteLine("==== Jogo de Aventura ===");

int danoChefe = 20;
int bonusChefe = 10;
int bonusComum = 5;
int totalFinal = 0;

for(int i = 1; i <= 15;i++)
{
    if( i % 5 == 0)
    {
        totalFinal-= danoChefe;

    }
    else if(i % 2 == 0)
    {
        totalFinal += bonusChefe;
    }
    else
    {
        totalFinal += bonusComum;
    }
}

Console.WriteLine($"O score final foi: {totalFinal}");