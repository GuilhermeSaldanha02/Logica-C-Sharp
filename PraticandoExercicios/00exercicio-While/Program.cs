Console.WriteLine("============================");
Console.WriteLine("==== EXEMPLO ===");

int litros = 0;

while(litros < 10)
{
    Console.WriteLine($"Enchendo... Nivel atual: {litros}");
    litros++;
}
Console.WriteLine("Tanque cheio!");

Console.WriteLine("============================");
Console.WriteLine("==== Porteiro Digital ===");

string senhaDigitada = "";
string senhaCorreta = "1234";

while(senhaDigitada != senhaCorreta)
{
    Console.WriteLine("Digite uma senha:");
    senhaDigitada = Console.ReadLine();
}
Console.WriteLine("Acesso liberado!!");

Console.WriteLine("============================");
Console.WriteLine("==== Cofrinho da Viagem ===");

decimal deposito = 0;
decimal meta = 1000.00m;
decimal cofre = 0m;

while(cofre < meta)
{
    Console.WriteLine("Digite um valor:");
    deposito = decimal.Parse(Console.ReadLine());
    cofre += deposito;
}
Console.WriteLine($"Você juntou {cofre:C}");

Console.WriteLine("============================");
Console.WriteLine("==== Cofrinho da Viagem ===");