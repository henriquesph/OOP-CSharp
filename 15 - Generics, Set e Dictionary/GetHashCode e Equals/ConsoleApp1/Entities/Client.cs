namespace ConsoleApp1.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj) // criei regra para definir que é igual pelo email
        {
            if (!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client; // downcasting
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}