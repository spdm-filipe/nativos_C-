using System.Globalization;
decimal valor = 12345.67m;
CultureInfo culturaBrasileira = new CultureInfo("pt-BR");
CultureInfo culturaAmericana = new CultureInfo("en-US");

Console.WriteLine(valor.ToString("C", culturaBrasileira)); // R$12.345,67
Console.WriteLine(valor.ToString("C", culturaAmericana));  // $12,345.67
//------
Console.WriteLine("----------");
DateTime data = DateTime.Now;
CultureInfo culturaFranca = new CultureInfo("fr-FR"); // Cultura Francesa

Console.WriteLine(data.ToString("D", culturaFranca)); 
Console.WriteLine(data.ToString("D", culturaBrasileira)); 
//------
Console.WriteLine("----------");

CultureInfo cultura = new CultureInfo("de-DE"); // Cultura Alemã
decimal valor2 = 12345.67m;

Console.WriteLine(valor2.ToString("N", cultura)); // Exibe com formatação alemã: "12.345,67"
Console.WriteLine(valor2.ToString("N", culturaBrasileira)); 
Console.WriteLine(valor2.ToString("C", culturaAmericana));  // $12,345.67