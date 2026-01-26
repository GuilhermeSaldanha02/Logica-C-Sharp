using Restaurante.Dominio;

List<string> nomesPratos = [];
List<double> valoresPedidos = [];
List<CategoriaPrato> categorias = [];
List<StatusPedido> statusPedidos = [];
List<double> valoresFinais = [];

Console.WriteLine("=== SISTEMA DE PEDIDOS GOURMET ===");

int quantidade = 0;
while (true)
{
    Console.Write("Quantos pedidos deseja registrar? ");
    if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade > 0) break;
    Console.WriteLine("Por favor, digite um número válido.");
}

for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine();
    Console.WriteLine($"--- Pedido #{i + 1} ---");

    Console.Write("Nome do Prato: ");
    string nome = Console.ReadLine() ?? "Prato Genérico";
    nomesPratos.Add(nome);

    double valor = 0;
    while (true)
    {
        Console.Write("Valor (R$): ");
        if (double.TryParse(Console.ReadLine(), out valor) && valor > 0) break;
        Console.WriteLine("Valor inválido.");
    }
    valoresPedidos.Add(valor);

    while (true)
    {
        Console.WriteLine("Categorias: 1-Entrada, 2-Prato Principal, 3-Sobremesa, 4-Bebida");
        Console.Write("Opção: ");
        if (int.TryParse(Console.ReadLine(), out int catInput) && Enum.IsDefined(typeof(CategoriaPrato), catInput))
        {
            categorias.Add((CategoriaPrato)catInput);
            break;
        }
        Console.WriteLine("Categoria inválida!");
    }

    while (true)
    {
        Console.WriteLine("Status: 1-Pendente, 2-Em Preparação, 3-Pronto, 4-Entregue, 5-Cancelado");
        Console.Write("Opção: ");
        if (int.TryParse(Console.ReadLine(), out int statInput) && Enum.IsDefined(typeof(StatusPedido), statInput))
        {
            statusPedidos.Add((StatusPedido)statInput);
            break;
        }
        Console.WriteLine("Status inválido!");
    }
}

Console.WriteLine();
Console.WriteLine("=== TAREFA 2: TAXAS DE SERVIÇO ===");

for (int i = 0; i < nomesPratos.Count; i++)
{
    double taxa = categorias[i] switch
    {
        CategoriaPrato.Entrada => 0.05,
        CategoriaPrato.PratoPrincipal => 0.10,
        CategoriaPrato.Sobremesa => 0.07,
        CategoriaPrato.Bebida => 0.03,
        _ => 0.0
    };

    double total = valoresPedidos[i] * (1 + taxa);
    valoresFinais.Add(total);

    Console.WriteLine($"Pedido: {nomesPratos[i]} | Categoria: {categorias[i]} | Taxa: {taxa:P0} | Final: {total:C}");
}

Console.WriteLine();
Console.WriteLine("=== TAREFA 3: RESUMO POR STATUS ===");

List<string> pendentes = [], emPreparo = [], prontos = [], entregues = [], cancelados = [];

for (int i = 0; i < statusPedidos.Count; i++)
{
    string resumo = $"{nomesPratos[i]} ({valoresFinais[i]:C})";

    switch (statusPedidos[i])
    {
        case StatusPedido.Pendente: pendentes.Add(resumo); break;
        case StatusPedido.EmPreparacao: emPreparo.Add(resumo); break;
        case StatusPedido.Pronto: prontos.Add(resumo); break;
        case StatusPedido.Entregue: entregues.Add(resumo); break;
        case StatusPedido.Cancelado: cancelados.Add(resumo); break;
    }
}

Console.WriteLine($"Pendentes: {pendentes.Count} | Cozinha: {emPreparo.Count} | Prontos: {prontos.Count} | Entregues: {entregues.Count} | Cancelados: {cancelados.Count}");

Console.WriteLine();
Console.WriteLine("=== TAREFA 4: ATUALIZAÇÃO EM LOTE ===");
Console.WriteLine("Deseja atualizar status em massa? (S/N)");
if (Console.ReadLine()?.ToUpper() == "S")
{
    Console.Write("Mudar de (Status 1-5): ");
    int.TryParse(Console.ReadLine(), out int de);

    Console.Write("Para (Status 1-5): ");
    int.TryParse(Console.ReadLine(), out int para);

    if (Enum.IsDefined(typeof(StatusPedido), de) && Enum.IsDefined(typeof(StatusPedido), para))
    {
        var statusDe = (StatusPedido)de;
        var statusPara = (StatusPedido)para;
        int contagem = 0;

        for (int i = 0; i < statusPedidos.Count; i++)
        {
            if (statusPedidos[i] == statusDe)
            {
                statusPedidos[i] = statusPara;
                contagem++;
            }
        }
        Console.WriteLine($"Atualizado: {contagem} pedidos passaram de {statusDe} para {statusPara}.");
    }
}

Console.WriteLine();
Console.WriteLine("=== TAREFA 5: ESTIMATIVA DE TEMPO ===");
int tempoTotal = 0;

for (int i = 0; i < categorias.Count; i++)
{
    if (statusPedidos[i] == StatusPedido.Cancelado) continue;

    tempoTotal += categorias[i] switch
    {
        CategoriaPrato.Entrada => 15,
        CategoriaPrato.PratoPrincipal => 30,
        CategoriaPrato.Sobremesa => 20,
        CategoriaPrato.Bebida => 5,
        _ => 0
    };
}
Console.WriteLine($"Tempo total estimado de preparo (pedidos ativos): {tempoTotal} minutos");

Console.WriteLine();
Console.WriteLine("=== TAREFA 6: ANÁLISE GERAL ===");
double faturamentoReal = 0;
int ativos = 0;

for (int i = 0; i < statusPedidos.Count; i++)
{
    string acao = statusPedidos[i] switch
    {
        StatusPedido.Pendente => "Aguardando início",
        StatusPedido.EmPreparacao => "Fogo alto!",
        StatusPedido.Pronto => "Liberado para entrega",
        StatusPedido.Entregue => "Concluído",
        StatusPedido.Cancelado => "Descartar",
        _ => "Desconhecido"
    };

    Console.WriteLine($"Pedido {i + 1}: {nomesPratos[i]} -> {acao}");

    if (statusPedidos[i] == StatusPedido.Cancelado) continue;

    ativos++;
    if (statusPedidos[i] == StatusPedido.Entregue)
    {
        faturamentoReal += valoresFinais[i];
    }
}

if (valoresFinais.Count > 0)
{
    double maxVal = valoresFinais.Max();
    string pratoCaro = nomesPratos[valoresFinais.IndexOf(maxVal)];

    Console.WriteLine();
    Console.WriteLine($"Prato mais caro: {pratoCaro} ({maxVal:C})");
    Console.WriteLine($"Faturamento (Entregues): {faturamentoReal:C}");
}

Console.WriteLine();
Console.WriteLine("=== TAREFA 7: BUSCAR PEDIDO ===");
Console.Write("Busque por nome: ");
string busca = Console.ReadLine() ?? "";

int indexBusca = nomesPratos.FindIndex(n => n.Equals(busca, StringComparison.OrdinalIgnoreCase));

if (indexBusca != -1)
{
    Console.WriteLine();
    Console.WriteLine($"ENCONTRADO: {nomesPratos[indexBusca]}");
    Console.WriteLine($"Categoria: {categorias[indexBusca]}");
    Console.WriteLine($"Status: {statusPedidos[indexBusca]}");
    Console.WriteLine($"Valor Final: {valoresFinais[indexBusca]:C}");

    Console.Write("Alterar status? (S/N): ");
    if (Console.ReadLine()?.ToUpper() == "S")
    {
        Console.Write("Novo Status (1-5): ");
        if (int.TryParse(Console.ReadLine(), out int novoSt) && Enum.IsDefined(typeof(StatusPedido), novoSt))
        {
            statusPedidos[indexBusca] = (StatusPedido)novoSt;
            Console.WriteLine($"Status alterado para {statusPedidos[indexBusca]}!");
        }
    }
}
else
{
    Console.WriteLine("Pedido não encontrado.");
}

Console.WriteLine();
Console.WriteLine("Fim do Programa.");
