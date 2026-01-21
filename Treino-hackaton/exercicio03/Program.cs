Console.Write("Temperatura (°C): ");

double celsius = double.Parse(Console.ReadLine());

double fahrenheit = (celsius * 1.8) + 32;

Console.WriteLine($"{celsius}°C equivalem a {fahrenheit}°F");
