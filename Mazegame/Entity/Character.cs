using System;

namespace Mazegame.Entity
{
    public class Character
    {
        private int agility;
        private int lifePoints;
        private String name;
        private int strength;
        public Mazegame.Entity.Dice m_Dice;
        public Mazegame.Entity.Item m_Item;
        public Mazegame.Entity.Shield m_Shield;
        public Mazegame.Entity.Weapon m_Weapon;
        public Mazegame.Entity.Armor m_Armor;

        public Character()
        {
        }

        public Character(String name)
        {
            Name = name;
        }

        public int Agility
        {
            get { return agility; }
            set { agility = value; }
        }

        public int LifePoints
        {
            get { return lifePoints; }
            set { lifePoints = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
    }
}