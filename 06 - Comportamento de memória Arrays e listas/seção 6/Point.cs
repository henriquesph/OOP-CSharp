// TIPOS REFERÊNCIA

// Classes são tipos referência - Variáveis que são do tipo classe não devem ser entendidas, mas sim
// como tentáculos (ponteiros) para caixas

// Product p1, p2; guardado na área da memória chamada stack - ponteiro (por enquanto sem valor e sem endereço)
// p1 = new Product ("tv", 900, 0); guardado na área da memória heap (variáveis criadas acima apontam para este endereço onde estão armazenadas e guardadas os valores) )

// p2 = p1 (p2 aponta para p1 aponta - heap)

// p2 = null; vazio, não aponta para nenhum endereço



// TIPOS VALOR

// Structs - são caixas que armazenam valores ma stack, e não ponteiros - tipos double, int etc também são structs
// stack - alocação dinâmica??

//double x, y; // tipos int, var, short, bool, etc. são tipos valor
//x = 10;
//y = x; // faz uma cópia do valor de x - não aponta para nenhum lugar

// Struct - criação do tipo que armazena valor sem ser um ponteiro - objeto instanciado no stack (Classe point que criei)
// não aceita valor null

//using System;

//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Point p; // não é preciso criar um novo objeto new, apesar de aceitar - ex do código abaixo
//            p.X = 10;
//            p.y = 5;
//            Console.WriteLine(p); // é preciso iniciar os valores do struct
//            p = new Point(); //  sobrescreve como os valores zero //
//            Console.WriteLine(p);
//        }
//    }
//}



// GARBAGE COLLECTOR E ESCOPO LOCAL

// Desalocação pelo Garbage collector:

// - G.C - Automatiza o gerenciamente de memória de um programa em execução
// - Objetos alocados dinâmicamente (HEAP) quando não possuem mais referência para eles são desalocados, são desalocados pelo garbage collector
// - variáveis locais são desalocadas dinamicamente assim quando seu escopo local sai de execução

//Product p1, p2;

//p1 = new Product("tv", 10, 20);
//p2 = new Product("bike", 20, 4);

//p2 = p1 // agora p2 aponta para o local no Heap que o p1 estava, e o garbage collector vai desalocar a memória onde o p2 estava

// DESALOCAÇÃO POR ESCOPO -  quando variáveis são iniciadas dentro do escopo, quando o escopo termina elas são desalocadas (não é garbage collector)
// ex: variáveis locais dentro de uma função


// Aula 68 -  Nullable - recursos para que dados tipos Structs possam receber valor null (por padrão struct não aceita null - vazio)

//using System;

//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            /*double x = null;*/ // está errado
//                                 //Nullable<double> x = null; // nullable do tipo double
//                                 //double? x = null; // interrogação diz que é opcional - forma simplificada de escrever o nullable
//                                 //double? y = 10;

//            //Console.WriteLine(x); // imprime valor vazio (nada)
//            //Console.WriteLine(x.GetValueOrDefault()); // imprime o padrão caso seja vazio (zero)
//            //Console.WriteLine(y.GetValueOrDefault()); // imprimero o valor 10

//            //Console.WriteLine(x.HasValue); // false (tem valor?)
//            //Console.WriteLine(y.HasValue); // true

//            ////Console.WriteLine(x.Value); // dá erro, pq não tem valor. para corrigir colocar um if (x.hasvalue) só executa se tiver valor - personalizar msg
//            //Console.WriteLine(y.Value);


//            // OPERADOR DE COALESCÊNCIA NULA
//            double? x = null;
//            double? y = 5;

//            double a = x ?? 10; // caso seja null a variável receberá o valor 10
//            double b = y ?? 10;

//            Console.WriteLine(a); // era null, então recebeu 10
//            Console.WriteLine(b); // não era null, então recebeu o valor de y que é 5
//        }
//    }
//}


// VETORES - Arranjos unidimensionais, homgêneo, ordenada, alocada de um vez só em um bloco de memória - tamanho fixo
// Bom para busca (saber onde está o índice)
// ruim para insersão e deleção


//using System;

//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n;
//            double[] alturas;
//            double soma, media;

//            Console.WriteLine("números a serem lidos");
//            n = int.Parse(Console.ReadLine()); // n criado no stack

//            alturas = new double[n]; // criado no heap
//            for(int cont = 0; n > cont; cont++)
//            {
//                Console.WriteLine("digite a altura: ");
//                alturas[cont] = double.Parse(Console.ReadLine());
//            }

//            soma = 0;
//            media = 0;
//            for(int cont = 0; n > cont; cont++)
//            {
//                soma += alturas[cont];
//            }

//            media = soma / alturas.Length;
//            Console.WriteLine("A altura média é: " + media);
//        }

//    }
//}

//using System;
// Aula 70 - vetores 2
// Vetor do tipo referência
//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            Product[] vect = new Product[n];

//            for (int i = 0; i < n; i++)
//            {
//                string name = Console.ReadLine();
//                double price = double.Parse(Console.ReadLine());

//                vect[i] = new Product
//                {
//                    Name = name,
//                    Price = price
//                };
//            }

//            double sum = 0;
//            for (int i = 0; i < n; i++)
//            {
//                sum += vect[i].Price;
//            }
//            double media = sum / n;
//            Console.WriteLine("A média dos produtos é: " + media);
//        }
//    }
//}

//namespace seção_6 // números alatórios
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var rand = new Random();;
//            string[] pages = new string[3];
//            pages[0] = "teste";
//            pages[1] = "testando";
//            pages[2] = "testado";

//            int n = rand.Next(0, 3);
//            Console.WriteLine(n);
//            Console.WriteLine(pages[n]);



//        }
//    }
//}


//using System;

//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Estudante[] vect = new Estudante[10];

//            Console.WriteLine("Quantos quartos serão alugados? ");
//            int n = int.Parse(Console.ReadLine());

//            for (int i = 1; i <= n; i++)
//            {
//                Console.WriteLine("Aluguel: " + i);

//                Console.WriteLine("Nome: ");
//                string nome = Console.ReadLine();

//                Console.WriteLine("Email: ");
//                string email = Console.ReadLine();

//                Console.WriteLine("Quarto: ");
//                int quarto = int.Parse(Console.ReadLine());

//                vect[quarto] = new Estudante(nome, email);
//            }
//            Console.WriteLine("Quartos ocupados: ");
//            for (int i = 0; i < 10; i++)
//            {
//                if (vect[i] != null)
//                {
//                    Console.WriteLine(i + ": " + vect[i]);
//                }
//            }
//        }
//    }
//}


//using System;

//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//            // PARAMS - Não precisa criar contrutores com diferentes númeors de parâmetros, na classe Calculator tem um exemplo
//        {
//            //int s1 = Calculator.Sum(new int[] { 1, 3, 5 });
//            int s1 = Calculator.Sum(1, 3, 5);
//            Console.WriteLine(s1);
//        }
//    }
//}


//using System;

//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 3;
//            // Modificador de parâmetro Ref (caso não seja passado o escopo só será local da classe e não será modificado a variável
//            // foi definido o Ref na função da classe também
//            // faz o parâmetro ser uma referência a variável original
//            // exige que a variável seja iniciada
//            Calculator.Triplicar(ref n);
//            Console.WriteLine(n);
//        }
//    }
//}

// REF e OUT - devem ser evitadas, Design ruim - Code Smells (veio do C++)

//using System;

//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // atributo out - o parametro de origem é guardado e o resultado é guardado no OUT
//            // não precisa ser iniciada
//            int a = 10; 
//            int dobro;
//            Calculator.Dobro(a, out dobro);
//            Console.WriteLine("O dobro de " + a + " é " + dobro);
//        }
//    }
//}


//using System;

//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // BOXING - Conversão de um objeto do tipo valor pra referência
//            int x = 10;
//            object obj = x; // Object é um tipo genérico que faz a variável apontar para um endereço no HEAP - é menos eficiente

//            // UNBOXING - Faz o oposto
//            int y = (int) obj; // tem que fazer o casting
//        }
//    }
//}

//using System;
//// Aula 75 - Laço foreach
//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] vect = new string[] { "Maria", "Pedro", "João" };

//            foreach (string obj in vect)
//            {
//                Console.WriteLine(obj);
//            }
//        }
//    }
//}


// LISTAS - estrutura de dados homogenea, ordenada, começa vazia ( objetos alocados sob demanda)
// cada elemento ocupa um nó (nodo) que aponta para o próximo elemento
// classe List
// pertence ao NameSpace: System.Collection.Generic

// VANTAGENS: Tamanho variável, facilidade p/ iserção e deleção

// DESVANTAGENS - Acesso sequencial dos elementos


//using System;
//using System.Collections.Generic;

//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<string> list = new List<string>(); // declaração e instanciação na mesma linha - foi criado uma lista vazia
//            /* List<string> list2 = new List<string> { "Maria", "Alex" };*/ // declaração e instanciação e inserção de de elementos na mesma linha

//            list.Add("Marcia"); // adiciona no fim da lista
//            list.Add("Ana");
//            list.Add("Andre");
//            list.Add("Henrique");
//            list.Insert(1, "Marcos"); // adiciona passando o índice (que já exista, se passar para ser o último elemento dá erro)

//            foreach(string s in list)
//            {
//                Console.WriteLine(s);
//            }

//            Console.WriteLine(list.Count()); // tamanho da lista



//            // find = primeira ocorrência
//            //findlast = última ocorrência
//            /*string s1 = list.Find(Test); */// Recebe um predicado que satisfaça a condição da função recebida
//            string s1 = list.Find(x => x[0] == 'A'); // Pode ser reescrita com a expressão lambda (função anônima)


//            int s2 = list.FindIndex(x => x[0] == 'A'); // findLastIndex - última posição

//            Console.WriteLine("Primeiro nome com a letra A: " + s1);
//            Console.WriteLine("Ìndice do primeiro elemento A: " + s2);

//            //static bool Test(string s)
//            //{
//            //    return s[0] == 'A';
//            //}

//            List<string> list2 = list.FindAll(x => x.Length > 4); // FindAll, criei outra lista passando um filtro
//            foreach(string obj in list2)
//            {
//                Console.WriteLine(obj);
//            }

//            list.Remove("Marcos");
//            list.RemoveAll(x => x[0] == 'M');
//            list.RemoveAt(1);
//            list.RemoveRange(1, 1); // a partir da posição 1 remover 1 elemento
//        }
//    }
//}

// Aula 78 exercício

//using System;
//using System.Collections.Generic;

//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Quantos empregados serão registrados: ");
//            int n = int.Parse(Console.ReadLine());

//            List<Empregado> empregados = new List<Empregado>();

//            for(int i = 0; i < n; i++)
//            {
//                Console.WriteLine("Empregado: " + "#" + i);

//                Console.WriteLine("Id: ");
//                int id = int.Parse(Console.ReadLine());

//                Console.WriteLine("Nome: ");
//                string nome = Console.ReadLine();

//                Console.WriteLine("Salário: ");
//                double salario = double.Parse(Console.ReadLine());

//                empregados.Add(new Empregado(id, nome, salario));

//                Console.WriteLine();
//            }

//            Console.WriteLine("Digite o ID do funcionário que terá o aumento");
//            int procurarId = int.Parse(Console.ReadLine());
//            Empregado emp = empregados.Find(x => x.Id == procurarId);
//            if(emp != null)
//            {
//                Console.WriteLine("Digite o percentual de aumento");
//                double percent = double.Parse(Console.ReadLine());
//                emp.aumentarSalario(percent);
//            }
//            else
//            {
//                Console.WriteLine("Funcionário não encontrado");
//            }

//            Console.WriteLine("--------- LISTA DE FUNCIONÁRIOS ----------");
//            foreach (Empregado item in empregados)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}


// AULA 79 - MATRIZES
// Arranjos bidimensionais (estrutura de dados)
// homogêneas - dados do mesmo tipo
// ordenada - elementos acessados por posições
// Alocada de uma vez só em um bloco contíguo da memória

// VATAGENS - Fácil acesso por meio da posição

// DESVANTAGENS - Tamanho fixo - ruim p/ inserção e deleção

//using System;
//using System.Collections.Generic;

//namespace seção_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double[,] mat = new double[2, 3];

//            Console.WriteLine(mat.Length); // tamanho 6
//            Console.WriteLine(mat.Rank); // tamanho da primeira dimensão (linha) = 2
//            Console.WriteLine(mat.GetLength(0)); // tamanho da primeira dimensão (linha) = 2
//            Console.WriteLine(mat.GetLength(1)); // tamanho da segunda dimensão (coluna) = 3
//        }
//    }
//}



// AP1 de algoritmos, empilhando e desempilhando filas.
//namespace Pilha
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> pares = new List<int>();
//            List<int> impares = new List<int>();

//            for(int i = 0; i < 30; i++)
//            {
//                Console.WriteLine("Digite um número:");
//                int n = int.Parse(Console.ReadLine());

//                if (n % 2 == 0 & n != 0)
//                {
//                    pares.Add(n);
//                }
//                else if (n % 2 == 1)
//                {
//                    impares.Add(n);
//                }
//                else if (n == 0)
//                {
//                    if (pares.Count == 0 & impares.Count == 0)
//                    {
//                        Console.WriteLine("A pilha está vazia");
//                        Console.WriteLine();
//                    }
//                    else
//                    {
//                        pares.RemoveAt(pares.Count - 1);
//                        impares.RemoveAt(impares.Count - 1);
//                    }
//                }
//                Console.WriteLine();
//            }

//            Console.WriteLine();
//            Console.WriteLine("---- DESEMPILHANDO ELEMENTOS PARES ----");

//            int tamanhoPar = pares.Count;
//            for (int i = tamanhoPar; i > 0; i--)
//            {
//                Console.WriteLine("item eliminado: " + pares[i - 1]);
//                pares.RemoveAt(i - 1);
//            }

//            Console.WriteLine();
//            Console.WriteLine("---- DESEMPILHANDO ELEMENTOS ÍMPARES ----");
//            int tamanhoImpar = impares.Count;
//            for (int i = tamanhoImpar; i > 0; i--)
//            {
//                Console.WriteLine("item eliminado: " + impares[i - 1]);
//                impares.RemoveAt(i - 1);
//            }
//        }
//    }
//}


//namespace aula80
//{
//    //Ex Matriz
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Digite o tamanho da Matriz");
//            int n = int.Parse(Console.ReadLine());
//            int[,] matrix = new int[n, n];

//            for (int count = 0; count < n; count++)
//            {
//                string[] values = Console.ReadLine().Split(' ');
//                for (int contador = 0; contador < n; contador++)
//                {
//                    matrix[count, contador] = int.Parse(values[contador]);
//                }
//            }

//            Console.WriteLine("---------------");
//            Console.Write("Negativos: ");

//            for (int count = 0; count < n; count++)
//            {
//                for (int contador = 0; contador < n; contador++)
//                {
//                    if (matrix[count, contador] < 0)
//                    {
//                        Console.Write(matrix[count, contador] + ", ");
//                    }
//                }
//            }

//            Console.WriteLine("---------------");
//            Console.Write("Diagonal pricipal: ");

//            for (int count = 0; count < n; count++)
//            {
//                Console.Write(matrix[count, count] + ", ");
//            }
//        }
//    }
//}

namespace aula81
{
    //Ex Matriz
    class Matriz
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4];

            Console.WriteLine("Digite os números da Matriz 3 x 4:");
            for (int count = 0; count < 3; count++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int contador = 0; contador < 4; contador++)
                {
                    matrix[count, contador] = int.Parse(values[contador]);
                }
            }

            Console.WriteLine("---------------");

            Console.WriteLine("Digite um número para ser procurado: ");
            int x = int.Parse(Console.ReadLine());

            for (int count = 0; count < 3; count++)
            {
                for (int contador = 0; contador < 4; contador++)
                {
                    if (matrix[count, contador] == x)
                    {
                        Console.WriteLine("Posição: ");
                        Console.WriteLine(count + ", " + contador);

                        if(contador > 0)
                        {
                            Console.WriteLine("Esquerda: ");
                            Console.WriteLine(matrix[count, contador - 1]);
                        }

                        if(contador < 3)
                        {
                            Console.WriteLine("Direita: ");
                            Console.WriteLine(matrix[count, contador + 1]);
                        }

                        
                        if(count < 2 )
                        {
                            Console.WriteLine("Baixo: ");
                            Console.WriteLine(matrix[count + 1, contador]);
                        }

                        if(count > 0)
                        {
                            Console.WriteLine("Cima: ");
                            Console.WriteLine(matrix[count - 1, contador]);
                        }


                        Console.WriteLine("------------------------");
                    }
                }
            }
        }
    }
}