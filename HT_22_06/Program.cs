namespace HT_22_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uzcard uzcard = new Uzcard(546, "Nur", 100000);
            uzcard.AddWithBonus(5000);
            Console.WriteLine(uzcard.Money);

            Humo humo = new Humo(665, "Bek", 30000);
            humo.AddWithBonus(5000);
            Console.WriteLine(humo.Money);
        }
    }
}