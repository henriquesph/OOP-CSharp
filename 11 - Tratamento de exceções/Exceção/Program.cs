//using System;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                int n1 = int.Parse(Console.ReadLine());
//                int n2 = int.Parse(Console.ReadLine());

//                int result = n1 / n2;

//                Console.WriteLine(result);
//            }
//            //catch(Exception e) // classe pricipal, erro mais genérico
//            //{
//            //    Console.WriteLine("Error!" + e.Message); // Error!Attempted to divide by zero.
//            //}
//            catch(DivideByZeroException) // poderia colocar o "e"
//            {
//                Console.WriteLine("Division by zero is not allowed"); // ideal é coloca a exceção mais específica, possibilidade de tratar cada erro de forma diferente.
//            }
//            catch (FormatException e)
//            {
//                Console.WriteLine("Format error! " + e.Message);
//            }
//            // se o erro não tiver sido tratado é mostrado o rastreamento das chamadas das exceções, ex: erro na stack 3
//        }
//    }
//}

//Exceções

//• Uma exceção é qualquer condição de erro ou comportamento
//inesperado encontrado por um programa em execução

//• No .NET, uma exceção é um objeto herdado da classe
//System.Exception

//• Quando lançada, uma exceção é propagada na pilha de chamadas de
//métodos em execução, até que seja capturada (tratada) ou o
//programa seja encerrado (um método que chama outro, que chama outro...)

// Classe Exception tem 2 subclasses:
// - SystemException: da linguagem (sistema) - ver no PDF as demais exceções
// - ApplicationException: que o programador pode criar (aplicação)





//Por que exceções?

//• O modelo de tratamento de exceções permite que erros sejam
//tratados de forma consistente e flexível, usando boas práticas (evita grande quantidade de if/else (simplifica)

//• Vantagens:
//• Delega a lógica do erro para a classe / método responsável por conhecer as
//regras que podem ocasionar o erro
//• Trata de forma organizada (inclusive hierárquica) exceções de tipos diferentes
//• A exceção pode carregar dados quaisquer


//Estrutura try-catch

//• Bloco try
//• Contém o código que representa a execução normal do trecho de código que
//pode acarretar em uma exceção
//• Bloco catch

//• Contém o código a ser executado caso uma exceção ocorra
//• Deve ser especificado o tipo da exceção a ser tratada(upcasting é permitido)


//Bloco finally
//try
//{
//}
//catch (ExceptionType e)
//{
//}
//finally
//{
//}

//• É um bloco que contém código a ser executado independentemente de ter
//ocorrido ou não uma exceção.

//• Exemplo clássico: fechar um arquivo ou conexão de banco de dados ao final do
//    processamento.

using System;
using System.IO;
public class ProcessFile
{
    public static void Main()
    {
        FileStream fs = null;
        try
        {
            fs = new FileStream(@"D:\Henrique\Análise e Desenvolvimento de Sistemas\7° Período\ESTRATÉGIA DE PROGRAMAÇÃO ORIENTADA A OBJETOS\CAP 2 - Conceitos da linguagem Java\capitulo-2.pdf", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (fs != null)
            {
                fs.Close();
            }
        }
    }
}