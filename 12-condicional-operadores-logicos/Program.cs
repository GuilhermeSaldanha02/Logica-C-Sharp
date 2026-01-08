//Variáveis
Console.WriteLine("=== Informe o valor! ===");

double valor = double.Parse(Console.ReadLine());
string pagamento = "á vista";

if(valor >= 100 && pagamento == "á vista")
{ Console.WriteLine($"Desconto de 10%! total a pagar é R${valor*0.9}");
}
else
{
Console.WriteLine($"O total da compra é R${valor}");
}

//teste de conhecimento
Console.WriteLine("=== Informe qual andar você deseja ir ===");
int andar = int.Parse(Console.ReadLine());
string botao = "descer";

if(andar <= 10 && botao == "descer")
{ Console.WriteLine($"Descendo para o andar {andar}");
}
else if(andar > 10 && botao == "subir")
{ Console.WriteLine($"Subindo para o andar {andar}");
}
else
{Console.WriteLine("Operação inválida!");
}