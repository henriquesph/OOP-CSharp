using System;
using System.Security.Cryptography.X509Certificates;

namespace herancaMultipla.Devices
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing" + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
