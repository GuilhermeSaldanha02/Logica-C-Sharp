Console.WriteLine("--- CALCULADORA BLINDADA ---");

Console.WriteLine("Digite o primeiro número:");
string texto1 = Console.ReadLine();

if (!int.TryParse(texto1, out int numero1))
{
    Console.WriteLine("Erro! Isso não é número.");
    return;
}

Console.WriteLine("Digite o segundo número:");
string texto2 = Console.ReadLine();

if (!int.TryParse(texto2, out int numero2))
{
    Console.WriteLine("Erro! O segundo não é número.");
    return;
}

int total = numero1 + numero2;
Console.WriteLine($"Resultado: {numero1} + {numero2} = {total}");