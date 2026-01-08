//Estrutura Encadeada

Console.WriteLine("=== qual km do carro?");
double carro = double.Parse(Console.ReadLine());

if(carro >= 8.0)
{
Console.WriteLine("Bateu o motor!");
}
else if(carro == 7.0)
{
Console.WriteLine("Fazer revisão!");
}
else
{
Console.WriteLine("Aguardar dar 7.0  para revisão.");
}
