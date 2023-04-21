// *** Fazer as classes que não tem associação com outras primeiro

namespace ExComposicao.Entities
{
    class Department
    {
        public string Name { get; set; } // Properties

        public Department() // Construtor
        {
        }

        public Department(string name) // Construtor que recebe o nome como argumento
        {
            Name = name; // Atributo Name recebendo name que chegou como entrada no parâmetro do construtor 
        }
    }
}
