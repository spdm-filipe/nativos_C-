Dictionary<string, int> idades = new Dictionary<string, int>
{
    { "Alice", 25 },
    { "Bob", 30 }
};

idades["Charlie"] = 35;

if (idades.TryGetValue("Alice", out int idade))
{
    Console.WriteLine($"Idade da Alice: {idade}");
}
//----
HashSet<int> numeros = new HashSet<int> { 1, 2, 3 };
numeros.Add(4);
numeros.Add(2);  // Duplicata, não será adicionada

foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}
//---FIFO 
Queue<string> tarefas = new Queue<string>();
tarefas.Enqueue("Tarefa1");
tarefas.Enqueue("Tarefa2");

string tarefa = tarefas.Dequeue();
Console.WriteLine(tarefa);
//---LIFO 
Stack<string> historico = new Stack<string>();
historico.Push("Página1");
historico.Push("Página2");

string ultimaPagina = historico.Pop();
Console.WriteLine(ultimaPagina);
//--
SortedList<string, int> listaOrdenada = new SortedList<string, int>
{
    { "Alice", 25 },
    { "Bob", 30 }
};
/*
List<T>: Ideal para coleções dinâmicas indexadas.
Dictionary<TKey, TValue>: Ótimo para buscas rápidas por chave.
HashSet<T>: Útil para garantir exclusividade sem ordenação.
Queue<T> / Stack<T>: Perfeitas para processamento sequencial (FIFO/LIFO).
LinkedList<T>: Melhor para coleções com inserções/remoções frequentes.
SortedList<TKey, TValue> / SortedDictionary<TKey, TValue>: Adequadas quando a ordem é necessária.

*/