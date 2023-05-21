// Conjunto: Estrutura de dados

// Representados pelas coleções HashSet<T> e Sorted<T>

//HashSet<T> e SortedSet<T>

//• Representa um conjunto de elementos (similar ao da Álgebra) • Não admite repetições (caso precise usar no lugar de List)
//• Elementos não possuem posição (lista e vetor tem posição)
//• Acesso, inserção e remoção de elementos são rápidos
//• Oferece operações eficientes de conjunto: interseção, união, diferença.
//
//• HashSet • https://msdn.microsoft.com/en-us/library/bb359438(v=vs.110).aspx
//
//• SortedSet • https://msdn.microsoft.com/en-us/library/dd412070(v=vs.110).aspx



//Diferenças

//• HashSet • Armazenamento em tabela hash (cada elemento tem um código associado)
//• Extremamente rápido: inserção, remoção e busca O(1) - (passo: calculo do hash - pode haver colisão)
//• A ordem dos elementos não é garantida (ex: na hora de percorrer os elementos não será acessado na ordem de inserção)

//• SortedSet • Armazenamento em árvore
//• Rápido: inserção, remoção e busca O(log(n)) ex: Acesso a uma árovre binária balanceada: 2 elevado a 10 = 1024, ou seja, o algoritmo executa 10 operações pra buscar 1024 elementos
//• Os elementos são armazenados ordenadamente conforme implementação
//IComparer<T>


//Alguns métodos importantes

//• Add
//• Clear • Contains
//• UnionWith(other) -operação união: adiciona no conjunto os elementos do outro conjunto, sem repetição
//• IntersectWith(other) -operação interseção: remove do conjunto os elementos não contidos em other • ExceptWith(other) -operação diferença: remove do conjunto os elementos contidos em other • Remove(T) • RemoveWhere(predicate)


//using System;
// using System.Collections.Generic; não foi nescessário


//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            HashSet<string> set = new HashSet<string>(); // conjunto instanciado na memória

//            set.Add("TV");
//            set.Add("Notebook");
//            set.Add("Tablet");

//            Console.WriteLine(set.Contains("Notebook")); // True

//            foreach(string p in set) // só pode ser esse looping pq não tem posição definida
//            {
//                Console.WriteLine(p); // imprime todos os elementos
//            }
//        }
//    }
//}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10};
            SortedSet<int> b = new SortedSet<int>() {5, 6, 7, 8, 9, 10};
            //PrintCollection(a);

            // UNION
            SortedSet<int> c = new SortedSet<int>(a); // Construtor utilizado: pega todos os elementos de a e insere em c
            c.UnionWith(b); // insere todos os elementos de b sem repetição
            PrintCollection(c); // SortedSet sempre vai exibir os elementos ordenados


            // INTERSECTION // implementação mais adequada que a lista, que teria que comparar elemento por elemento manualmente
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); 
            PrintCollection(d);

            // DIFFERENCE
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(e); 
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection) // IEnumerable - interface implementada de todas as coleções (list, sorted set, hashset, vect...) do pacote System.Collections (Dentro dele tem a função GetEnumerator(): retorna um Enumerator para que possa percorrer a coleção de forma padronizada
        { 
            foreach(T obj in collection) // funciona em cima de coleções que implementam o IEnumerable, ele procura o Enumerator
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
                    
        } 
    }
}