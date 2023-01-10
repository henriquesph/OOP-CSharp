// Aula 86 - Estrutura switch case

//int x = int.Parse(Console.ReadLine());
//string day;
//switch (x)
//{
//    case 1:
//        day = "Sunday";
//        break;
//    case 2:
//        day = "Monday";
//        break;
//    case 3:
//        day = "Tuesday";
//        break;
//    case 4:
//        day = "Wednesday";
//        break;
//    case 5:
//        day = "Thursday";
//        break;
//    case 6:
//        day = "Friday";
//        break;
//    case 7:
//        day = "Saturday";
//        break;
//    default:
//        day = "Invalid value";
//        break;
//}
//Console.WriteLine("Day: " + day);



// Aula 87 Expressão condicional Ternária
// * Forma resumida do if / else

//double preco = 34.5;
//double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;



// Aula 88 - Funções para string
// string é uma variável imutável, ao atribuir um novo valor ela não é
// alterada, ela deixa de apontar para um objeto no HEAP para apontar para outro
// pois o string é do tipo classe

//string original = "abcde FGHIJ ABC abc DEFG ";
//string s1 = original.ToUpper();
//string s2 = original.ToLower();
//string s3 = original.Trim(); // retira os espaços em branco - além de 2
//int n1 = original.IndexOf("bc");
//int n2 = original.LastIndexOf("bc");
//string s4 = original.Substring(3);
//string s5 = original.Substring(3, 5);
//string s6 = original.Replace('a', 'x');
//string s7 = original.Replace("abc", "xy");
//bool b1 = String.IsNullOrEmpty(original);
//bool b2 = String.IsNullOrWhiteSpace(original);
//Console.WriteLine("Original: -" + original + "-");
//Console.WriteLine("ToUpper: -" + s1 + "-");
//Console.WriteLine("ToLower: -" + s2 + "-");
//Console.WriteLine("Trim: -" + s3 + "-");
//Console.WriteLine("IndexOf('bc'): " + n1);
//Console.WriteLine("LastIndexOf('bc'): " + n2);
//Console.WriteLine("Substring(3): -" + s4 + "-");
//Console.WriteLine("Substring(3, 5): -" + s5 + "-");
//Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
//Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
//Console.WriteLine("IsNullOrEmpty: " + b1);
//Console.WriteLine("IsNullOrWhiteSpace: " + b2);



// Aula 89 - DateTime

//DateTime d1 = new DateTime(2000, 8, 15); // data as 00:00h
//DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58); // data + horas : minutos : segundos
//DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);  // milissendos não é considerado

//Console.WriteLine(d1);
//Console.WriteLine(d2);
//Console.WriteLine(d3);

//DateTime d1 = DateTime.Now; // data e horário do dispositivo
//DateTime d2 = DateTime.UtcNow; // horário universal - data e hora
//DateTime d3 = DateTime.Today; // data ás 00:00h
//Console.WriteLine(d1);
//Console.WriteLine(d2);
//Console.WriteLine(d3);


// Data.time.Parse() converte para o formato correto

//DateTime d1 = DateTime.Parse("2000-08-15");
//DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
//DateTime d3 = DateTime.Parse("15/08/2000");
//DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
//Console.WriteLine(d1);
//Console.WriteLine(d2);
//Console.WriteLine(d3);
//Console.WriteLine(d4);


// ParseExact - passar máscara de formatação

using System.Globalization;

DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
CultureInfo.InvariantCulture);
DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
CultureInfo.InvariantCulture); // formato brasileiro
Console.WriteLine(d1);
Console.WriteLine(d2);