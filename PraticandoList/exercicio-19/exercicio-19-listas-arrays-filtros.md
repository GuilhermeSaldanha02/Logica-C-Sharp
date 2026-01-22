# Exercício 19 - Listas, Arrays e Filtros Complexos

## 🎯 Objetivos de Aprendizagem

- Converter entre arrays e listas
- Aplicar filtros complexos em listas
- Combinar múltiplas estruturas de dados
- Implementar algoritmos de processamento avançado

## 📝 Cenário

Você está desenvolvendo um sistema de análise de dados de vendas que precisa converter entre diferentes estruturas, aplicar múltiplos filtros e gerar relatórios complexos.

## 📋 Tarefas

### Tarefa 1: Conversão Array para Lista e Vice-Versa

Crie um sistema que trabalha com ambas estruturas:

**Entrada:**
1. Pergunte quantos produtos iniciais cadastrar
2. Solicite nome e preço de cada produto

**Processamento:**
1. Armazene inicialmente em arrays paralelos de tamanho fixo
2. Quando os arrays estiverem cheios, converta para listas:
   - Use `new List<tipo>(array)` para converter
   - Ou use `array.ToList()` (precisa de using System.Linq)
3. Adicione mais 5 produtos às listas (que podem crescer)
4. Quando precisar fazer operações em lote, converta lista de volta para array:
   - Use `lista.ToArray()`
5. Exiba comparativo:
   - Tamanho do array original (Length)
   - Quantidade de elementos na lista (Count)
   - Elementos adicionados após conversão

### Tarefa 2: Filtros Simples em Sequência

Usando as listas criadas:

**Processamento:**
1. Crie primeira lista filtrada: apenas produtos com preço acima de R$ 50
2. A partir da primeira, crie segunda lista filtrada: apenas produtos com nome maior que 5 caracteres
3. A partir da segunda, crie terceira lista filtrada: apenas produtos com preço par (use módulo)
4. Para cada etapa de filtragem:
   - Exiba quantos itens foram removidos
   - Exiba quantos restaram
   - Calcule percentual que passou no filtro
5. Exiba as três listas filtradas lado a lado

### Tarefa 3: Filtros com Múltiplas Condições

Implemente sistema de filtros combinados:

**Entrada:**
1. Pergunte quais filtros aplicar (permitir múltiplos):
   - Filtro por preço mínimo (S/N)
   - Filtro por preço máximo (S/N)
   - Filtro por nome contém texto (S/N)
   - Filtro por tamanho do nome (S/N)

**Processamento:**
1. Para cada filtro ativo, solicite os parâmetros
2. Crie lista resultado começando com todos os produtos
3. Para cada filtro ativo:
   - Crie lista temporária vazia
   - Use for ou foreach para percorrer lista resultado atual
   - Adicione à lista temporária apenas itens que passam no filtro
   - Substitua lista resultado pela temporária
4. Exiba quantos produtos passaram por todos os filtros
5. Exiba lista final filtrada
6. Calcule estatísticas dos produtos filtrados

### Tarefa 4: Operações com Arrays Paralelos e Conversão

Crie sistema que migra de arrays para listas:

**Processamento:**
1. Comece com arrays paralelos:

```csharp
string[] produtos = { "Notebook", "Mouse", "Teclado", "Monitor" };
decimal[] precos = { 2500.00m, 45.00m, 120.00m, 800.00m };
int[] estoque = { 10, 50, 30, 15 };
bool[] disponivel = { true, true, false, true };
```

2. Converta todos os arrays para listas
3. Solicite operações do usuário:
   - Adicionar novo produto (adiciona em todas as listas)
   - Remover produto indisponível (disponivel = false)
   - Atualizar estoque de produtos específicos
4. Após cada operação, mantenha listas sincronizadas
5 Ao final, converta listas de volta para arrays
6. Exiba arrays finais

### Tarefa 5: Sistema de Relatórios com Filtros Avançados

**Entrada:**
1. Solicite múltiplos critérios de relatório:
   - Agrupar por faixa de preço (S/N)
   - Filtrar por disponibilidade (S/N)
   - Ordenar por algum critério (S/N)

**Processamento:**

**Se agrupar por faixa de preço:**
1. Defina faixas: 0-100, 101-500, 501-1000, 1001+
2. Crie 4 listas separadas
3. Use for para percorrer produtos e distribuir em listas de faixa
4. Para cada faixa, calcule:
   - Quantidade de produtos
   - Valor total
   - Valor médio
   - Produto mais caro e mais barato da faixa

**Se filtrar por disponibilidade:**
1. Crie duas listas: disponíveis e indisponíveis
2. Separe os produtos
3. Exiba estatísticas de cada grupo

**Se ordenar:**
1. Implemente ordenação manual (bubble sort simples):
   - Use dois loops for aninhados
   - Compare elementos adjacentes
   - Troque se estiver fora de ordem
   - Mantenha todas as listas paralelas sincronizadas na troca
2. Exiba lista ordenada

### Tarefa 6: Merge e Deduplicate

Simule integração de dados de múltiplas fontes:

**Processamento:**
1. Crie primeira lista de produtos (Sistema A)
2. Crie segunda lista de produtos (Sistema B) - pode ter duplicados
3. Converta ambas para listas
4. Implemente merge:
   - Crie lista resultado
   - Adicione todos de Sistema A
   - Para cada produto de Sistema B:
     - Verifique se já existe na lista resultado (use Contains ou IndexOf)
     - Se não existir, adicione
     - Se existir, compare preços e mantenha o menor
5. Exiba:
   - Total de produtos no Sistema A
   - Total de produtos no Sistema B
   - Total após merge (sem duplicados)
   - Quantos duplicados foram encontrados
6. Crie lista somente com duplicados encontrados

### Tarefa 7: Pipeline de Transformação

Implemente processamento em etapas:

**Entrada:**
1. Solicite dados de produtos via input

**Processamento - Pipeline:**

**Etapa 1 - Input e Conversão:**
- Receba como strings
- Converta para tipos corretos
- Armazene em array inicial

**Etapa 2 - Array para Lista:**
- Converta array para lista
- Valide dados (remova inválidos)

**Etapa 3 - Filtro de Qualidade:**
- Remova produtos com preço zero
- Remova produtos com nome vazio ou muito curto

**Etapa 4 - Enriquecimento:**
- Para cada produto, calcule:
  - Margem de lucro (30%)
  - Preço com imposto (adicione 20%)
  - Categoria baseada em preço
- Armazene em novas listas

**Etapa 5 - Agregação:**
- Agrupe produtos por categoria
- Calcule totais por categoria
- Crie listas separadas para cada categoria

**Etapa 6 - Exportação:**
- Converta listas finais para arrays
- Prepare formato de saída
- Exiba relatório completo

Para cada etapa:
- Exiba quantos itens foram processados
- Exiba quantos itens foram removidos/modificados
- Exiba tempo aproximado (simule com contador)

### Tarefa 8: Sistema Completo de Análise

Crie análise integrada combinando tudo:

**Entrada:**
1. Carregue dados iniciais (simule com arrays predefinidos ou input)
2. Solicite operações a realizar

**Operações disponíveis:**
1. Adicionar produtos em lote (input via string, split, conversão, adiciona em listas)
2. Aplicar filtros múltiplos (cria listas filtradas)
3. Converter estruturas (lista ↔ array)
4. Ordenar dados (implemente ordenação mantendo sincronia)
5. Agrupar por critérios (cria múltiplas listas agrupadas)
6. Mesclar com outra fonte (merge e deduplicate)
7. Gerar relatórios (estatísticas de listas filtradas)
8. Exportar dados (converte para formato final)

**Implementação:**
- Use menu com while
- Para cada operação:
  - Valide todas entradas
  - Mantenha histórico de operações em uma lista
  - Exiba progresso
  - Permita desfazer (volte ao estado anterior usando backup de listas)
- Exiba estatísticas finais:
  - Total de operações realizadas
  - Total de produtos processados
  - Transformações aplicadas
  - Listas criadas

## 💡 Conceitos Importantes

### Converter Array para Lista

```csharp
// Opção 1: Construtor
string[] array = { "A", "B", "C" };
List<string> lista = new List<string>(array);

// Opção 2: ToList() (precisa using System.Linq)
// List<string> lista = array.ToList();
```

### Converter Lista para Array

```csharp
List<string> lista = new List<string> { "A", "B", "C" };
string[] array = lista.ToArray();
```

### Filtrar Lista

```csharp
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> pares = new List<int>();

foreach (int num in numeros)
{
    if (num % 2 == 0)
    {
        pares.Add(num);
    }
}
```

### Filtros em Sequência

```csharp
List<decimal> precos = new List<decimal> { 10.0m, 50.0m, 100.0m, 150.0m };

// Filtro 1: maior que 50
List<decimal> filtro1 = new List<decimal>();
foreach (decimal p in precos)
{
    if (p > 50) filtro1.Add(p);
}

// Filtro 2: menor que 200 (aplicado em filtro1)
List<decimal> filtro2 = new List<decimal>();
foreach (decimal p in filtro1)
{
    if (p < 200) filtro2.Add(p);
}
```

### Remover Duplicatas

```csharp
List<string> comDuplicatas = new List<string> { "A", "B", "A", "C", "B" };
List<string> semDuplicatas = new List<string>();

foreach (string item in comDuplicatas)
{
    if (!semDuplicatas.Contains(item))
    {
        semDuplicatas.Add(item);
    }
}
```

### Ordenação Simples (Bubble Sort com Listas Paralelas)

```csharp
List<string> nomes = new List<string> { "Carlos", "Ana", "Bruno" };
List<int> idades = new List<int> { 30, 25, 28 };

// Ordenar por nome (mantendo sincronia)
for (int i = 0; i < nomes.Count - 1; i++)
{
    for (int j = 0; j < nomes.Count - 1 - i; j++)
    {
        if (string.Compare(nomes[j], nomes[j + 1]) > 0)
        {
            // Troca nomes
            string tempNome = nomes[j];
            nomes[j] = nomes[j + 1];
            nomes[j + 1] = tempNome;
            
            // Troca idades (mantém sincronia)
            int tempIdade = idades[j];
            idades[j] = idades[j + 1];
            idades[j + 1] = tempIdade;
        }
    }
}
```

## 📌 Dicas

- Arrays têm tamanho fixo (Length), listas crescem dinamicamente (Count)
- Use listas para dados que mudam de tamanho frequentemente
- Use arrays para dados fixos ou performance crítica
- `ToArray()` e construtor `new List<T>(array)` fazem cópias, não referências
- Filtros em sequência reduzem gradualmente a quantidade de dados
- Sempre inicialize lista vazia antes de filtrar
- Para remover duplicatas de listas grandes, considere usar HashSet
- Ao ordenar listas paralelas, troque elementos de TODAS as listas
- `Contains` em listas é O(n), pode ser lento para muitos elementos
- Use for reverso ao remover elementos durante iteração

## 🎓 Desafios Extras

1. **Intersecção**: Encontre produtos que existem em duas listas diferentes
2. **União**: Combine duas listas removendo duplicados
3. **Diferença**: Encontre produtos que estão em A mas não em B
4. **Particionamento**: Divida lista em N partes iguais
5. **Amostragem**: Selecione elementos aleatórios da lista

## 🔗 Navegação

- [← Exercício Anterior](exercicio-18-listas-operacoes-multiplas.md) - Listas com Operações Múltiplas
- [🏠 Voltar ao Início](../README.md)
