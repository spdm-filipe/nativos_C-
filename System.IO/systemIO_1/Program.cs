string filePath = "test_file.txt";

// Criar um arquivo e escrever conteúdo
//File.AppendAllText()
//escrevendo 1
var conteudo = "Text exemple";
    using(StreamWriter sw = File.CreateText(filePath)){
        sw.WriteLine(conteudo);
    }
//escrevendo 2\
File.WriteAllText(filePath,conteudo);


// Ler o conteúdo
//string content = File.ReadAllText(filePath);
//Console.WriteLine(content);
string conteudoArquivo = File.ReadAllText(filePath);
Console.WriteLine(conteudoArquivo);

FileInfo info = new FileInfo(filePath);
Console.WriteLine("Tamanho: "+ info.Length);
Console.WriteLine("nome: "+ info.Name);

Console.WriteLine("Diretorio: "+ info.DirectoryName);

Console.WriteLine("-------------------");

DirectoryInfo directoryInfoinfo = new DirectoryInfo(filePath);
Console.WriteLine(directoryInfoinfo.FullName);
Console.WriteLine(directoryInfoinfo.Parent);
Console.WriteLine(directoryInfoinfo.Exists);

Console.WriteLine("--------------------");
using (StreamReader sr = new StreamReader(filePath))
{
    string line = sr.ReadLine();
    Console.WriteLine(line);
}
Console.WriteLine("--------------------");



// Copiar arquivo
//File.Copy(filePath, "copia_do_arquivo.txt");

// Mover arquivo
//File.Move("copia_do_arquivo.txt", "novo_caminho_para_copia.txt");

// Excluir arquivo
//File.Delete(filePath);
