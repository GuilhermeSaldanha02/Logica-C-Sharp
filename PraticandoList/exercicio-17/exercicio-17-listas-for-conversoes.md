# Exercício 17 - Listas com For e Conversão de Tipos

## 🎯 Objetivos de Aprendizagem

- Combinar listas com loop for
- Converter tipos de dados com TryParse
- Manipular índices de listas
- Processar dados numéricos em listas

## 📝 Cenário

Você está desenvolvendo um sistema de análise de vendas que recebe dados via input do usuário, converte e processa esses dados usando listas com loops for.

## 📋 Tarefas

### Tarefa 1: Conversão e Validação de Dados Numéricos

Crie um sistema que processa dados de vendas:

**Entrada:**
1. Pergunte quantas vendas foram realizadas
2. Para cada venda, solicite via input (tudo como string):
   - Identificador da venda (número)
   - Valor da venda (decimal)
   - Quantidade de itens (inteiro)
   - Desconto em percentual (decimal)

**Processamento:**
1. Crie listas para armazenar os dados convertidos
2. Use for para processar cada venda
3. Para cada dado, use TryParse para converter:
   - ID para int
   - Valor para decimal
   - Quantidade para int
   - Desconto para decimal
4. Se alguma conversão falhar, solicite novamente
5. Valide se os valores são positivos
6. Armazene todos os dados nas listas
7. Exiba todas as vendas cadastradas

### Tarefa 2: Cálculos com Índices Específicos

Usando as listas da Tarefa 1:

**Processamento:**
1. Use for com índice para processar cada venda
2. Para cada venda (usando o índice):
   - Calcule o subtotal (valor × quantidade)
   - Calcule o valor do desconto
   - Calcule o total final
   - Armazene em novas listas
3. Exiba uma tabela formatada com todos os cálculos
4. Use o índice para referenciar todas as listas paralelas

### Tarefa 3: Análise de Faixas com For

**Entrada:**
1. Solicite um valor mínimo e um valor máximo (como strings)
2. Converta para decimal com validação

**Processamento:**
1. Use for para percorrer a lista de valores totais
2. Crie três novas listas para separar vendas em faixas:
   - Abaixo do mínimo
   - Dentro da faixa (entre mínimo e máximo)
   - Acima do máximo
3. Para cada venda, use o índice para copiar todos os dados relacionados
4. Calcule estatísticas de cada faixa:
   - Quantidade de vendas
   - Valor total
   - Valor médio
5. Exiba relatórios separados para cada faixa

### Tarefa 4: Atualização de Valores por Índice

**Entrada:**
1. Pergunte qual venda deseja atualizar (número do ID ou posição)
2. Converta a entrada para inteiro
3. Solicite novo valor e novo desconto

**Processamento:**
1. Valide se o índice existe na lista
2. Use for para encontrar a venda pelo ID
3. Quando encontrar, armazene o índice
4. Converta os novos valores com TryParse
5. Atualize apenas os índices específicos nas listas correspondentes
6. Recalcule os totais apenas para essa venda
7. Exiba os dados antes e depois da atualização

### Tarefa 5: Conversão de Tipos e Operações Matemáticas

Crie um sistema de análise estatística:

**Entrada:**
1. Pergunte quantas amostras de dados deseja processar
2. Solicite cada amostra como string

**Processamento:**
1. Crie uma lista de decimais
2. Use for para processar cada entrada
3. Tente converter com TryParse
4. Se a conversão falhar:
   - Tente remover símbolos (R$, %, etc.)
   - Tente trocar vírgula por ponto
   - Tente converter novamente
5. Adicione à lista apenas valores válidos
6. Use for para calcular:
   - Soma total
   - Média aritmética
   - Valor máximo e sua posição
   - Valor mínimo e sua posição
   - Quantidade de valores acima da média
7. Exiba um relatório completo

### Tarefa 6: Manipulação Avançada com Múltiplas Conversões

Crie um sistema que processa dados de funcionários:

**Entrada:**
1. Pergunte quantos funcionários cadastrar
2. Para cada funcionário solicite (tudo como string):
   - Nome
   - Idade
   - Salário
   - Anos de empresa
   - Tem cargo de chefia (true/false)

**Processamento:**
1. Crie listas tipadas para cada dado
2. Use for para processar cada funcionário
3. Converta os dados:
   - Nome: string (validar se não está vazio)
   - Idade: int (validar entre 18 e 100)
   - Salário: decimal (validar se é positivo)
   - Anos: int (validar se não é negativo)
   - Chefia: bool (converter com TryParse ou Convert.ToBoolean)
4. Para funcionários com chefia = true, adicione 20% ao salário
5. Para cada ano de empresa, adicione 2% ao salário
6. Armazene os salários finais em uma nova lista

### Tarefa 7: Relatório Integrado com Conversões

**Processamento:**
1. Use for para percorrer todas as listas de funcionários
2. Para cada funcionário (usando índice):
   - Calcule o salário anual (salário × 12)
   - Calcule 13º salário
   - Calcule férias (salário + 33%)
   - Calcule custo total anual por funcionário
3. Crie listas para armazenar todos os cálculos
4. Use for para criar um ranking:
   - Ordene por salário (crie uma lista de índices ordenados)
   - Exiba do maior para o menor salário
5. Exiba estatísticas gerais:
   - Total de folha de pagamento mensal
   - Total de folha de pagamento anual
   - Média salarial
   - Diferença entre maior e menor salário
   - Percentual de gestores (chefes)
6. Para cada estatística, exiba o valor formatado

### Tarefa 8: Conversão e Filtragem Combinadas

**Entrada:**
1. Solicite uma idade mínima para filtrar
2. Solicite um salário mínimo para filtrar

**Processamento:**
1. Converta os filtros com validação
2. Use for para percorrer os funcionários
3. Crie listas filtradas contendo apenas funcionários que atendem AMBOS os critérios
4. Para cada funcionário filtrado, armazene todos os seus dados
5. Use for para processar a lista filtrada:
   - Calcule aumento de 10% para todos
   - Converta o salário para outras moedas (simule taxas de conversão)
   - Armazene em novas listas
6. Exiba comparativo antes/depois

## 💡 Conceitos Importantes

### TryParse com Listas

```csharp
List<decimal> valores = new List<decimal>();
string input = Console.ReadLine();

if (decimal.TryParse(input, out decimal valor))
{
    valores.Add(valor);
}
else
{
    Console.WriteLine("Valor inválido!");
}
```

### For com Múltiplas Listas Paralelas

```csharp
List<string> nomes = new List<string>();
List<decimal> salarios = new List<decimal>();

for (int i = 0; i < nomes.Count; i++)
{
    Console.WriteLine($"{nomes[i]}: R$ {salarios[i]:F2}");
}
```

### Atualizar Valor em Índice Específico

```csharp
List<decimal> precos = new List<decimal> { 10.0m, 20.0m, 30.0m };

int indice = 1;
precos[indice] = 25.0m;  // Altera 20.0 para 25.0
```

### Converter Bool de String

```csharp
string input = "true";
bool resultado;

// Opção 1: TryParse
if (bool.TryParse(input, out resultado))
{
    Console.WriteLine(resultado);
}

// Opção 2: Convert
try
{
    resultado = Convert.ToBoolean(input);
}
catch
{
    Console.WriteLine("Conversão falhou");
}
```

### Filtrar com For e Criar Nova Lista

```csharp
List<int> numeros = new List<int> { 1, 5, 10, 15, 20 };
List<int> maioresQueDez = new List<int>();

for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] > 10)
    {
        maioresQueDez.Add(numeros[i]);
    }
}
```

### Encontrar Índice do Maior Valor

```csharp
List<decimal> valores = new List<decimal> { 10.5m, 25.0m, 15.8m };
decimal maior = valores[0];
int indiceMaior = 0;

for (int i = 1; i < valores.Count; i++)
{
    if (valores[i] > maior)
    {
        maior = valores[i];
        indiceMaior = i;
    }
}

Console.WriteLine($"Maior valor: {maior} no índice {indiceMaior}");
```

## 📌 Dicas

- Sempre use TryParse ao converter entradas do usuário
- For é ideal quando você precisa do índice
- Use o índice para acessar múltiplas listas paralelas simultaneamente
- Valide se o índice está dentro dos limites: `i < lista.Count`
- Para modificar valores, use `lista[i] = novoValor`
- Inicialize acumuladores antes do loop for
- Use `decimal` para valores monetários (mais preciso que double)
- Ao criar listas filtradas, sempre inicialize a nova lista antes
- Use `Count` para saber quantos elementos tem na lista
- Para converter moedas, multiplique pelo índice de conversão

## 🎓 Desafios Extras

1. **Validação Robusta**: Crie função que tenta múltiplas formas de conversão
2. **Histórico de Mudanças**: Mantenha lista com valores anteriores antes de atualizar
3. **Conversão de Datas**: Adicione campo de data e converta com DateTime.TryParse
4. **Percentis**: Calcule percentis 25, 50 e 75 dos salários
5. **Projeção**: Projete valores futuros com aumento anual (use Math.Pow)

## 🔗 Navegação

- [← Exercício Anterior](exercicio-16-listas-while-strings.md) - Listas com While e Strings
- [Próximo Exercício →](exercicio-18-listas-operacoes-multiplas.md) - Listas com Operações Múltiplas
