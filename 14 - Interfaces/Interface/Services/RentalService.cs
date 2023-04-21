using System;
using Interface.Entities;
using Interface.Services;

namespace Interface.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        /*private BrazilTaxService _brazilTaxService = new BrazilTaxService();*/ // forma inadequada, será mudada
        private ITaxService _taxService; // inverção de controle por meio de injeção de dependência (Um dos princípios SOLID)
        // não se instancia a dependência como antes

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) // declarar a Interface no construtor
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            //double tax = _brazilTaxService.Tax(basicPayment);
            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
        // dessa forma temos 2 serviços desaclopados entre si por meio da interface
    }
}
