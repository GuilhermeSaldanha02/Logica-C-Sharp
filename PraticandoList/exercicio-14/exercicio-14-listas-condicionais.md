# Exercício 14 - Listas com Condicionais e Validação de Input

## 🎯 Objetivos de Aprendizagem

- Combinar listas com estruturas condicionais (if/else)
- Validar entradas do usuário
- Manipular listas dinamicamente com base em condições
- Usar TryParse para conversões seguras

## 📝 Cenário

Você está desenvolvendo um sistema de gerenciamento de estoque para uma loja. O sistema precisa receber dados do usuário, validá-los e processar informações sobre produtos usando listas.

## 📋 Tarefas

### Tarefa 1: Sistema de Cadastro de Produtos com Validação

Crie um programa que permita ao usuário cadastrar produtos em uma lista.

**Entrada:**
- Toda entrada será solicitada via `Console.ReadLine()`
- Pergunte ao usuário quantos produtos deseja cadastrar
- Para cada produto, solicite: nome do produto e preço

**Processamento:**
1. Valide se a quantidade informada é um número válido
2. Crie uma lista para armazenar os nomes dos produtos
3. Crie uma lista para armazenar os preços
4. Para cada produto:
   - Valide se o nome não está vazio
   - Valide se o preço é um número válido
   - Se o preço for negativo ou zero, peça novamente
5. Após cadastrar todos, exiba a lista completa

### Tarefa 2: Análise Condicional de Preços

Usando as listas criadas na Tarefa 1:

1. Separe os produtos em três categorias baseado no preço:
   - Produtos Econômicos (até R$ 50)
   - Produtos Médios (de R$ 50,01 até R$ 150)
   - Produtos Premium (acima de R$ 150)
2. Crie três listas separadas para cada categoria
3. Exiba quantos produtos existem em cada categoria
4. Calcule o valor médio de cada categoria

### Tarefa 3: Sistema de Desconto Condicional

Ainda usando as listas anteriores:

1. Solicite ao usuário um percentual de desconto
2. Valide se o percentual está entre 0 e 100
3. Aplique o desconto APENAS aos produtos Premium (acima de R$ 150)
4. Produtos Econômicos e Médios não recebem desconto
5. Adicione todos os produtos com desconto a uma nova lista
6. Exiba o relatório com os produtos atualizados e o total economizado

### Tarefa 4: Busca e Remoção com Validação

1. Pergunte ao usuário qual produto deseja remover
2. Busque o produto na lista (use IndexOf ou Contains)
3. Se encontrar:
   - Exiba as informações do produto
   - Confirme se deseja realmente remover (S/N)
   - Se sim, remova o produto e seu preço das listas
4. Se não encontrar, exiba mensagem e pergunte se deseja tentar novamente
5. Exiba a lista atualizada

### Tarefa 5: Relatório Completo com Condicionais

Gere um relatório final que:

1. Liste todos os produtos restantes com seus preços
2. Identifique e marque:
   - O produto mais caro
   - O produto mais barato
   - Produtos com preço acima da média geral
3. Calcule e exiba:
   - Quantidade total de produtos
   - Valor total do estoque
   - Preço médio
   - Maior e menor preço
4. Se o valor total do estoque for maior que R$ 1000, exiba uma mensagem especial

### Tarefa 6: Filtro Avançado com Múltiplas Condições

Solicite ao usuário:
1. Um preço mínimo
2. Um preço máximo

Processamento:
1. Valide se mínimo é menor que máximo
2. Crie uma nova lista contendo apenas produtos dentro da faixa
3. Se nenhum produto for encontrado, informe ao usuário
4. Se encontrar produtos:
   - Exiba todos os produtos filtrados
   - Calcule o total desses produtos
   - Informe quantos % do estoque total isso representa

## 💡 Conceitos Importantes

### Validação de Input com TryParse

```csharp
string input = Console.ReadLine();
int numero;

if (int.TryParse(input, out numero))
{
    Console.WriteLine($"Número válido: {numero}");
}
else
{
    Console.WriteLine("Entrada inválida!");
}
```

### Listas Paralelas com Condicionais

```csharp
List<string> nomes = new List<string>();
List<decimal> precos = new List<decimal>();

for (int i = 0; i < nomes.Count; i++)
{
    if (precos[i] > 100)
    {
        Console.WriteLine($"{nomes[i]} é Premium!");
    }
}
```

### Adicionar em Listas Baseado em Condição

```csharp
List<string> produtosCaros = new List<string>();
List<decimal> precosCaros = new List<decimal>();

for (int i = 0; i < produtos.Count; i++)
{
    if (precos[i] > 100)
    {
        produtosCaros.Add(produtos[i]);
        precosCaros.Add(precos[i]);
    }
}
```

### Validação de String Vazia

```csharp
string nome = Console.ReadLine();

if (string.IsNullOrWhiteSpace(nome))
{
    Console.WriteLine("Nome inválido!");
}
```

## 📌 Dicas

- Sempre valide entradas do usuário antes de processar
- Use `TryParse` para conversões numéricas seguras
- Mantenha listas paralelas sincronizadas (mesmo índice = mesmo produto)
- Use Count para percorrer listas paralelas com for
- Verifique se uma lista está vazia antes de processar (`Count > 0`)
- Para encontrar máximo/mínimo, inicialize com o primeiro elemento da lista
- Use `.ToLower()` ou `.ToUpper()` para comparações de strings case-insensitive
- Sempre informe ao usuário quando uma operação foi bem-sucedida

## 🎓 Desafios Extras

1. **Ordenação**: Após validar todos os produtos, ordene-os por preço
2. **Duplicatas**: Antes de adicionar um produto, verifique se já existe na lista
3. **Limites**: Limite o cadastro a no máximo 20 produtos
4. **Edição**: Permita ao usuário editar o preço de um produto existente
5. **Exportação**: Crie um resumo formatado de todos os produtos

## 🔗 Navegação

- [← Exercício Anterior](exercicio-13-strings.md) - Strings
- [Próximo Exercício →](exercicio-15-listas-foreach-enum.md) - Listas com Foreach e Enum
