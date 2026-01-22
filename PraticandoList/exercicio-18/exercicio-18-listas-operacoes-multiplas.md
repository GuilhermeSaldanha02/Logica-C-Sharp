# Exercício 18 - Listas com Operações Múltiplas (Add, Remove, Insert, Search)

## 🎯 Objetivos de Aprendizagem

- Dominar operações de adição em listas (Add, AddRange, Insert)
- Dominar operações de remoção (Remove, RemoveAt, RemoveAll, Clear)
- Usar operações de busca (Contains, IndexOf, FindIndex)
- Combinar múltiplas operações em sequências complexas

## 📝 Cenário

Você está criando um sistema de gerenciamento de inventário dinâmico que precisa adicionar, remover, buscar e reorganizar produtos constantemente.

## 📋 Tarefas

### Tarefa 1: Operações Básicas de Adição

Crie um sistema de inventário inicial:

**Entrada:**
1. Pergunte quantos produtos deseja adicionar inicialmente
2. Para cada produto solicite: nome e quantidade em estoque

**Processamento:**
1. Crie listas para nomes e quantidades
2. Use Add para adicionar cada produto
3. Após adicionar 3 produtos, use Insert para adicionar um produto urgente na posição 0 (primeiro da lista)
4. Pergunte se deseja adicionar produtos em lote
5. Se sim, solicite vários nomes separados por vírgula
6. Use Split para separar os nomes
7. Use AddRange para adicionar todos de uma vez
8. Exiba a lista final com as posições

### Tarefa 2: Operações Múltiplas de Remoção

Usando a lista da Tarefa 1:

**Processamento:**
1. Solicite um nome de produto para remover
2. Use IndexOf para encontrar a posição
3. Se encontrar:
   - Use RemoveAt para remover pela posição
   - Remova também a quantidade correspondente
4. Solicite uma posição específica para remover
5. Valide se a posição existe
6. Use RemoveAt para remover pela posição
7. Pergunte se deseja limpar produtos com estoque zero
8. Se sim, use um loop for reverso (do final para o início) para remover
9. Exiba quantos produtos foram removidos
10. Pergunte se deseja limpar toda a lista
11. Se sim, use Clear

### Tarefa 3: Busca e Manipulação Avançada

Crie um sistema de busca complexo:

**Entrada:**
1. Solicite um termo de busca

**Processamento:**
1. Use Contains para verificar se existe
2. Se existir, mostre a posição com IndexOf
3. Crie uma lista temporária com todos os produtos que contêm o termo (não apenas igual)
4. Use for para percorrer e adicionar matches à lista temporária
5. Exiba quantas correspondências foram encontradas
6. Para cada correspondência:
   - Exiba nome, posição original e quantidade
   - Pergunte se deseja remover este item
   - Se sim, marque para remoção
7. Após revisar todos, remova os marcados (use for reverso para não afetar índices)

### Tarefa 4: Inserção em Posições Específicas

**Entrada:**
1. Solicite nome do produto para adicionar
2. Solicite quantidade
3. Pergunte em qual posição inserir (ou deixar em branco para adicionar no final)

**Processamento:**
1. Se posição não for fornecida, use Add
2. Se posição for fornecida:
   - Valide se está entre 0 e Count
   - Use Insert para inserir na posição exata
   - Mantenha sincronizadas as listas de nomes e quantidades
3. Pergunte se deseja reorganizar algum produto
4. Se sim:
   - Solicite o nome do produto
   - Encontre sua posição atual
   - Solicite a nova posição
   - Use RemoveAt na posição antiga
   - Use Insert na nova posição
5. Exiba a lista reordenada

### Tarefa 5: Operações em Lote

Crie funcionalidades para operações em massa:

**Entrada:**
1. Pergunte qual operação em lote deseja realizar:
   - 1: Adicionar múltiplos produtos
   - 2: Remover múltiplos produtos
   - 3: Atualizar múltiplas quantidades
   - 4: Duplicar produtos selecionados

**Processamento para cada opção:**

**Opção 1 - Adicionar múltiplos:**
1. Solicite nomes separados por vírgula
2. Use Split para criar array
3. Para cada nome, solicite quantidade
4. Use AddRange ou loop com Add para adicionar todos

**Opção 2 - Remover múltiplos:**
1. Solicite nomes separados por vírgula
2. Para cada nome:
   - Busque com IndexOf
   - Se encontrar, marque para remoção
3. Use for reverso para remover todos marcados
4. Informe quantos foram removidos

**Opção 3 - Atualizar múltiplas quantidades:**
1. Solicite um critério (todos, estoque baixo, etc)
2. Solicite o valor a adicionar ou subtrair
3. Use for para percorrer e atualizar
4. Exiba relatório de atualizações

**Opção 4 - Duplicar selecionados:**
1. Solicite nomes para duplicar
2. Para cada nome encontrado:
   - Encontre o índice
   - Use Insert para adicionar cópia logo após o original
3. Exiba lista com duplicados marcados

### Tarefa 6: Sistema Completo de Gerenciamento

Crie um menu completo com todas as operações:

**Menu:**
1. Adicionar produto (final)
2. Adicionar produto (posição específica)
3. Adicionar produtos em lote
4. Remover produto por nome
5. Remover produto por posição
6. Remover produtos com estoque zero
7. Limpar toda lista
8. Buscar produto
9. Listar todos produtos
10. Reorganizar produto
11. Sair

**Processamento:**
- Implemente todas as operações solicitadas no menu
- Use while para manter menu ativo
- Para cada operação, valide todas as entradas
- Após cada operação, exiba resumo do que foi feito
- Mantenha contador de operações realizadas
- Exiba estatística final ao sair

### Tarefa 7: Operações Avançadas com Condições

Implemente operações condicionais complexas:

**Processamento:**
1. Pergunte um valor de estoque mínimo
2. Use Contains e Count para identificar quantos produtos estão abaixo do mínimo
3. Crie lista temporária com produtos em estoque baixo
4. Para cada produto em estoque baixo:
   - Adicione à lista de "reabastecer"
   - Calcule quantidade recomendada (ex: mínimo × 2)
5. Pergunte se deseja remover produtos duplicados (mesmo nome)
6. Se sim:
   - Use for para encontrar duplicatas
   - Use Contains em lista auxiliar para marcar já processados
   - Mantenha apenas a primeira ocorrência
   - Use RemoveAt para remover duplicatas
7. Implemente função de merge:
   - Solicite nova lista de produtos
   - Use AddRange para adicionar
   - Remova duplicatas mantendo maiores quantidades
8. Exiba relatório completo

## 💡 Conceitos Importantes

### Adicionar Elementos

```csharp
List<string> lista = new List<string>();

// Adicionar no final
lista.Add("Item 1");

// Adicionar vários de uma vez
lista.AddRange(new[] { "Item 2", "Item 3" });

// Adicionar em posição específica
lista.Insert(0, "Primeiro");  // Insere no início
lista.Insert(2, "No meio");   // Insere na posição 2
```

### Remover Elementos

```csharp
List<string> lista = new List<string> { "A", "B", "C", "D" };

// Remover por valor (primeira ocorrência)
lista.Remove("B");

// Remover por índice
lista.RemoveAt(0);

// Limpar tudo
lista.Clear();

// Remover do final para o início (não afeta índices)
for (int i = lista.Count - 1; i >= 0; i--)
{
    if (condicao)
    {
        lista.RemoveAt(i);
    }
}
```

### Buscar Elementos

```csharp
List<string> produtos = new List<string> { "Arroz", "Feijão", "Óleo" };

// Verificar se existe
bool existe = produtos.Contains("Arroz");  // true

// Encontrar posição
int posicao = produtos.IndexOf("Feijão");  // 1
int naoExiste = produtos.IndexOf("Café");  // -1

// Buscar com critério (case-insensitive)
string busca = "arroz".ToLower();
for (int i = 0; i < produtos.Count; i++)
{
    if (produtos[i].ToLower().Contains(busca))
    {
        Console.WriteLine($"Encontrado na posição {i}");
    }
}
```

### Reorganizar com Insert e RemoveAt

```csharp
List<string> lista = new List<string> { "A", "B", "C", "D" };

// Mover "C" (índice 2) para o início (índice 0)
string item = lista[2];
lista.RemoveAt(2);      // Remove de onde está
lista.Insert(0, item);  // Insere na nova posição
// Resultado: "C", "A", "B", "D"
```

### Split e AddRange

```csharp
string entrada = "Arroz, Feijão, Óleo";
string[] itens = entrada.Split(',');

// Limpar espaços de cada item
for (int i = 0; i < itens.Length; i++)
{
    itens[i] = itens[i].Trim();
}

List<string> lista = new List<string>();
lista.AddRange(itens);
```

### Listas Paralelas Sincronizadas

```csharp
List<string> nomes = new List<string> { "A", "B", "C" };
List<int> quantidades = new List<int> { 10, 20, 30 };

// Remover mantendo sincronia
int indice = 1;
nomes.RemoveAt(indice);
quantidades.RemoveAt(indice);

// Inserir mantendo sincronia
nomes.Insert(0, "Novo");
quantidades.Insert(0, 100);
```

## 📌 Dicas

- `Add` adiciona no final, `Insert` adiciona em posição específica
- `Remove` procura o valor, `RemoveAt` usa o índice
- `IndexOf` retorna -1 quando não encontra
- Para remover múltiplos itens, sempre vá do final para o início
- Use `Clear()` para remover todos os elementos de uma vez
- Valide índices antes de usar: `if (i >= 0 && i < lista.Count)`
- `Contains` é mais rápido que `IndexOf >= 0` para verificar existência
- Mantenha listas paralelas SEMPRE com mesmo Count
- Use listas temporárias para operações complexas
- `AddRange` é mais eficiente que múltiplos `Add`

## 🎓 Desafios Extras

1. **Desfazer**: Implemente funcionalidade de desfazer última operação
2. **Ordenação**: Ordene produtos por nome ou quantidade
3. **Paginação**: Exiba lista em páginas de 5 itens
4. **Filtros Múltiplos**: Combine múltiplos critérios de busca
5. **Backup Automático**: Antes de Clear ou remoções em massa, faça backup

## 🔗 Navegação

- [← Exercício Anterior](exercicio-17-listas-for-conversoes.md) - Listas com For e Conversões
- [Próximo Exercício →](exercicio-19-listas-arrays-filtros.md) - Listas com Arrays e Filtros
