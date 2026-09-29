namespace GameInheritanceDemo
{
    public class Dukun : Character
    {
        public int spellPower;

        public Dukun()
        {
            Console.WriteLine("> Konstruktor default Dukun<");
        }

        public Dukun(int spellPower, string id,string name, int basePower, string address)
        : base(id, name, basePower, address)
        {
            Console.WriteLine("> Konstruktor berparameter Dukun <");
            this.spellPower = spellPower;
        }

        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("SPELL POWER = " + spellPower);
            Console.WriteLine("TOTAL POWER = " + (GetBasePower() + spellPower));
            Console.WriteLine("==================");
        }
    }
}