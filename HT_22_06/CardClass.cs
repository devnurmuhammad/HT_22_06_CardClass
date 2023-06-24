
namespace HT_22_06
{
    public abstract class CardClass
    {
        public long Number { get; set; }
        public string HolderName { get; set; }
        public long Money { get; set; }
        private decimal bonus = 0;
        public virtual decimal Bonus {
            get { return bonus; } 
            set { bonus = value; } 
        }
        public CardClass(int number, string holderName, int money)
        {
            Number = number;
            HolderName = holderName;
            Money = money;
        }
        public abstract bool Pay(long cost);
        public long Add(long amount)
        {
            Money += amount;
            return Money;
        }

        public long AddWithBonus(long bonus)
        {
            Money += bonus;
            return Money;
        }
    }
}
