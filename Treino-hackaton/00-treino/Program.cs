
Random gerador = new Random();

int numeroSecreto = gerador.Next(1,1000);

int chute = 0;
int tentativas = 0;

while(chute != numeroSecreto)
{
    chute = int.Parse(Console.ReadLine());
    tentativas++;

    if(chute == numeroSecreto)
    {
        Console.WriteLine("Parabens você acertou!!");
    }
    else if(chute < numeroSecreto)
    {
        Console.WriteLine("O número secreto é MAIOR (+).");
    }
    else
    {
        Console.WriteLine("O numero secreto é menor (-).");
    }
}
