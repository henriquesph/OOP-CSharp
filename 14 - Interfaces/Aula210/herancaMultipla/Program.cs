// Herança múltipla e o problema do diamante


//A herança múltipla pode gerar o problema do diamante: uma ambiguidade causada pela
//existência do mesmo método em mais de uma superclasse. Herança múltipla não é
//permitida na maioria das linguagens!

// SOlUÇÃO: Ver segundo exemplo da UML
// para evitar a ambiguidade do método ProcessDocument no ComboDevice, Scanner e Printer viraram interfaces

//ATENÇÃO:
//Isso NÃO é herança múltipla, pois NÃO HÁ REUSO na relação entre ComboDevice e as
//interfaces Scanner e Printer. ComboDevide não herda, mas sim implementa as interfaces (cumpre o contrato).

using System;
using herancaMultipla.Devices;

namespace herancaMultipla
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer()
            {
                SerialNumber = 1000
            };

            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My Dissertation");
            c.Print("My Dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}