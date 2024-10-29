using System.Xml;

XmlDocument doc = new XmlDocument();
doc.Load("exemplo.xml"); // Carrega um arquivo XML

// Navega pelo XML
XmlNode root = doc.DocumentElement;
Console.WriteLine($"Raiz: {root.Name}");

// Modifica um elemento
XmlNode elemento = root.SelectSingleNode("Elemento");
if (elemento != null)
{
    elemento.InnerText = "Novo Valor";
}

// Salva as mudanças no arquivo
doc.Save("exemplo_modificado.xml");
