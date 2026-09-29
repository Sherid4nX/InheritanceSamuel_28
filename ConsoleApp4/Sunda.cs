namespace GameInheritanceDemo
{
    public class Sunda : Dukun
    {
        public int silatKnowledge;

        public Sunda()
        {
            Console.WriteLine("> Konstruktor default Sunda <");
        }

        public Sunda(int silatKnowledge, int spellPower, string id, string name, int basePower, string address)
        : base(spellPower, id, name, basePower, address)
        {
            Console.WriteLine("> Konstruktor berparameter Sunda <");
            this.silatKnowledge = silatKnowledge;
        }

        public void DisplayData1()
        {
            base.DisplayBaseData();
            Console.WriteLine("SILAT KNOWLEDGE = " + silatKnowledge);
            Console.WriteLine("GRAND TOTAL POWER = " + (GetBasePower() + spellPower + silatKnowledge));
            Console.WriteLine("==================");
        }
    }
}