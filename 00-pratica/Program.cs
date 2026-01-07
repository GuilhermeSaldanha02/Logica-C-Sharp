// IF/ELSE
bool carteirinha =  true;

if (carteirinha == true)
{
    Console.WriteLine("Pode entrar!");
}
else
{ Console.WriteLine("Pode ir para casa, chorar!");}

// FOR
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Repetição numero: " +i);
}

// While/Do-while

int bateria = 3;
while (bateria > 0)
{
    Console.WriteLine($"Usando celular {bateria}%");
    bateria --;
}

int repeticoes = 0;
do
{ Console.WriteLine($"Fiz {repeticoes} flexão");
    repeticoes++;
}while (repeticoes < 3);

// Foreach/ arrays

string[] suplementos = {"whey", "creatina","pre-treino"
};
foreach (string suplemento in suplementos)
{
    Console.WriteLine($"Bora tomar {suplemento}");
}

// SWITCH CASE
Console.WriteLine("Digite seu objetivo (1, 2 ou 3):");

string texto = Console.ReadLine();
int objetivo = int.Parse(texto);
switch (objetivo)
{
    case 1:
    Console.WriteLine("Bora crescer! (Bulking)");
    break;

    case 2: 
    Console.WriteLine("Bora secar! (Cutting");
    break;

    case 3:
    Console.WriteLine("Manter o peso");
    break;

    default:
    Console.WriteLine("Objetivo inválido. Coma fruta.");
    break;
}