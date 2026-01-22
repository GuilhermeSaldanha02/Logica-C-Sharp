Console.WriteLine("Digite sua idade: ");
int idade;

while (!int.TryParse(Console.ReadLine(), out idade))
{
    Console.WriteLine("Isso não é número! Digite de novo:");
}
if (idade < 18)
    Console.WriteLine("Menor de idade");

else
    Console.WriteLine("Maior de idade");
