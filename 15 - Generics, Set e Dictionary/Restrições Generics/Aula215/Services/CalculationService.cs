namespace Aula215.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable // 
            // Retorna T e Método do tipo <T> mas tem que ser do tipo comparável de maior e menor (CompareTo)
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0) // - 1 menor, 0 igual e 1 maior
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
