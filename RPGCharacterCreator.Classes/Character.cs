using System;

namespace RPGCharacterCreator.Classes
{
    public class Character
    {
        public Character(int charClass)
        {
            var classesLength = Enum.GetValues(typeof(Classes)).Length;
            if (charClass > classesLength)
            {
                charClass = classesLength;
            }
            else if (charClass <= 0)
            {
                charClass = 1;
            }
            Class = (Classes)charClass;
        }
        public Classes Class { get; set; }

        public int Strength { get; set; }
        public int Magic { get; set; }
        public int Ranged { get; set; }

        public enum Classes
        {
            Warrior = 1,
            Wizard = 2,
            Archer = 3
        }
    }    
}
