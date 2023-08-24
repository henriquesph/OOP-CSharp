//Dictionary - MAP (outras linguagens) < TKey, TValue >

//• É uma coleção de pares chave / valor • Não admite repetições do objeto chave (Estrutura baseada em Hash)
//• Os elementos são indexados pelo objeto chave (não possuem posição) • Acesso, inserção e remoção de elementos são rápidos
//• Uso comum: cookies, local storage, qualquer modelo chave-valor


//• Dictionary
//• https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.110).aspx


//• SortedDictionary
//• https://msdn.microsoft.com/en-us/library/f7fta44c(v=vs.110).aspx


// ---------------x---------------------

//Diferenças
//• Dictionary
//• Armazenamento em tabela hash (mesmas propriedades do hashset)
//• Extremamente rápido: inserção, remoção e busca O(1)
//• A ordem dos elementos não é garantida

//• SortedDictionary (mesmas propriedades do sortedSet)
//• Armazenamento em árvore
//• Rápido: inserção, remoção e busca O(log(n)) • Os elementos são armazenados ordenadamente conforme implementação IComparer<T>


// ---------------------x--------------

//Alguns métodos importantes

//• dictionary[key] -acessa o elemento pela chave informada
//• Add(key, value) -adiciona elemento(exceção em caso de repetição) 
//• Clear() - esvazia a coleção
//• Count - quantidade de elementos
//• ContainsKey(key) -verifica se a dada chave existe
//• ContainsValue(value) -verifica se o dado valor existe
//• Remove(key) -remove um elemento pela chave

using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "93949949";
            cookies["phone"] = "93494484"; // não aceita repetições, valor é sobrescrito.

            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if(cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }


            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES");
            //foreach(KeyValuePair<string, string> item in cookies)
            // OU NA FORMA RESUMIDA
            foreach(var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}