namespace H34111122_practice_3_2
{
    internal class Order
    {
        public int index, amount;
        public string option, user;

        public Order(int number, int amount, string option, string user)
        {
            index = number;
            this.amount = amount;
            this.option = option;
            this.user = user;
        }
    }
}
