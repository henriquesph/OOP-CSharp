namespace seção_6
{
    struct Point // ponto carteziano
    {
        public double X;
        public double y;

        public override string ToString()
        {
            return "(" + X + " ," + y + ")";
        }
    }
}
