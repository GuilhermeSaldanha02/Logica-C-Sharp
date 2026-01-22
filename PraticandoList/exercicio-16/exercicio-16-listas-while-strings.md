# Exercício 16 - Listas com While e Manipulação de Strings

## 🎯 Objetivos de Aprendizagem

- Combinar listas com loop while
- Manipular strings dentro de listas
- Usar operações de string (Trim, ToLower, ToUpper, Contains, Substring)
- Criar menus interativos com while

## 📝 Cenário

Você está desenvolvendo um sistema de cadastro de clientes para uma empresa. O sistema deve permitir adicionar, buscar, editar e remover clientes de forma interativa, utilizando listas e manipulação de strings.

## 📋 Tarefas

### Tarefa 1: Cadastro Interativo com While

Crie um menu interativo que funcione continuamente até o usuário escolher sair:

**Entrada:**
1. Exiba um menu com opções:
   - 1: Adicionar cliente
   - 2: Listar clientes
   - 3: Sair
2. Use while para manter o menu ativo
3. Para adicionar cliente, solicite:
   - Nome completo
   - Email
   - Telefone

**Processamento:**
1. Crie três listas: nomes, emails e telefones
2. Normalize os dados antes de adicionar:
   - Nome: capitalize corretamente (primeira letra de cada palavra maiúscula)
   - Email: converter para minúsculas e remover espaços
   - Telefone: remover espaços e caracteres especiais
3. Valide se os campos não estão vazios
4. Adicione às listas
5. Continue o loop até o usuário digitar 3

### Tarefa 2: Busca e Formatação de Dados

Adicione ao menu anterior a opção "4: Buscar cliente":

**Entrada:**
1. Solicite um termo de busca (pode ser parte do nome)

**Processamento:**
1. Use while para permitir múltiplas buscas
2. Converta o termo de busca para minúsculas
3. Use Contains para buscar em todos os nomes (também em minúsculas)
4. Armazene todos os clientes encontrados em listas temporárias
5. Exiba todos os resultados formatados:
   - Nome em maiúsculas
   - Email em lowercase
   - Telefone formatado
6. Se não encontrar nada, informe o usuário
7. Pergunte se deseja fazer outra busca

### Tarefa 3: Validação de Email com Strings

Melhore o sistema para validar emails ao adicionar clientes:

**Validações:**
1. Email deve conter "@"
2. Email deve ter pelo menos um "." após o "@"
3. Email não pode começar ou terminar com espaços
4. Email deve ter pelo menos 5 caracteres
5. Parte antes do @ deve ter pelo menos 1 caractere
6. Parte depois do @ deve ter pelo menos 3 caracteres

**Processamento:**
1. Use while para continuar pedindo até o email ser válido
2. Use métodos de string (Contains, IndexOf, Substring, Length)
3. Exiba mensagens específicas para cada tipo de erro
4. Só adicione à lista quando o email for válido

### Tarefa 4: Edição de Dados com Busca

Adicione ao menu a opção "5: Editar cliente":

**Entrada:**
1. Solicite o nome (ou parte do nome) do cliente a editar

**Processamento:**
1. Busque o cliente usando Contains (case-insensitive)
2. Se encontrar múltiplos resultados:
   - Exiba todos numerados
   - Peça ao usuário escolher qual editar
3. Se encontrar apenas um:
   - Exiba os dados atuais
   - Pergunte qual dado editar (Nome/Email/Telefone)
   - Use switch para processar a escolha
4. Solicite o novo valor
5. Valide e normalize o novo valor
6. Atualize a lista correspondente
7. Use while para permitir editar múltiplos campos
8. Exiba os dados atualizados

### Tarefa 5: Remoção com Confirmação

Adicione ao menu a opção "6: Remover cliente":

**Entrada:**
1. Solicite parte do nome, email ou telefone para buscar

**Processamento:**
1. Busque em todas as três listas usando Contains
2. Exiba todos os clientes que correspondem à busca
3. Se encontrar múltiplos, peça para especificar melhor
4. Quando identificar o cliente:
   - Exiba todos os dados
   - Peça confirmação (digite o nome completo para confirmar)
   - Valide se o nome digitado corresponde exatamente
5. Se confirmar, remova das três listas (mesmo índice)
6. Use while para permitir remover vários clientes
7. Exiba a lista atualizada

### Tarefa 6: Relatório com Formatação Avançada

Adicione ao menu a opção "7: Gerar relatório":

**Processamento:**
1. Use while para percorrer todas as listas
2. Para cada cliente, formate e exiba:
   - Número sequencial
   - Nome em formato título (cada palavra com inicial maiúscula)
   - Primeira letra do nome em destaque
   - Email mascarado (ex: j***@email.com)
   - Telefone formatado com DDD
   - Domínio do email extraído (parte após @)
3. Calcule e exiba estatísticas:
   - Total de clientes
   - Domínio de email mais comum
   - Tamanho médio dos nomes
   - Quantidade de clientes por DDD (se telefone tiver)

### Tarefa 7: Exportação Formatada

Adicione ao menu a opção "8: Exportar dados":

**Processamento:**
1. Crie uma lista de strings para armazenar o relatório
2. Use while para processar cada cliente
3. Para cada cliente, crie uma string formatada com todos os dados
4. Adicione informações extras usando manipulação de strings:
   - Nome abreviado (Primeiras letras de cada nome)
   - Username do email (parte antes do @)
   - Iniciais em uppercase
5. Armazene todas as strings formatadas na lista
6. Exiba o conteúdo completo
7. Informe quantas linhas foram geradas

## 💡 Conceitos Importantes

### While com Menu

```csharp
bool continuar = true;
while (continuar)
{
    Console.WriteLine("1. Opção A");
    Console.WriteLine("2. Sair");
    string opcao = Console.ReadLine();
    
    if (opcao == "2")
    {
        continuar = false;
    }
}
```

### Normalizar Strings antes de Adicionar em Listas

```csharp
List<string> emails = new List<string>();

string emailInput = Console.ReadLine();
string emailNormalizado = emailInput.Trim().ToLower();

if (!string.IsNullOrWhiteSpace(emailNormalizado))
{
    emails.Add(emailNormalizado);
}
```

### Busca em Lista com Contains

```csharp
List<string> nomes = new List<string> { "João Silva", "Maria Santos" };
string busca = "silva".ToLower();

for (int i = 0; i < nomes.Count; i++)
{
    if (nomes[i].ToLower().Contains(busca))
    {
        Console.WriteLine($"Encontrado: {nomes[i]}");
    }
}
```

### Capitalizar Nome

```csharp
string nome = "  jOÃO PEDRO silva  ";
nome = nome.Trim().ToLower();  // "joão pedro silva"

string[] palavras = nome.Split(' ');
for (int i = 0; i < palavras.Length; i++)
{
    if (palavras[i].Length > 0)
    {
        palavras[i] = char.ToUpper(palavras[i][0]) + palavras[i].Substring(1);
    }
}
nome = string.Join(" ", palavras);  // "João Pedro Silva"
```

### Validar Email

```csharp
bool EmailValido(string email)
{
    if (string.IsNullOrWhiteSpace(email)) return false;
    if (!email.Contains("@")) return false;
    
    int posicaoArroba = email.IndexOf("@");
    if (posicaoArroba == 0) return false;  // Não pode começar com @
    if (posicaoArroba == email.Length - 1) return false;  // Não pode terminar com @
    
    string parteDepois = email.Substring(posicaoArroba + 1);
    if (!parteDepois.Contains(".")) return false;
    
    return true;
}
```

### Remover Item de Listas Paralelas

```csharp
List<string> nomes = new List<string> { "Ana", "Bruno", "Carlos" };
List<string> emails = new List<string> { "ana@", "bruno@", "carlos@" };

int indiceRemover = 1;  // Remover Bruno

nomes.RemoveAt(indiceRemover);
emails.RemoveAt(indiceRemover);
```

## 📌 Dicas

- Use `Trim()` em todas as entradas para remover espaços extras
- Normalize strings antes de comparar (ToLower ou ToUpper)
- `Contains` é case-sensitive, sempre normalize antes de usar
- `IndexOf` retorna -1 quando não encontra o caractere
- Use `Split(' ')` para separar palavras de um texto
- `string.Join()` reconstrói uma string a partir de array
- While é ideal para menus que devem continuar até o usuário escolher sair
- Sempre valide se o índice existe antes de acessar lista
- Use `Count` para verificar quantidade de elementos
- Mantenha listas paralelas sempre com o mesmo tamanho

## 🎓 Desafios Extras

1. **Autocomplete**: Ao digitar 3 letras, sugira nomes que começam com essas letras
2. **Histórico**: Mantenha uma lista de todas as operações realizadas
3. **Backup**: Antes de remover, adicione o cliente a uma lista de "excluídos"
4. **Estatísticas**: Calcule letra mais comum nos nomes
5. **Formatação**: Crie função para formatar telefone (XX) XXXXX-XXXX automaticamente

## 🔗 Navegação

- [← Exercício Anterior](exercicio-15-listas-foreach-enum.md) - Listas com Foreach e Enum
- [Próximo Exercício →](exercicio-17-listas-for-conversoes.md) - Listas com For e Conversões
