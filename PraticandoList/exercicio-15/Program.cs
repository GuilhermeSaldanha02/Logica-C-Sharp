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

    Console.WriteLine($"Pedido: {nomesPratos[i]} | Taxa: {taxa:P0} | Total: {total:C}");
}

Console.WriteLine();
Console.WriteLine("=== TAREFA 3: RESUMO POR STATUS ===");


int quantidadePendente = 0, quantidadePreparo = 0, quantidadePronto = 0, quantidadeEntregue = 0, quantidadeCancelado = 0;
double valPendente = 0, valPreparo = 0, valPronto = 0, valEntregue = 0, valCancelado = 0;

for (int i = 0; i < statusPedidos.Count; i++)
{
    double val = valoresFinais[i];
    switch (statusPedidos[i])
    {
        case StatusPedido.Pendente: quantidadePendente++; valPendente += val; break;
        case StatusPedido.EmPreparacao: quantidadePreparo++; valPreparo += val; break;
        case StatusPedido.Pronto: quantidadePronto++; valPronto += val; break;
        case StatusPedido.Entregue: quantidadeEntregue++; valEntregue += val; break;
        case StatusPedido.Cancelado: quantidadeCancelado++; valCancelado += val; break;
    }
}

Console.WriteLine($"Pendentes: {quantidadePendente} (Total: {valPendente:C})");
Console.WriteLine($"Em Preparo: {quantidadePreparo} (Total: {valPreparo:C})");
Console.WriteLine($"Prontos:    {quantidadePronto} (Total: {valPronto:C})");
Console.WriteLine($"Entregues:  {quantidadeEntregue} (Total: {valEntregue:C})");
Console.WriteLine($"Cancelados: {quantidadeCancelado} (Total: {valCancelado:C})");

Console.WriteLine();
Console.WriteLine("=== TAREFA 4: ATUALIZAÇÃO EM LOTE ===");
Console.WriteLine("Deseja atualizar status em massa? (S/N)");
if (Console.ReadLine()?.ToUpper() == "S")
{
    Console.Write("De (Status 1-5): ");
    int.TryParse(Console.ReadLine(), out int de);
    Console.Write("Para (Status 1-5): ");
    int.TryParse(Console.ReadLine(), out int para);

    if (Enum.IsDefined(typeof(StatusPedido), de) && Enum.IsDefined(typeof(StatusPedido), para))
    {
        var sDe = (StatusPedido)de;
        var sPara = (StatusPedido)para;
        int count = 0;

        for (int i = 0; i < statusPedidos.Count; i++)
        {
            if (statusPedidos[i] == sDe)
            {
                statusPedidos[i] = sPara;
                count++;
            }
        }
        Console.WriteLine($"{count} pedidos atualizados de {sDe} para {sPara}.");
    }
}

Console.WriteLine();
Console.WriteLine("=== TAREFA 5: RELATÓRIO POR CATEGORIA ===");
int tempoTotalGeral = 0;
CategoriaPrato? catMaisPedidos = null;
int maiorQtdCategoria = -1;


foreach (CategoriaPrato catTipo in Enum.GetValues(typeof(CategoriaPrato)))
{
    int qtdNessaCat = 0;
    double faturamentoCat = 0;
    int tempoCat = 0;

    for (int i = 0; i < categorias.Count; i++)
    {

        if (categorias[i] == catTipo && statusPedidos[i] != StatusPedido.Cancelado)
        {
            qtdNessaCat++;
            faturamentoCat += valoresFinais[i];

            tempoCat += catTipo switch
            {
                CategoriaPrato.Entrada => 15,
                CategoriaPrato.PratoPrincipal => 30,
                CategoriaPrato.Sobremesa => 20,
                CategoriaPrato.Bebida => 5,
                _ => 0
            };
        }
    }

    tempoTotalGeral += tempoCat;

    if (qtdNessaCat > 0)
    {
        Console.WriteLine($"Categoria: {catTipo} | Qtd: {qtdNessaCat} | Faturamento: {faturamentoCat:C} | Tempo: {tempoCat}min");
    }

    if (qtdNessaCat > maiorQtdCategoria)
    {
        maiorQtdCategoria = qtdNessaCat;
        catMaisPedidos = catTipo;
    }
}
Console.WriteLine($"Tempo Total Cozinha: {tempoTotalGeral} minutos");
Console.WriteLine($"Categoria mais popular: {catMaisPedidos}");


Console.WriteLine();
Console.WriteLine("=== TAREFA 6: DASHBOARD ===");
double faturamentoEntregues = 0;
int[] contadorStatus = new int[6];

for (int i = 0; i < statusPedidos.Count; i++)
{
    string acao = statusPedidos[i] switch
    {
        StatusPedido.Pendente => "Aguardando...",
        StatusPedido.EmPreparacao => "Cozinhando...",
        StatusPedido.Pronto => "Liberado!",
        StatusPedido.Entregue => "Finalizado.",
        StatusPedido.Cancelado => "X",
        _ => "?"
    };

    Console.WriteLine($"#{i + 1} {nomesPratos[i]} -> {statusPedidos[i]} ({acao})");


    int idxStatus = (int)statusPedidos[i];
    contadorStatus[idxStatus]++;

    if (statusPedidos[i] == StatusPedido.Cancelado) continue;

    if (statusPedidos[i] == StatusPedido.Entregue)
    {
        faturamentoEntregues += valoresFinais[i];
    }
}

if (valoresFinais.Count > 0)
{
    double maxVal = valoresFinais.Max();
    string pratoCaro = nomesPratos[valoresFinais.IndexOf(maxVal)];


    int maxStatusCount = 0;
    StatusPedido statusMaisFreq = StatusPedido.Pendente;
    for (int s = 1; s <= 5; s++)
    {
        if (contadorStatus[s] > maxStatusCount)
        {
            maxStatusCount = contadorStatus[s];
            statusMaisFreq = (StatusPedido)s;
        }
    }


    Console.WriteLine();
    Console.WriteLine("--- Estatísticas Finais ---");
    Console.WriteLine($"Prato mais caro: {pratoCaro} ({maxVal:C})");
    Console.WriteLine($"Faturamento (Entregues): {faturamentoEntregues:C}");
    Console.WriteLine($"Status com mais pedidos: {statusMaisFreq}");
}

Console.WriteLine();
Console.WriteLine("=== TAREFA 7: BUSCAR PEDIDO ===");
Console.Write("Busque por nome: ");
string busca = Console.ReadLine() ?? "";

int idx = nomesPratos.FindIndex(n => n.Equals(busca, StringComparison.OrdinalIgnoreCase));

if (idx != -1)
{
    Console.WriteLine($"Encontrado: {nomesPratos[idx]} | {categorias[idx]} | {statusPedidos[idx]} | {valoresFinais[idx]:C}");
    Console.Write("Alterar status? (S/N): ");
    if (Console.ReadLine()?.ToUpper() == "S")
    {
        Console.Write("Novo Status (1-5): ");
        if (int.TryParse(Console.ReadLine(), out int ns) && Enum.IsDefined(typeof(StatusPedido), ns))
        {
            statusPedidos[idx] = (StatusPedido)ns;
            Console.WriteLine("Status atualizado!");
        }
    }
}
else
{
    Console.WriteLine("Não encontrado.");
}

Console.WriteLine();
Console.WriteLine("Fim do Programa.");
Console.ReadKey();

public enum StatusPedido
{
    Pendente = 1,
    EmPreparacao = 2,
    Pronto = 3,
    Entregue = 4,
    Cancelado = 5
}

public enum CategoriaPrato
{
    Entrada = 1,
    PratoPrincipal = 2,
    Sobremesa = 3,
    Bebida = 4
}