# Exercício 15 - Listas com Foreach, Switch e Enum

## 🎯 Objetivos de Aprendizagem

- Combinar listas com foreach para iteração
- Usar switch/switch expression com listas
- Integrar Enum com listas para categorização
- Processar múltiplas listas relacionadas

## 📝 Cenário

Você está criando um sistema de gerenciamento de pedidos para um restaurante. Cada pedido tem um status e uma categoria, e você precisa processar esses pedidos usando listas.

## 📋 Tarefas

### Tarefa 1: Sistema de Pedidos com Enum

Defina os seguintes enums:

```csharp
enum StatusPedido
{
    Pendente = 1,
    EmPreparacao = 2,
    Pronto = 3,
    Entregue = 4,
    Cancelado = 5
}

enum CategoriaPrato
{
    Entrada = 1,
    PratoPrincipal = 2,
    Sobremesa = 3,
    Bebida = 4
}
```

**Entrada:**
1. Pergunte quantos pedidos o usuário deseja registrar
2. Para cada pedido, solicite via input:
   - Nome do prato
   - Valor do pedido
   - Categoria (número de 1 a 4)
   - Status (número de 1 a 5)

**Processamento:**
1. Crie listas para armazenar: nomes, valores, categorias e status
2. Valide todas as entradas
3. Armazene os dados nas listas correspondentes
4. Exiba todos os pedidos cadastrados

### Tarefa 2: Processamento com Foreach e Switch

Use foreach para percorrer todos os pedidos e:

1. Para cada categoria, use switch para aplicar uma taxa de serviço diferente:
   - Entrada: 5%
   - Prato Principal: 10%
   - Sobremesa: 7%
   - Bebida: 3%
2. Calcule o valor final de cada pedido (valor + taxa)
3. Armazene os valores finais em uma nova lista
4. Exiba o relatório com todos os pedidos e suas taxas

### Tarefa 3: Filtragem por Status

Use foreach com switch para processar pedidos baseado no status:

1. Percorra todos os pedidos
2. Use switch para categorizar cada pedido pelo status
3. Crie listas separadas para cada status
4. Conte quantos pedidos existem em cada status
5. Calcule o valor total de pedidos em cada status
6. Exiba um resumo completo

### Tarefa 4: Atualização de Status em Lote

Solicite ao usuário:
1. Qual status atual deseja atualizar (via input)
2. Para qual novo status deseja alterar

Processamento:
1. Valide se os status informados são válidos (1 a 5)
2. Use foreach com índice para encontrar todos os pedidos com o status atual
3. Atualize o status desses pedidos
4. Informe quantos pedidos foram atualizados
5. Exiba a lista atualizada com os novos status

### Tarefa 5: Relatório por Categoria com Switch Expression

Para cada categoria:

1. Use switch expression para definir um tempo médio de preparo:
   - Entrada: 15 minutos
   - Prato Principal: 30 minutos
   - Sobremesa: 20 minutos
   - Bebida: 5 minutos

2. Calcule o tempo total de preparo de todos os pedidos da categoria
3. Exiba apenas as categorias que têm pedidos
4. Informe qual categoria tem mais pedidos
5. Calcule o faturamento total por categoria

### Tarefa 6: Sistema Completo de Análise

Crie uma análise completa que:

1. Use foreach para percorrer todos os pedidos
2. Para cada pedido, use switch no status para determinar uma ação:
   - Pendente: "Aguardando processamento"
   - EmPreparacao: "Na cozinha"
   - Pronto: "Disponível para retirada"
   - Entregue: "Finalizado"
   - Cancelado: "Não processar"
3. Ignore (continue) pedidos cancelados nos cálculos
4. Calcule:
   - Total de pedidos ativos (não cancelados)
   - Faturamento total de pedidos entregues
   - Quantidade de pedidos em cada etapa do processo
5. Identifique e exiba:
   - O prato mais caro
   - A categoria com maior faturamento
   - O status com mais pedidos

### Tarefa 7: Busca e Modificação Interativa

Solicite ao usuário:
1. Nome de um prato para buscar

Processamento:
1. Use foreach para procurar o prato
2. Se encontrar:
   - Exiba todas as informações do pedido
   - Use switch para exibir descrição do status
   - Use switch para exibir descrição da categoria
   - Pergunte se deseja alterar o status
   - Se sim, solicite o novo status e atualize
3. Se não encontrar, informe e pergunte se deseja tentar novamente
4. Exiba a lista atualizada

## 💡 Conceitos Importantes

### Enum em Listas

```csharp
enum Status { Ativo = 1, Inativo = 2 }

List<Status> listaStatus = new List<Status>();
listaStatus.Add(Status.Ativo);
listaStatus.Add(Status.Inativo);

foreach (Status s in listaStatus)
{
    Console.WriteLine(s);  // Exibe: Ativo, Inativo
}
```

### Switch com Enum

```csharp
foreach (var status in listaStatus)
{
    switch (status)
    {
        case Status.Ativo:
            Console.WriteLine("Item está ativo");
            break;
        case Status.Inativo:
            Console.WriteLine("Item está inativo");
            break;
    }
}
```

### Switch Expression com Enum

```csharp
string descricao = status switch
{
    Status.Ativo => "Em operação",
    Status.Inativo => "Fora de operação",
    _ => "Desconhecido"
};
```

### Converter Input para Enum

```csharp
Console.Write("Digite o status (1-Ativo, 2-Inativo): ");
string input = Console.ReadLine();

if (int.TryParse(input, out int valor))
{
    if (Enum.IsDefined(typeof(Status), valor))
    {
        Status status = (Status)valor;
        listaStatus.Add(status);
    }
}
```

### Foreach com Índice

```csharp
int indice = 0;
foreach (var item in lista)
{
    Console.WriteLine($"Posição {indice}: {item}");
    indice++;
}

// OU usar for quando precisar modificar
for (int i = 0; i < lista.Count; i++)
{
    lista[i] = novoValor;  // Pode modificar
}
```

## 📌 Dicas

- Enum torna o código mais legível que usar números mágicos
- Use `Enum.IsDefined()` para validar se um valor é válido para o Enum
- Switch expression é mais conciso que switch tradicional
- Foreach é ideal para leitura, mas use for quando precisar modificar a lista
- Combine `continue` com switch para pular categorias específicas
- Mantenha listas paralelas sincronizadas (mesmo índice = mesmos dados)
- Use `Count` das listas para validar antes de acessar elementos
- Converta Enum para int com `(int)meuEnum` e de int para Enum com `(MeuEnum)numero`

## 🎓 Desafios Extras

1. **Priorização**: Crie um Enum de prioridade e ordene pedidos por prioridade
2. **Histórico**: Mantenha uma lista de mudanças de status de cada pedido
3. **Estatísticas**: Calcule tempo médio por status usando os tempos de preparo
4. **Validação**: Não permita mudar de "Entregue" para outro status
5. **Relatório Formatado**: Exiba os pedidos agrupados por categoria e status

## 🔗 Navegação

- [← Exercício Anterior](exercicio-14-listas-condicionais.md) - Listas com Condicionais
- [Próximo Exercício →](exercicio-16-listas-while-strings.md) - Listas com While e Strings
