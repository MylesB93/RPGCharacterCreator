using System;

namespace RPGCharacterCreator.Classes
{
    public class Character
    {
        public Character(int charClass)
        {
            Class = (Classes)charClass;
        }
        public Classes Class { get; set; }

        public int Strength { get; set; }
        public int Magic { get; set; }
        public int Ranged { get; set; }

        public enum Classes
        {
            Warrior,
            Wizard,
            Archer
        }
    }    
}
