using System;

namespace herancaMultipla.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document) // herda da interface Iprinter
        {
            Console.WriteLine("ComboDevice Print" + document);
        }

        public override void ProcessDoc(string document)  // herda da classe abstrata Device
        {
            Console.WriteLine("ComboDevice processing" + document);
        }

        public string Scan() // Herda de IScanner
        {
            return "ComboDevice scan result";
        }
    }
}
