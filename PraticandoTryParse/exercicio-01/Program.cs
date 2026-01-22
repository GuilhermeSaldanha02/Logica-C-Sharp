Console.WriteLine();

Console.WriteLine("Quantos anos você tem?");
string idadeString = Console.ReadLine();

bool deuCerto = int.TryParse(idadeString, out int idadeNumerica);

if (deuCerto)
{
    if (idadeNumerica >= 18)
        Console.WriteLine("Pode entrar na festa");

    else
        Console.WriteLine("Menor de idade");
}
else
    Console.WriteLine("Isso não é uma idade válida!");
