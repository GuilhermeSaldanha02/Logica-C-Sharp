Console.Write("Digite o nome do aluno: ");
string nome = Console.ReadLine();

Console.Write("Digite a Nota 1 (Peso 1): ");
double n1 = double.Parse(Console.ReadLine());

Console.Write("Digite a Nota 2 (Peso 5): ");
double n2 = double.Parse(Console.ReadLine());

Console.Write("Digite a Nota 3 (Peso 4): ");
double n3 = double.Parse(Console.ReadLine());

Console.Write("Digite a Frequência (%): ");
int frequencia = int.Parse(Console.ReadLine());

double media = ((n1 * 1) + (n2 * 5) + (n3 * 4)) / 10;

string situacao = "";

if (frequencia < 75)
{
    situacao = "Reprovado por Frequência";
}
else
{

    if (media >= 7.0)
    {
        situacao = "Aprovado";
    }
    else if (media >= 5.0)
    {
        situacao = "Recuperação";
    }
    else
    {
        situacao = "Reprovado por Nota";
    }
}


Console.WriteLine();
Console.WriteLine("=== BOLETIM FINAL ===");
Console.WriteLine("Aluno: " + nome);
Console.WriteLine($"Notas: {n1}, {n2}, {n3}");
Console.WriteLine($"Média: {media:F1}");
Console.WriteLine($"Frequência: {frequencia}%");
Console.WriteLine();
Console.WriteLine("Situação: " + situacao);
