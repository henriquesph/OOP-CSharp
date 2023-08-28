//Extension methods

//• São métodos que estendem a funcionalidade de um tipo (Class ou Struct), sem
//precisar alterar o código fonte deste tipo, nem herdar desse tipo

//• Como fazer um extension method?
//• Criar uma classe estática
//• Na classe, criar um método estático
//• O primeiro parâmetro do método deverá ter o prefixo this, seguido da
//declaração de um parâmetro do tipo que se deseja estender. Esta será uma
//referência para o próprio objeto.


using System;

public class ProcessFile
{
    public static void Main(string[] args)
    {
        //DateTime dt = new DateTime(2023, 08, 28, 8, 10, 45);
        //Console.WriteLine(dt.ElapsedTime());

        string s1 = "Good morning dear students!";
        Console.WriteLine(s1.Cut(10));
    }
}