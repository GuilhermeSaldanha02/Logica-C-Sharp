List<string> alunos = [];
List<int> nota1 = [];
List<int> nota2 = [];
List<int> nota3 = [];


int contatorAprovado = 0;
int contadorRecuperacao = 0;
int contadorReprovado = 0;
decimal media;
int totalNotas;

for (int i = 1; i < 6; i++)
{
    string nome = LerTexto("Digite o nome do aluno:");
    alunos.Add(nome);

    int primeiraNota = LerInt($"Digite a nota 1:");
    nota1.Add(primeiraNota);

    int segundaNota = LerInt($"Digite a nota 2:");
    nota2.Add(segundaNota);

    int teceiraNota = LerInt($"Digite a nota 3:");
    nota3.Add(teceiraNota);
}

Console.WriteLine("=== BOLETIM DA TURMA ===");
for (int i = 0; i < alunos.Count; i++)
{
    totalNotas = nota1[i] + nota2[i] + nota3[i];
    media = (decimal)totalNotas / 3;

    string situacao = "";

    if (media >= 7)
    {
        situacao = "Aprovado";
        contatorAprovado++;
    }
    else if (media >= 5)
    {
        situacao = "Recuperação";
        contadorRecuperacao++;
    }
    else
    {
        situacao = "Reprovado";
        contadorReprovado++;

    }
    Console.WriteLine($"Aluno: {alunos[i]} | Média: {media:F1} | Status: {situacao}");
}
Console.WriteLine($"Total Aprovados: {contatorAprovado}");
Console.WriteLine($"Total em recuperação: {contadorRecuperacao}");
Console.WriteLine($"Total Reprovados: {contadorReprovado}");

string LerTexto(string mensagem)
{
    Console.WriteLine(mensagem);
    string entrada = Console.ReadLine();

    while (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("Erro! O campo não pode ser vazio. Tente de novo:");
        entrada = Console.ReadLine();
    }
    return entrada;
}

int LerInt(string mensagem)
{
    Console.WriteLine(mensagem);
    string entrada = Console.ReadLine();
    int numero;


    while (!int.TryParse(entrada, out numero) || numero < 0 || numero > 10)
    {
        Console.WriteLine("Erro! Digite um número inteiro válido (não negativo).");
        entrada = Console.ReadLine();
    }
    return numero;
}
