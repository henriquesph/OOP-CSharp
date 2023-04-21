using System;
using System.Globalization;
//using Formas_geometricas;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Triangulo x, y;
//            x = new Triangulo();
//            y = new Triangulo();

//            Console.WriteLine("Entre com as medidas do triângulo X:");
//            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Entre com as medidas do triângulo Y:");
//            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            double areaX = x.Area();

//            double areaY = y.Area();

//            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
//            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

//            if (areaX > areaY)
//            {
//                Console.WriteLine("Maior área: X");
//            }
//            else
//            {
//                Console.WriteLine("Maior área: Y");
//            }
//        }
//    }
//}

//    using Pessoa;

//namespace Pessoa;

//class MaiorIdade
//{
//    static void Main(string[] args)
//    {
//        Pessoa a, b;
//        a = new Pessoa();
//        b = new Pessoa();

//        a.nome = Console.ReadLine();
//        a.idade = int.Parse(Console.ReadLine());

//        b.nome = Console.ReadLine();
//        b.idade = int.Parse(Console.ReadLine());

//        if (a.idade > b.idade)
//        {
//            Console.WriteLine("O mais velho é: " + a.nome);
//        }
//        else
//            Console.WriteLine("O mais velho é: " + b.nome);
//    }
//}


//using Empresa;

//namespace Pessoa;

//class MediaSalario
//{
//    static void Main(string[] args)
//    {
//        double media;
//        Funcionario a, b;
//        a = new Funcionario();
//        b = new Funcionario();

//        Console.WriteLine("nome e salario do primeiro funcionário: ");
//        a.nome = Console.ReadLine();
//        a.salario = int.Parse(Console.ReadLine());

//        Console.WriteLine("nome e salario do segundo funcionário: ");
//        b.nome = Console.ReadLine();
//        b.salario = int.Parse(Console.ReadLine());

//        media = (a.salario + b.salario) / 2;

//        Console.WriteLine("A média salarial é de: " + media);
//    }
//}


//using Retangulo;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            RetanguloMedidas r;
//            r = new RetanguloMedidas();
//            Console.WriteLine("Entre a largura e altura do triangulo");

//            r.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            r.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("AREA: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
//            Console.WriteLine("PERÍMETRO: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
//            Console.WriteLine("DIAGONAL: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
//        }
//    }
//}

//using FuncionarioDois;

//namespace Course
//{
//    class Pessoa
//    {
//        static void Main(string[] args)
//        {
//            FuncionarioDados f;
//            f = new FuncionarioDados();
//            double percent;

//            Console.WriteLine("Nome: ");
//            f.nome = Console.ReadLine();

//            Console.WriteLine("Salário bruto: ");
//            f.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Imposto: ");
//            f.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Funcionário: " + f);

//            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
//            percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            f.aumentarSalario(percent);
//            Console.WriteLine("Dados atualizados: " + f);
//        }
//    }
//}


//using Aluno;

//namespace Course
//{
//    class Pessoa
//    {
//        static void Main(string[] args)
//        {
//            AlunoNotas estudante;
//            estudante = new AlunoNotas();

//            Console.WriteLine("Primeira nota: ");
//            estudante.notaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Segunda nota: ");
//            estudante.notaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Terceira nota: ");
//            estudante.notaTres = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Nota final: " + estudante.NotaFinal(), "F2", CultureInfo.InvariantCulture);

//            if (estudante.Aprovado())
//            {
//                Console.WriteLine("APROVADO");
//            }
//            else
//            {
//                Console.WriteLine("REPROVADO");
//                Console.WriteLine("Nota Restante: " + estudante.PontosRestantes(), "F2", CultureInfo.InvariantCulture); ;
//            }
//        }
//    }
//}


//using ConversorMoeda;

//namespace Course
//{
//    class Moeda
//    {
//        static void Main(string[] args)
//        {
//            double c;
//            double d;
//            double r;

//            Console.WriteLine("Qual é a cotação do Dolar: ");
//            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Quantos dólares você irá comprar: ");
//            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            r = Conversor.Converter(d, c);

//            Console.WriteLine("Valor a ser pago" + r, "F2", CultureInfo.InvariantCulture);
//        }
//    }
//}