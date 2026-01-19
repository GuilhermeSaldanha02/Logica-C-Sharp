// Console.WriteLine("============================");
// Console.WriteLine("==== EXEMPLO ===");

// int litros = 0;

// while(litros < 10)
// {
//     Console.WriteLine($"Enchendo... Nivel atual: {litros}");
//     litros++;
// }
// Console.WriteLine("Tanque cheio!");

// Console.WriteLine("============================");
// Console.WriteLine("==== Porteiro Digital ===");

// string senhaDigitada = "";
// while(senhaDigitada != senhaCorreta)
// {
//     Console.WriteLine("Digite uma senha:");
//     senhaDigitada = Console.ReadLine();
// }
// Console.WriteLine("Acesso liberado!!");

// Console.WriteLine("============================");
// Console.WriteLine("==== Cofrinho da Viagem ===");

// decimal deposito = 0;
// decimal meta = 1000.00m;
// decimal cofre = 0m;

// while(cofre < meta)
// {
//     Console.WriteLine("Digite um valor:");
//     deposito = decimal.Parse(Console.ReadLine());
//     cofre += deposito;
// }
// Console.WriteLine($"Você juntou {cofre:C}");

// Console.WriteLine("============================");
// Console.WriteLine("==== Calculadora Simples  ===");

// int opcao = -1;

// while(opcao != 0)
// {
//     Console.WriteLine("=== MENU ===");
//     Console.WriteLine("1 - Somar");
//     Console.WriteLine("2 - Subtrair");
//     Console.WriteLine("0 - SAIR");
//     Console.WriteLine("Escolha uma opção: ");

//     opcao = int.Parse(Console.ReadLine());

//     if(opcao == 1)
//     {
//         Console.WriteLine("Você escolheu somar!");
//     }
//     else if (opcao == 2)
//     {
//         Console.WriteLine("Você escolheu subtrair!");
//     }
//     else if (opcao == 0)
//     {
//      Console.WriteLine("Saindo do sistema!");    
//     }
//     else
//     {
//      Console.WriteLine("Opção invalida!"); 
//     }
// }
// // Console.WriteLine("Programa Encerrado!"); 
// Console.WriteLine("============================");
// Console.WriteLine("==== Pedido na Lanchonete  ===");

// int opcaoLanchonete = -1;
// decimal totalConta = 0m;

// while(opcaoLanchonete != 0)
// {
//     Console.WriteLine("=== MENU ===");
//     Console.WriteLine("1 - X-burger (R$ 20,00)");
//     Console.WriteLine("2 - Refrigerante (R$ 5,00)");
//     Console.WriteLine("0 - Fechar Conta");
//     Console.WriteLine("Escolha uma opção: ");

//     opcaoLanchonete = int.Parse(Console.ReadLine());

//     if(opcaoLanchonete == 1)
//     {
//         decimal xburger = 20.00m;
//         Console.WriteLine("X-Burger adicionado!");
//         totalConta += xburger; 
//     }
//     else if (opcaoLanchonete == 2)
//     {
//         decimal refrigerante = 5.00m;
//         Console.WriteLine("Refrigerante adicionado!");
//         totalConta += refrigerante;
//     }
//     else if(opcaoLanchonete == 0)
//     {
//         Console.WriteLine("Fechando conta!"); 
//     }
//     else
//     {
//         Console.WriteLine("Opção invalida!");         
//     }
// }
// Console.WriteLine($"O total da conta foi: {totalConta}");

using System.Reflection;

Console.WriteLine("============================");
Console.WriteLine("==== Jogo da Adivinhação  ===");

int numeroSecreto = 7;
int tentativa = 0;

while(tentativa != numeroSecreto)
{
    Console.WriteLine("Digite um numero:");
    int tentativa = int.Parse(Console.ReadLine());

    if(tentativa == numeroSecreto)
    {
        Console.WriteLine("Acertou!!");
    }
    else if(tentativa < numeroSecreto)
    {
        Console.WriteLine("Numero menor que numero secreto!");
    }
    else if(tentativa > numeroSecreto)
    {
        Console.WriteLine("Numero maior que numero secreto!");
    }
    else
    {
        Console.WriteLine("Numero invalido!!");
    }
}

Console.WriteLine("Programa encerrado!");