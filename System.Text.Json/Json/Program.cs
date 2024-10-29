using System;
using System.Text.Json;


var json = new JsonExemple();
json.SerializeExample();
json.DeserializeExample();
json.SerializeCollection();
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class JsonExemple
{

 public void SerializeExample()
    {
        var person = new Person { Name = "Alice", Age = 30 };
        var options = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
        };
        // Serialize object to JSON
        string jsonString = JsonSerializer.Serialize(person, options);
        Console.WriteLine($"Serialized JSON: {jsonString}");
    }

    public void DeserializeExample()
    {
        string jsonString = "{\"Name\":\"Alice\",\"Age\":30}";

        // Deserialize JSON to object
        var person = JsonSerializer.Deserialize<Person>(jsonString);

        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }


public void SerializeCollection(){
   var people = new List<Person>
{
    new Person { Name = "Alice", Age = 30 },
    new Person { Name = "Bob", Age = 25 }
};
 string jsonString = JsonSerializer.Serialize(people);
Console.WriteLine(jsonString);
}
}