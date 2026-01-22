int quantidade;
Console.Write("Insira a quantidade de estagiários: ");

while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
{
    Console.WriteLine("Erro: Digite um número inteiro válido maior que zero!");
    Console.Write("Tente novamente: ");
}

double[] notas = new double[quantidade];

double soma = 0;
double maior = 0;
double menor = 10;
int aprovados = 0;
int reprovados = 0;

for (int i = 0; i < quantidade; i++)
{
    double nota;
    Console.Write($"Digite a nota do aluno {i + 1}: ");

    while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
    {
        Console.WriteLine("Erro: Digite uma nota válida (número entre 0 e 10).");
        Console.Write($"Digite novamente a nota do aluno {i + 1}: ");
    }
    
    notas[i] = nota;
    soma += nota;

    if (i == 0)
    {
        maior = nota;
        menor = nota;
    }
    else
    {
        if (nota > maior) maior = nota;
        if (nota < menor) menor = nota;
    }

    if (nota >= 7.0) aprovados++;
    else if (nota < 5.0) reprovados++;
}

double media = soma / quantidade;

string desempenho;

if (media >= 8.0) desempenho = "Excelente";
else if (media >= 6.0) desempenho = "Boa";
else if (media >= 5.0) desempenho = "Regular";
else desempenho = "Fraca";

Console.WriteLine("\n=== RELATÓRIO DA TURMA ===");

for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine($"Nota {i + 1}: {notas[i]:F1}");
}

Console.WriteLine("--------------------------");
Console.WriteLine($"Média: {media:F1}");
Console.WriteLine($"Maior: {maior:F1}");
Console.WriteLine($"Menor: {menor:F1}");
Console.WriteLine($"Aprovados (>= 7): {aprovados}");
Console.WriteLine($"Reprovados (< 5): {reprovados}");
Console.WriteLine($"Desempenho: {desempenho}");