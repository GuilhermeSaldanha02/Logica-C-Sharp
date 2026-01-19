//Variaveis
int idade = 20;

//Condicional simples
if(idade >= 18)
{ 
  Console.WriteLine("Pode tirar carteira de motorista."); 
}
else
{
  Console.WriteLine("Não pode tirar carteira de motorista.");
}


//Praticando condicional com interação do usuário
Console.WriteLine("=== Digita a idade ===");
int idade1 = int.Parse(Console.ReadLine());

if(idade1 > 18)
{ Console.WriteLine("Maior de idade."); 
}
else if(idade1 == 18)
{
  Console.WriteLine("Tem 18 anos.");
}
else 
{Console.WriteLine("Menor de idade.");
}
