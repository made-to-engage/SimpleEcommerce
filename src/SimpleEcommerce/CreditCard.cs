namespace SimpleEcommerce
{
    public class CreditCard
    {
        public string Name => "CredtCard";

        public bool Pay(decimal amount)
        {
            if (amount <= 50m || amount > 500)
            {
                return false;
            }

            return true;
        }
    }
}