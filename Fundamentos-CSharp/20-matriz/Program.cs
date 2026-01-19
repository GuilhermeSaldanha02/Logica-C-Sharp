// Matriz
string[,] carros =
{
    {"bmw", "2025"},
    {"mercedes", "2024" },
    {"audi", "2020"},
    {"volvo", "2019"}
};

foreach (string carro in carros)
{
    Console.WriteLine($"o modelo é: {carro}");
}