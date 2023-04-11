//File, FileInfo

//• Namespace System.IO
//• Realiza operações com arquivos (create, copy, delete, move, open, etc.) e
//ajuda na criação de objetos FileStream.

//• File (operações estáticas - não precisa instaciar o objeto) ex: File.operação
//• static members (simples, mas realiza verificação de segurança para cada operação - mais lenta)
//• https://msdn.microsoft.com/en-us/library/system.io.file(v=vs.110).aspx

//• FileInfo
//• instance members (instancia um objeto) - mais rápido, melhor para muitas operações, está atrelado ao arquivo, sistema operacional é avisado, não tem verificação de segurança a cada operação chamada
//• https://msdn.microsoft.com/en-us/library/system.io.fileinfo(v=vs.110).aspx


//IOException

//Namespace System.IO
//• IOException
//• DirectoryNotFoundException
//• DriveNotFoundException
//• EndOfStreamException
//• FileLoadException
//• FileNotFoundException
//• PathTooLongException
//• PipeException


//using System;
//using System.IO;

//namespace aula195
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string sourcePath = @"C:\temp\file1.txt"; // notação @ para não digitar a barra 2x
//            string targetPath = @"C:\temp\file2.txt";

//            try
//            {
//                //FileInfo fileInfo = new FileInfo(sourcePath); // objeto instanciado associado ao arquivo
//                //fileInfo.CopyTo(targetPath); // se rodar 2x vai cair na exceção, pois o arquivo já foi criado

//                string[] lines = File.ReadAllLines(sourcePath); // Lê todas as linhas e armazena nas respectivas posições do vetor
//                foreach(string line in lines)
//                {
//                    Console.WriteLine(line); // vai imprimir cada linha do documento txt
//                }
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("An error ocurred");
//                Console.WriteLine(e.Message);
//            }

//        }
//    }
//}





//_________x__________ (aula 196)

//FILESTREAM (stream binária)
// obs: stream significa sequência de dados (ex: netflix é um serviço de streaming, trânsmissão de dados em sequência)
//https://msdn.microsoft.com/en-us/library/system.io.filestream(v=vs.90).aspx

//Disponibiliza uma stream associada a um arquivo, permitindo operações de leitura
//e escrita.
//Suporte a dados binários.

//Instanciação:
//• Vários construtores
//• File / FileInfo (para instanciar)

// Se instancia um objeto associado ao arquivo, permitindo operações de entrada e saída, ele manipula dados binários, no exemplo transforma texto em binário


//StreamReader (stream de caracteres)

//https://msdn.microsoft.com/en-us/library/system.io.streamreader(v=vs.90).aspx

//É uma stream capaz de ler caracteres a partir de uma stream binária (ex:
//FileStream).
//Suporte a dados no formato de texto.

//Instanciação:
// - Vários construtores
// - File/FileInfo

//using System;
//using System.IO;

//namespace aula195
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string path = @"C:\temp\file1.txt";
//            FileStream fs = null; 
//            StreamReader sr = null;

//            try
//            {
//                // varios construtores: nesse caso falei qual é o arquivo e o que deve ser feito
//                // conversa direto com o sitema operacional, e não com CLR do .net (Common Language Runtime - compilação just-in-time converte o código compilado em linguagem de máquina que a CPU do computador executa), ou seja, tem que fechar o recurso manualmente no Finally
//                fs = new FileStream(path, FileMode.Open); // primeiro se instancia o FS associado ao arquivo
//                sr = new StreamReader(fs); // depois se instancia o SR associado ao FS

//                string line = sr.ReadLine(); // lê uma linha do arquivo
//                Console.WriteLine(line);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("An error ocurred");
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                if (sr != null) 
//                    sr.Close();
//                if (fs != null)
//                    fs.Close();
//;            }
//        }
//    }
//}


//using System;
//using System.IO;

//namespace aula195
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // forma resumida: não precisa instanciar 2 objetos, classe file, método OpenText() já instancia implicitamente a classe fileStream e o 
//            // dessa forma é sem o StreamReader por cima dele
//            //
//            string path = @"C:\temp\file1.txt";
//            StreamReader sr = null;

//            try
//            {
//                sr = File.OpenText(path);
//                while(!sr.EndOfStream) // para ler todas as linhas
//                {
//                    string line = sr.ReadLine();
//                    Console.WriteLine(line);
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("An error ocurred");
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                if (sr != null)
//                    sr.Close();
//            }
//        }
//    }
//}


// ____________________________________________________x______________
// AULA 197

// USING BLOCK

//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement

//Sintaxe simplificada que garante que os objetos IDisposable serão fechados.

//Objetos IDisposable NÃO são gerenciados pelo CLR. Eles precisam ser
//manualmente fechados.

//Exemplos: Font, FileStream, StreamReader, StreamWriter

//using System;
//using System.IO;

//namespace aula195
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string path = @"C:\temp\file1.txt";

//            //try
//            //{
//            //    using (FileStream fs = new FileStream(path, FileMode.Open)) // tudo que está dentro desse bloco será fechado
//            //    {
//            //        using (StreamReader sr = new StreamReader(fs)) // podem ser usado em cascata - sr também será fechado
//            //        {
//            //            while (!sr.EndOfStream)
//            //            {
//            //                string line = sr.ReadLine();
//            //                Console.WriteLine(line);
//            //            }
//            //        }
//            //    }
//            //}

//            // forma resumida:
//            try
//            {
//                using (StreamReader sr = File.OpenText(path))
//                {
//                    while(!sr.EndOfStream)
//                    {
//                        string line = sr.ReadLine();
//                        Console.WriteLine(line);
//                    }
//                }
//            }
//            catch (IOException ex)
//            {
//                Console.WriteLine("An error ocurred");
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}


////using System;
////using System.IO;

//////StreamWriter

//////https://msdn.microsoft.com/en-us/library/system.io.streamwriter(v=vs.110).aspx

//////É uma stream capaz de escrever caracteres a partir de uma stream binária (ex:
//////FileStream).

//////Suporte a dados no formato de texto.

//////Instantiation:
//////• Several constructors
//////• File / FileInfo
//////• CreateText(path)
//////• AppendText(String)

////namespace aula195
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            string sourcePath = @"C:\temp\file1.txt";
////            string targetPath = @"C:\temp\file2.txt";

////            try
////            {
////                string[] lines = File.ReadAllLines(sourcePath);

////                using (StreamWriter sw = File.AppendText(targetPath)) // Append: Abre o arquivo para escrita e escreve a partir do final
////                {
////                    foreach(string line in lines)
////                    {
////                        sw.WriteLine(line.ToUpper());
////                    }
////                }
////            }
////            catch (IOException ex)
////            {
////                Console.WriteLine("An error ocurred");
////                Console.WriteLine(ex.Message);
////            }
////        }
////    }
////}


//using System; deixei comentado, nessa versão do C# não precisa chamar (?)
//using System.IO;
//using System.Collections.Generic;

//Classe Directory, DirectoryInfo

//• Namespace System.IO
//• Operações com pastas (create, enumerate, get files, etc.).
//• Directory
//• static members (simple, but performs security check for each operation)
//• https://msdn.microsoft.com/en-us/library/system.io.directory(v=vs.110).aspx
//• DirectoryInfo
//• instance members
//• https://msdn.microsoft.com/en-us/library/system.io.directoryinfo(v=vs.110).aspx

//namespace aula195
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string path = @"C:\temp\myfolder";
//            try
//            {
//                // LISTAR PASTAS A PARTIR DE UMA PASTA INFORMADA - EnumerateDirectories

//                // foi usada a terceira sobrecarga do construtor

//                // IEnumerable: tipo mais genérico de coleção, neste caso com as strings com os nomes das pastas

//                // poderia simplificar e colocar "var folder": C# já faz a referência de tipo
//                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // *.* - quaquer nome de arquivo, com qualquer nome de extensão
//                // AllDirectories: lista inclusive as subpastas

//                Console.WriteLine("FOLDERS");
//                foreach(string s in folders)
//                {
//                    Console.WriteLine(s);
//                }

//                // LISTAR ARQUIVOS A PARTIR DE UMA PASTA INFORMADA - EnumerateFiles

//                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);  

//                Console.WriteLine("FILES");
//                foreach (string s in files)
//                {
//                    Console.WriteLine(s);
//                }

//                // CRIANDO UMA PASTA

//                Directory.CreateDirectory(path + "\\newfolder"); // 2 barras para indicar o caminho ou @
//            }
//            catch (IOException ex)
//            {
//                Console.WriteLine("An error ocurred");
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}


//Path
//• Namespace System.IO
//• Realiza operações com strings que contém informações de arquivos ou pastas.
//• https://msdn.microsoft.com/en-us/library/system.io.path(v=vs.110).aspx

using System;
using System.IO;

namespace aula195
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); // imprime a barra invertida "\", que é o separador do caminho

            Console.WriteLine("PathSeparator: " + Path.PathSeparator); // imprime o ponto e vírgula  ( que separa as pastas ??)

            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); // pega somente o caminho da pasta sem mostrar o arquivo

            Console.WriteLine("GetFileName: " + Path.GetFileName(path));

            Console.WriteLine("GetExtension: " + Path.GetExtension(path));

            Console.WriteLine("GetFileNameWithoutExtension " + Path.GetFileNameWithoutExtension(path));

            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));

            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); // informa pasta temporária do sistema
        }
    }
}