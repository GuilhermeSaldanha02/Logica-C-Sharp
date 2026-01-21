using PraticandoEnum.Enum;

InimigoJogoEnum inimigo = InimigoJogoEnum.Goblin;

switch(inimigo)
{
    case InimigoJogoEnum.Goblin:
    Console.WriteLine("Você perdeu 10 de vida");
    break;

    case InimigoJogoEnum.Slime:
    Console.WriteLine("Você perdeu 5 de vida");
    break;

    case InimigoJogoEnum.Dragao:
    Console.WriteLine("Corre! Você perdeu 100 de vida.");
    break;

    default:
    Console.WriteLine("Erro na estrutura.");
    break;
}