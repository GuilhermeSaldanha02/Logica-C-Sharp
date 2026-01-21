decimal[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("Crescente:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

Console.WriteLine(); 

Console.WriteLine("Decrescente:");
for (int i = numeros.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
}
