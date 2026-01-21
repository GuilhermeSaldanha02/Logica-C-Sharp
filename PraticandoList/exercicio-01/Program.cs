List<string> mochila = new List<string>();

mochila.Add("Banana");
mochila.Add("Maçã");
mochila.Add("Pedra");

mochila.Remove("Pedra");

foreach (string fruta in mochila)
{
    Console.WriteLine($"O macaco está comendo: {fruta}");
}

Console.WriteLine($"Sobraram {mochila.Count} itens na mochila.");