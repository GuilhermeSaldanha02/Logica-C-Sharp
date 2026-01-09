using System;

class Program
{
    public static void Main(string[] args)
    {
        // === PRODUTO 1 ---
        string nome = "Arroz integral";
        decimal preco = 12.50m;
        int estoque = 150;
        double peso = 1.5;
        bool emPromocao = true;
        char categoria = 'A';
        DateTime dataValidade = new DateTime(2026, 06, 15);

        Console.WriteLine("=== CADASTRO DE PRODUTO ===");        
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Preço: {preco.ToString("C")}");
        Console.WriteLine($"Quantidade em estoque: {estoque} unidades"); 
        Console.WriteLine($"Peso: {peso} kg");
        Console.WriteLine($"Em promoção: {(emPromocao ? "SIM" : "NÃO")}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"Data de Validade: {dataValidade.ToString("dd/MM/yyyy")}");


        // === PRODUTO 2 ===
        var nome2 = "Feijão Preto";
        var preco2 = 8.90m;        
        var estoque2 = 50;          
        var peso2 = 1.0;            
        var emPromocao2 = false;    
        var categoria2 = 'A';       
        var dataValidade2 = new DateTime(2026, 11, 30); 

        Console.WriteLine("=== CADASTRO DE PRODUTO 2 ===");
        Console.WriteLine($"Nome: {nome2}");
        Console.WriteLine($"Preço: {preco2.ToString("C")}");
        Console.WriteLine($"Quantidade em estoque: {estoque2} unidades"); 
        Console.WriteLine($"Peso: {peso2} kg");      
        Console.WriteLine($"Em promoção: {(emPromocao2 ? "SIM" : "NÃO")}"); 
        Console.WriteLine($"Categoria: {categoria2}");
        Console.WriteLine($"Data de Validade: {dataValidade2.ToString("dd/MM/yyyy")}");
    }
}