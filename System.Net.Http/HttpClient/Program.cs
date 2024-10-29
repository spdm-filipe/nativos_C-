// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System.Text;
//dotnet add package Newtonsoft.Json
Console.WriteLine("Hello, World!");

var client = new ApiClient();

await client.CreatePostAsync();
Console.WriteLine("--------------");
await client.GetPostsAsync();

public class ApiClient
{
    private static readonly HttpClient client = new HttpClient();
    public async Task GetPostsAsync()
    {
        string url = "https://jsonplaceholder.typicode.com/posts";
        
        // Enviando requisição GET
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        // Lendo resposta como string
        string responseBody = await response.Content.ReadAsStringAsync();
        
        // Exibindo resultado
        Console.WriteLine(responseBody);
    }
    public async Task CreatePostAsync()
    {
        string url = "https://jsonplaceholder.typicode.com/posts";

        // Definindo dados do novo post
        var newPost = new
        {
            title = "Novo Post",
            body = "Este é o conteúdo do post",
            userId = 1
        };

        // Convertendo objeto para JSON
        var jsonData = JsonConvert.SerializeObject(newPost);
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

        // Enviando requisição POST
        HttpResponseMessage response = await client.PostAsync(url, content);
        response.EnsureSuccessStatusCode();

        // Lendo resposta
        string responseBody = await response.Content.ReadAsStringAsync();
        
        // Exibindo resultado
        Console.WriteLine(responseBody);
    }
   public async Task UpdatePostAsync(int postId)
    {
        string url = $"https://jsonplaceholder.typicode.com/posts/{postId}";

        // Definindo dados atualizados do post
        var updatedPost = new
        {
            id = postId,
            title = "Post Atualizado",
            body = "Este é o conteúdo atualizado do post",
            userId = 1
        };

        // Convertendo objeto para JSON
        var jsonData = JsonConvert.SerializeObject(updatedPost);
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

        // Enviando requisição PUT
        HttpResponseMessage response = await client.PutAsync(url, content);
        response.EnsureSuccessStatusCode();

        // Lendo resposta
        string responseBody = await response.Content.ReadAsStringAsync();
        
        // Exibindo resultado
        Console.WriteLine(responseBody);
    }
   public async Task DeletePostAsync(int postId)
    {
        string url = $"https://jsonplaceholder.typicode.com/posts/{postId}";

        // Enviando requisição DELETE
        HttpResponseMessage response = await client.DeleteAsync(url);
        response.EnsureSuccessStatusCode();

        Console.WriteLine($"Post {postId} removido com sucesso.");
    }

}