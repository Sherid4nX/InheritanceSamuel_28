namespace GameInheritanceDemo
{
    public class Suki : Character
    {
        public int bonus;

        public Suki()
        {
            Console.WriteLine("> Konstruktor default Suki <");
        }

        public Suki(int bonus, string id,string name, int basePower, string address)
        : base(id, name, basePower, address)
        {
            Console.WriteLine("> Konstruktor berparameter Suki <");
            this.bonus = bonus;
        }

        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("BONUS       = " + bonus);
            Console.WriteLine("TOTAL POWER = " + (GetBasePower() + bonus));
            Console.WriteLine("==================");
        }
    }
}