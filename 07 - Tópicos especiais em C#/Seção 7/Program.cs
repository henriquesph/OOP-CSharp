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

// um objeto dateTime armazena o número de TICKS (1 tick = 100 nanosegundos desde o dia 1 da era atual

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
//Console.WriteLine(d3.ticks); imprime um grande número


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

//using System.Globalization;

//DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
//CultureInfo.InvariantCulture);
//DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
//CultureInfo.InvariantCulture); // formato brasileiro
//Console.WriteLine(d1);
//Console.WriteLine(d2);



// Aula 90 - TimeSpan 
// representa uma duração - Tipo valor (struct)

// Armazena na forma de Ticks

//using System;

// Diferentes tipos de construtores

//TimeSpan t1 = new TimeSpan(0, 1, 30);
//Console.WriteLine(t1); // 00: 01: 30
//Console.WriteLine(t1.Ticks); // 900 milhoes

//TimeSpan t1 = new TimeSpan();
//Console.WriteLine(t1); // 00:00:00

//TimeSpan t2 = new TimeSpan(900000000L); // 900 milhoes como no exemplo acima, tem
//// que dar 00:01:30 - foi passado a quantidade de Ticks e o L p/ representar o tipo long
//Console.WriteLine(t2); // 00:01:30

//TimeSpan t3 = new TimeSpan(2, 11, 21); // 02:11:21
//Console.WriteLine(t3);

//TimeSpan t4 = new TimeSpan(1, 2, 11, 21); // dias + horas
//Console.WriteLine(t4);  // 1.02:11:21

//TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321); // dias + horas + minutos + segundos + milisegundos
//Console.WriteLine(t5);  // 1.02:11:21:3210000

// Método From 

//TimeSpan t1 = TimeSpan.FromDays(1.5); // 1.12:00:00 - 1 dia e 12 horas
//TimeSpan t2 = TimeSpan.FromHours(1.5); // 1:30:00
//TimeSpan t3 = TimeSpan.FromMinutes(1.5); // 00:01:30
//TimeSpan t4 = TimeSpan.FromSeconds(1.5); // 00:00:01.5000000
//TimeSpan t5 = TimeSpan.FromMilliseconds(1.5); // 00:00:00.00200000 - era pra das 15 mil, mas ele arredonda p/ cima
//TimeSpan t6 = TimeSpan.FromTicks(900000000L); // 00:01:30
//Console.WriteLine(t1);
//Console.WriteLine(t2);
//Console.WriteLine(t3);
//Console.WriteLine(t4);
//Console.WriteLine(t5);
//Console.WriteLine(t6);



// 91 - Propriedades e formatação com DateTime

//DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
//Console.WriteLine(d);
//Console.WriteLine("1) Date: " + d.Date);
//Console.WriteLine("2) Day: " + d.Day); // 15
//Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek); // wednesday
//Console.WriteLine("4) DayOfYear: " + d.DayOfYear); // 275
//Console.WriteLine("5) Hour: " + d.Hour);
//Console.WriteLine("6) Kind: " + d.Kind);
//Console.WriteLine("7) Millisecond: " + d.Millisecond);
//Console.WriteLine("8) Minute: " + d.Minute);
//Console.WriteLine("9) Month: " + d.Month);
//Console.WriteLine("10) Second: " + d.Second);
//Console.WriteLine("11) Ticks: " + d.Ticks);
//Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay); // dó pega a parte do horário
//Console.WriteLine("13) Year: " + d.Year);



// Formatação(DateTime-> string)

//DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
//string s1 = d.ToLongDateString(); // terça, 10 de janeiro de 2023
//string s2 = d.ToLongTimeString(); // 21:08:05
//string s3 = d.ToShortDateString(); //10/01/2023
//string s4 = d.ToShortTimeString();  // 13:45 hora e minuto
//string s5 = d.ToString(); // 15/08/2023 13:45:58
//string s6 = d.ToString("yyyy-MM-dd HH:mm:ss"); // máscara de formatação
//string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff"); // fff - imprime os milesegundos
//Console.WriteLine(s1);
//Console.WriteLine(s2);
//Console.WriteLine(s3);
//Console.WriteLine(s4);
//Console.WriteLine(s5);
//Console.WriteLine(s6);
//Console.WriteLine(s7);


//DateTime x = new DateTime(2001, 8, 15, 10, 10,10);
//DateTime y = new DateTime(2002, 8, 15, 10, 10, 10);
//TimeSpan z = new TimeSpan(1, 2, 11, 21);


//DateTime a = x.Add(z); // 16/08/2001 12:21:31
//DateTime b = x.AddDays(7); // double
//DateTime c = x.AddHours(2); // 15/08/2001 12:10:10
//DateTime d = x.AddMilliseconds(2);
//DateTime e = x.AddMinutes(3);
//DateTime f = x.AddMonths(2);
//DateTime g = x.AddSeconds(2);
//DateTime h = x.AddTicks(1515515151L); // long
//DateTime i = x.AddYears(1); // int
//DateTime j = x.Subtract(z); // 14/08/2001 07:58:49 - passei um timeSpan
//TimeSpan l = x.Subtract(y); //z diferença de dias (-365.00:00:00) - passei um dateTime

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(d);
//Console.WriteLine(e);
//Console.WriteLine(f);
//Console.WriteLine(g);
//Console.WriteLine(h);
//Console.WriteLine(i);
//Console.WriteLine(j);
//Console.WriteLine(l);


// Aula 92: Propriedades e operações com TimeSpan

//TimeSpan t1 = TimeSpan.MaxValue;
//TimeSpan t2 = TimeSpan.MinValue;
//TimeSpan t3 = TimeSpan.Zero;
//Console.WriteLine(t1);
//Console.WriteLine(t2);
//Console.WriteLine(t3);

// NO CONSOLE:
// 10675199.02:48:05.4775807
//- 10675199.02:48:05.4775808
// 00:00:00

//TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
//Console.WriteLine(t);

//// retorna números inteiros
//Console.WriteLine("Days: " + t.Days);
//Console.WriteLine("Hours: " + t.Hours);
//Console.WriteLine("Minutes: " + t.Minutes);
//Console.WriteLine("Milliseconds: " + t.Milliseconds);
//Console.WriteLine("Seconds: " + t.Seconds);
//Console.WriteLine("Ticks: " + t.Ticks);

//// NO CONSOLE:
//2.03:05:07.0110000
//Days: 2
//Hours: 3
//Minutes: 5
//Milliseconds: 11
//Seconds: 7

//// retorna double
//Console.WriteLine("TotalDays: " + t.TotalDays);
//Console.WriteLine("TotalHours: " + t.TotalHours);
//Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
//Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
//Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

//// NO CONSOLE:
//Ticks: 1839070110000
//TotalDays: 2,1285533680555555
//TotalHours: 51,085280833333336
//TotalMinutes: 3065,11685
//TotalSeconds: 183907,011
//TotalMilliseconds: 183907011

// Operações
//TimeSpan t1 = new TimeSpan(1, 30, 10);
//TimeSpan t2 = new TimeSpan(0, 10, 5);
//TimeSpan sum = t1.Add(t2);
//TimeSpan dif = t1.Subtract(t2);
//TimeSpan mult = t2.Multiply(2.0);
//TimeSpan div = t2.Divide(2.0);

//Console.WriteLine(t1);
//Console.WriteLine(t2);
//Console.WriteLine(sum);
//Console.WriteLine(dif);
//Console.WriteLine(mult);
//Console.WriteLine(div);

//// No Console:
//01:30:10
//00:10:05
//01:40:15
//01:20:05
//00:20:10
//00:05:02.5000000



// Aula 93 - DateTimeKind e Padrão ISO 8601

// Tipo enumerado

// 3 Valores:
// - Local: fuso horário do sistema. Exemplo: São Paulo = GMT -3 - Baseado no utc - fusorário de 3h
// - utc: fuso horário GMT (Greenwich Mean Time) - Fuso horário de Londres
// - Unspecified

//Boa prática
//• Armazenar em formato UTC (texto: BD / Json / XML)
//• Instanciar e mostrar em formato Local

//Para converter um DateTime para Local ou Utc, você deve usar:
//• myDate.ToLocalTime()
//• myDate.ToUniversalTime()

//DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local); // Se instancia separando por virgulas - método construtor
//DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
//DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
//Console.WriteLine("d1: " + d1);
//Console.WriteLine("d1 Kind: " + d1.Kind); // imprime o tipo: local
//Console.WriteLine("d1 to Local: " + d1.ToLocalTime()); // imprime a msm coisa
//Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime()); // imprime 3 horas a mais p/ converter ao horário universal

//Console.WriteLine("d2: " + d2);
//Console.WriteLine("d2 Kind: " + d2.Kind); // imprime o tipo: utc
//Console.WriteLine("d2 to Local: " + d2.ToLocalTime()); // imprime com 3h a menos
//Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime()); // imprime a mesma coisa

//Console.WriteLine("d3: " + d3);
//Console.WriteLine("d3 Kind: " + d3.Kind); // tipo: unspecified
//Console.WriteLine("d3 to Local: " + d3.ToLocalTime()); // subtrai 3h
//Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime()); // soma 3h



// Padrão ISO 8601: yyyy-MM-ddTHH:mm:ssZ (indica que está no formato utc)

// Z: indica que está em string e utc
// T: Separa data do horário

using System;

DateTime d1 = DateTime.Parse("2000-08-15 13:05:58"); // na hora de imprimir a data, se troca o traço pela barra - método estático que passa de string para objeto (tipo enumerado)
DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // instanciada pro horário LOCAL da máquina (3h a menos)

Console.WriteLine("d1: " + d1);
Console.WriteLine("d1 Kind: " + d1.Kind);
Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
Console.WriteLine();


Console.WriteLine("d2: " + d2);
Console.WriteLine("d2 Kind: " + d2.Kind);
Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
Console.WriteLine();


Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado - foi instanciada LOCALMENTE - mantém o horário
Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // primeiro tem que passar para utc

// RESULTADO:

//d1: 15/08/2000 13:05:58
//d1 Kind: Unspecified
//d1 to Local: 15/08/2000 10:05:58 - diminuiu 3h
//d1 to Utc: 15/08/2000 16:05:58 - aumentou 3h

//d2: 15/08/2000 10:05:58
//d2 Kind: Local
//d2 to Local: 15/08/2000 10:05:58
//d2 to Utc: 15/08/2000 13:05:58

//2000 - 08 - 15T10: 05:58Z // manteve o horario local
//2000 - 08 - 15T13: 05:58Z // passou o horário utc