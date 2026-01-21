int numero;
int total = 0;

Console.WriteLine("Digite um numero: ");

numero = int.Parse(Console.ReadLine());


while (numero >= 0)
{
    
    total += numero;  
    Console.WriteLine("Digite um numero: ");
    numero = int.Parse(Console.ReadLine());
    
}

Console.WriteLine($"Soma total: {total}");
