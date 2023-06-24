
namespace HT_22_06
{
    internal class Uzcard : CardClass
    {
        public Uzcard(int number, string holderName, int money) : base(number, holderName, money)
        {
        }

        public override decimal Bonus { get => base.Bonus; set => base.Bonus = 5; }
        public override bool Pay(long cost)
        {
            if (Money < cost || Money < 0)
            {
                return false;
            }
            else
            {
                Money -= cost;
                return true; 
            }
        }
        
    }
}
