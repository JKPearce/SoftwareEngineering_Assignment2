using System;

namespace Mazegame.Entity
{
    public class Dice
    {
        private int faces;
        private static readonly Random generator = new Random();

        public Dice(int faces)
        {
            this.faces = faces;
        }

        public int Roll()
        {
            return generator.Next(faces) + 1;
        }

    }
}