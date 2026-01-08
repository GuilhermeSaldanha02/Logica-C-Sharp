//Variáveis
Console.WriteLine("=== Informe a nota===");

double media = double.Parse(Console.ReadLine());

string situacao = media >= 7 ? "Aprovado(a)" : "Reprovado(a)";
Console.WriteLine(situacao);