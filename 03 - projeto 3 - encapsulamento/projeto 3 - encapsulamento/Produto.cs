using System.Globalization;

// Encapsulamento - serve para manter a integridade do objeto, só ser acessível o que é necessário para seu funcionamento (Consistência)
// não é usual no C# - é mais adequado o uso de properties
// private - modificador de acesso que o membro da classe seja modificado dentro da própria classe - nível mais restrito

namespace Course
{
    class Produto
        // Ordem sugerida de implementação dos membros de classe (convenção):
        // 1 - Atributos privados
        // 2 - Propriedades autoimplementadas (auto properties)
        // 3 - Construtores
        // 4 - Propriedades customizadas
        // 5 - Outros métodos da classe

        // modificadores de acesso: public, protected internal, internal, protected, private protected, private
    {
        public string _nome; // padrão de nome private - underline e letra minuscula - faz parte da implementação do propertie
        //public double _preco;
        //private int _quantidade; // Encapsulamento - não pode ser alterado por outra classe, só por um método

        // Auto Properties (propriedade auto implementada) - Maneira simplificada de implementar propriedades que não nescessitam de lógica na implementação de get e set
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }
        
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            //_preco = preco; // implementação do propertie substituida pelo auto properties
            //_quantidade = quantidade;
            Preco = preco;
            Quantidade = quantidade;
        }

        //public string GetNome()
        //{
        //    return _nome;
        //}

        //public void SetNome(string nome) // Além de proteger o objeto de ser alterado direto no atributo, podemos colocar regras para alteração
        //{
        //    if(nome != null & nome.Length > 1) {
        //        _nome = nome;
        //    }
        //}

        //public double GetPreco()
        //{
        //    return _preco;
        //}

        //public int GetQuantidade()
        //{
        //    return _quantidade;
        //}

        // Properties - consegue acessar e modificar - vantagens do atributo e método

        public string Nome // propriedade customizadas
        {
            get { return _nome; }
            set
            {
                if (value != null & value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //public double Preco // implementação propertie - apaguei, autopropertie substituiu
        //{
        //    get { return _preco; }
        //}

        //public int Quantidade
        //{
        //    get { return _quantidade; }
        //}

        // Auto Properties (propriedade auto implementada) - Maneira simplificada de implementar propriedades que não nescessitam de lógica na implementação de get e set



        public double ValorTotalEmEstoque()
        {
            //return _preco * _quantidade; // substituição propertie por auto propertie
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            //_quantidade += quantidade;
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            //_quantidade -= quantidade;
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            //+ _preco.ToString("F2", CultureInfo.InvariantCulture)
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            //+ _quantidade
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}