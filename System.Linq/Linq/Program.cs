// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[] words = { "banana", "apple", "orange", "pear" };

//OrderExample(words);
//FilterAndSelectExample(numbers);
//AnyAllExample(numbers);
LinqWithObjects();
   void FilterAndSelectExample(int[] numbers)
    {

        var evenNumbers = numbers.Where(n => n % 2 == 0);

        var squares = evenNumbers.Select(n => n * n);

        Console.WriteLine("Números pares ao quadrado:");
        foreach (var square in squares)
        {
            Console.WriteLine(square);
        }
    }

   void OrderExample(string[] words)
    {
        var orderedWords = words.OrderBy(w => w);

        var descendingWords = words.OrderByDescending(w => w);

        Console.WriteLine("Ordenado alfabeticamente:");
        foreach (var word in orderedWords)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine("Ordenado em ordem decrescente:");
        foreach (var word in descendingWords)
        {
            Console.WriteLine(word);
        }
    }
  
   void AnyAllExample(int[] numbers)
    {

        // Verifica se existe algum número maior que 5
        bool anyGreaterThanFive = numbers.Any(n => n > 5);
        Console.WriteLine($"Algum número maior que 5: {anyGreaterThanFive}");

        // Verifica se todos os números são pares
        bool allEven = numbers.All(n => n % 2 == 0);
        Console.WriteLine($"Todos os números são pares: {allEven}");
    }

 void LinqWithObjects()
    {
        var people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Charlie", Age = 35 }
        };

        // Filtra pessoas com idade maior que 28 e projeta os nomes
        var names = people
            .Where(p => p.Age > 28)
            .Select(p => p.Name);

        Console.WriteLine("Pessoas com mais de 28 anos:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

 class Person
{
    public string Name { get; set; }
     public int Age { get; set; }
}