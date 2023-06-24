
namespace HT_22_06
{
    internal class Humo : CardClass
    {
        public Humo(int number, string holderName, int money) : base(number, holderName, money)
        {
        }

        public override bool Pay(long cost)
        {
            if (cost > Money || Money < 0)
            {
                return false;
            }
            else
            {
                Money -= cost;
                return true;
            }
        }
        public bool PayWireless(long cost)
        {
            if (cost > 50000 || Money - cost < 0)
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
