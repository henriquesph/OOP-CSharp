using System;
using System.Reflection.Metadata;

namespace herancaMultipla.Devices
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document) // herda da classe abstrata Device
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document) // herda da interface Iprinter
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}