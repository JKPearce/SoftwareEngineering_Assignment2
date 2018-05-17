namespace Mazegame.Entity
{
    public class Armor : Item
    {
        private int bonus;

        public Armor(string label, int value, double weight, string description)
            : base(label, value, weight, description)
        {
        }

        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
    }
}