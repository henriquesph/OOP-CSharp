// Ver mais detalhes na apostila

// Paradigma funcional de programação
// Baseado no formalismo matemático Cálculo Lambda (Church 1930)


// Transparência referencial:
// Uma função possui transparência referencial se seu resultado for sempre o mesmo para os mesmos dados de entrada. Benefícios: simplicidade e previsibilidade.

// Funções são objetos de primeira ordem (ou primeira classe)
// Isso significa que funções podem, por exemplo, serem passadas como parâmetros de métodos, bem como retornadas como resultado de métodos

// Inferência de tipos



// Expressividade / "como" vs. "o quê"


//int sum = 0;
//foreach (int x in list)
//{
//    sum += x;
//}
//vs.
//int sum = list.Aggregate(0, (x, y) => x + y);



//O que são "expressões lambda"?
//Em programação funcional, expressão lambda corresponde a uma
//função anônima de primeira classe.


// Cálculo Lambda = formalismo matemático base da programação funcional

// Expressão lambda = função anônima de primeira classe


// --------------------X-----------------------

// AULA 230: Introdução a Delegates

//• É uma referência (com type safety) para um ou mais métodos
//• É um TIPO referência, diferente de struct que é um tipo valor

//• Usos comuns:
//• Comunicação entre objetos de forma flexível e extensível (eventos / callbacks)
//• Parametrização de operações por métodos (programação funcional)



//Delegates pré-definidos
//• Action
//• Func
//• Predicate

using Course.Services;

namespace Course
{
    delegate double BinaryNumericOperation(double n1, double n2); // type safety: só funciona passando os mesmos parâmetros (assinatura da função), não funciona com a função square que só passa 1 double, pois o delegate neste caso pede 2
    class Program
    {
        
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            // BinaryNumericOperation op = CalculationService.Max;

            // SINTAXE ALTERNATIVA - mais "verbosa":
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);

            //double result = op(a, b);
            // SINTAXE ALTERANATIVA - Invoke
            double result = op.Invoke(a, b);
            Console.WriteLine(result);

        }
    }
}