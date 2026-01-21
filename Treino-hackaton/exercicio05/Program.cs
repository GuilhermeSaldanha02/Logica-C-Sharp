
Console.Write("N: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"Primos até {n}: ");

    
for(int i = 2; i <= n; i++)
{
 bool primo = true;
       
 for(int g = 2; g < i; g++)
 {
            
 if(i % g == 0)
 {
 primo = false; 
 break; 
 }
 }
 if(primo)
 {
 Console.Write($"{i}, ");
 }
}
    