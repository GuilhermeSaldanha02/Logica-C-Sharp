using AppClimaEnum;

ClimaEnum estacaoAno = ClimaEnum.inverno;

switch(estacaoAno)
{
    case ClimaEnum.primavera:
    Console.WriteLine("Use roupas leves e coloridas.");
    break;

    case ClimaEnum.verao:
    Console.WriteLine("Regata e chinelo! Beba muita água.");
    break;

    case ClimaEnum.outono:
    Console.WriteLine("Leve um casaco leve, pode ventar.");
    break;

    case ClimaEnum.inverno:
    Console.WriteLine("Touca, luvas e casaco pesado!");
    break;

    default:
        Console.WriteLine("Erro no sistema, não foi definido a variavel.");
    break;
}