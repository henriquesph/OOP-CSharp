namespace Generics
{
    class PrintService<T> // Parametrizado com o tipo T: tipo genérico
        // Pode ser qualquer letra <E>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        //public void AddValue(int value) // só vai servir para string
        public void AddValue(T value) // substitui para o object que é superclasse
        {
            if(_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public object First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Print Service is empty");
            }
            return _values[0];
        }

        public void Print() {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.Write("]");
        }
    }
}
