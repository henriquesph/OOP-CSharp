using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seção_6
{
    public class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Empregado (int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void aumentarSalario(double percentual) { 
            Salario += Salario * percentual / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario + ", ";
        }
    }
}
