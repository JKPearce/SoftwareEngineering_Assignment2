using System;
using System.Collections;

namespace Mazegame.Entity
{
    public class NonPlayerCharacter : Character
    {
        private Boolean hostile;
        private String dialogue;
        

        public NonPlayerCharacter(String name, String dialogue, Boolean hostile)
        {
            this.Name = name;
            this.dialogue = dialogue;
            this.hostile = hostile;
        }

        public String Dialogue
        {
            get { return dialogue; }
            set { dialogue = value; }
        }

        public Boolean Hostile
        {
            get { return hostile; }
            set { hostile = value; }
        }
    }
}