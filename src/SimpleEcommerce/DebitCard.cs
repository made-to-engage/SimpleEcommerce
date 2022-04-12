namespace SimpleEcommerce
{
    public class DebitCard
    {
        public string Name => "DebitCard";

        public bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 200)
            {
                return false;
            }

            return true;
        }
    }
}