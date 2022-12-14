namespace Lab1
{
    internal class Money
    {
        private int _nominal;
        private int _amount;

        public int Nominal
        {
            get { return _nominal; }
            set { _nominal = value; }
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public int Sum { get => _nominal * _amount; }

        public Money(int nominal, int amount)
        {
            Nominal = nominal;
            Amount = amount;
        }

        public string GetInfo() => $"Nominal: {_nominal}; amount: {_amount}";

        public bool IsEnoughToBuy(int price) => Sum >= price;

        public int HowManyIsPossibleToBuy(int price) => Sum / price;
    }
}
