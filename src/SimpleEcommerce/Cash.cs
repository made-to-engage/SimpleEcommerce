namespace SimpleEcommerce
{
    public class Cash
    {
        public string Name => "Cash";

        public bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 100)
            {
                return false;
            }

            return true;
        }
    }
}