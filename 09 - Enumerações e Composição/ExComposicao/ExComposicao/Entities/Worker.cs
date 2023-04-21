using ExComposicao.Entities.Enums; // name espace do WorkerLevel
//using System.Collections.Generic; // para usar a lista - já está vindo como padrão?

// CONSTRUÇÃO DO MODELO DE DOMÍNIO: representação das entidades com as classes / não é o programa principal

namespace ExComposicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } // Tipo WorkLevel
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Composição - Associação de 2 classes (objetos) diferentes
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker () // construtor sem parâmetros não é obrigado a declarar objeto com todos
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            // não é usual colocar um lista no construtor na associação de objetos, será colocada no método abaixo de adicionar e remover
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}


