using System.Security.Cryptography;
using System.Text;

using (SHA256 sha256 = SHA256.Create())
{
    byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes("senha123"));
    string hash = Convert.ToBase64String(hashBytes);
    Console.WriteLine($"Hash SHA-256: {hash}");
}


 static bool CompararHashSHA256(string texto, string hashArmazenado)
{
    using (SHA256 sha256 = SHA256.Create())
    {
        // Gera o hash da entrada
        byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
        string novoHash = Convert.ToBase64String(hashBytes);

        // Compara o novo hash com o hash armazenado
        return novoHash == hashArmazenado;
    }
}

string senha = "senha123";
string hashArmazenado = "VaXp54IHtN+GmdYIhvoHAHlGNUewldGgW8cZu05s0lE="; // Substitua pelo hash armazenado

bool valido = CompararHashSHA256(senha, hashArmazenado);
Console.WriteLine(valido ? "Senha válida!" : "Senha inválida.");
