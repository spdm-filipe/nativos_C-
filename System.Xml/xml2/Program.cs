using System.Xml;
using System;
using System.IO;
using System.Xml.Serialization;

using (XmlReader reader = XmlReader.Create("exemplo.xml"))
{
    while (reader.Read())
    {
        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Elemento")
        {
            Console.WriteLine($"Elemento encontrado: {reader.ReadElementContentAsString()}");
        }
    }
}


using (XmlWriter writer = XmlWriter.Create("novo_exemplo.xml"))
{
    writer.WriteStartDocument();
    writer.WriteStartElement("Raiz");

    writer.WriteStartElement("Elemento");
    writer.WriteString("Conteúdo do elemento");
    writer.WriteEndElement();

    writer.WriteEndElement();
    writer.WriteEndDocument();
}

using System;
using System.IO;
using System.Xml.Serialization;

public class Exemplo
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}



public class Exemplo
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

XmlSerializer serializer = new XmlSerializer(typeof(Exemplo));

// Serialização
Exemplo exemplo = new Exemplo { Nome = "João", Idade = 30 };
using (StreamWriter writer = new StreamWriter("exemplo_serializado.xml"))
{
    serializer.Serialize(writer, exemplo);
}

// Desserialização
using (StreamReader reader = new StreamReader("exemplo_serializado.xml"))
{
    Exemplo exemploDesserializado = (Exemplo)serializer.Deserialize(reader);
    Console.WriteLine($"Nome: {exemploDesserializado.Nome}, Idade: {exemploDesserializado.Idade}");
}
