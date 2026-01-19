//Variavel
Console.WriteLine("==Informe uma linguagem==");
string linguagem = Console.ReadLine();

//Estrututa de escolha
switch(linguagem)
{
    case "html":
    Console.WriteLine("Linguagem de marcarção");
    break;

    case "css":
    Console.WriteLine("Linguagem de Estilo");
    break;

    case "c#":
    Console.WriteLine("Linguagem de Programação");
    break;

    default:
    Console.WriteLine("Linguagem desconhecida");
    break;
}

//Praticando
Console.WriteLine("== Informe sua nota:");
double nota = double.Parse(Console.ReadLine());

switch(nota)
{
    case 11:
    Console.WriteLine("passou");
    break;

    case 5:
    Console.WriteLine("recuperação");
    break;

    default:
    Console.WriteLine("reprovado");
    break;

}