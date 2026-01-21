List<string> convidados = new List<string>();

for(int i = 0; i < 2; i++){
Console.WriteLine("Digite seu nome na lista: ");
convidados.Add(Console.ReadLine());
}

Console.WriteLine($"Foi convidado: {convidados.Count}");