namespace Mazegame.Entity {
	public class Weapon : Item {

		public Mazegame.Entity.Dice m_Dice;

        public Weapon(string label, int value, double weight, string description)
            : base(label, value, weight, description)
	{

	}

	}
}