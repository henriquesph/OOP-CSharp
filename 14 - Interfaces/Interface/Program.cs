//INTERFACE

//Interface é um tipo que define um conjunto de operações que uma classe (ou struct) deve implementar.

//interface IShape
//{
//    double Area();
//    double Perimeter();
//}

//Pra quê interfaces?

//• Para criar sistemas com baixo acoplamento e flexíveis. (alterar só na classe que implementa a interface do que em 2 classes, melhor manutenção
//A interface estabelece um contrato que a classe (tipo referência) ou struct (tipo valor) DEVE cumprir.


// AULA 204 - solução sem interface

using System;
using System.ComponentModel;
using System.Globalization;
using Interface.Entities;
using Interface.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car Model: ");
            string model = Console.ReadLine();
           
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm):");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Return (dd/MM/yyyy hh:mm):");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.Write("Enter price per day");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            //RentalService rentalService = new RentalService(hour, day);
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService()); // passou no parâmentro a dependência (injeção de dependência), classe concreta BrazilTaxService, que é a implementação da interface, 
            // a classe RentalService depende do ITaxService
            // no contrutor se espera a interface (ItaxService), mas a a BrazilTaxService (subtipo) é aceita por meio de upcasting 
            // BrazilTaxService é um TaxService
            // Inversão de controle: quem decidiu o controle não foi a classe rentalService, foi em outro lugar, nesse caso no programa principal

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}

//INVERSÃO DE CONTROLE
//• Inversão de controle
//Padrão de desenvolvimento que consiste em retirar da classe a
//responsabilidade de instanciar suas dependências.

//• INJEÇÃO DE DEPENDÊNCIA
//É uma forma de realizar a inversão de controle: um componente externo
//instancia a dependência, que é então injetada no objeto "pai". Pode ser
//implementada de várias formas:
//• Construtor
//• Objeto de instanciação (builder / factory) - ? ver mais
//• Container / framework ? ver mais