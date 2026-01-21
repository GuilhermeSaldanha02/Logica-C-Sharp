using PraticandoEnum.Enum;

OperacaoBancariaEnum acao = OperacaoBancariaEnum.Sacar;

switch (acao)
{
    case OperacaoBancariaEnum.Sacar:
    Console.WriteLine("Sacando dinheiro");        
    break;

    case OperacaoBancariaEnum.Depositar:
    Console.WriteLine("Depositando dinheiro");
    break;
    
    case OperacaoBancariaEnum.VerSaldo:
    Console.WriteLine("Seu saldo é R$ 10,00");
    break;

    case OperacaoBancariaEnum.Sair:
    Console.WriteLine("Saindo");
    break;

    default:
    Console.WriteLine("Opção invalida.");
    break;
}