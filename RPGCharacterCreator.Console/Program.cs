using RPGCharacterCreator.Classes;
using System;

namespace RPGCharacterCreator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please enter a class (1 for Warrior, 2 for Wizard or 3 for Archer: ");
            var classInput = System.Console.ReadLine();
            int charClass = Int32.Parse(classInput);
            var character = new Character(charClass);
            System.Console.WriteLine($"Character class: {character.Class.ToString()}");
            System.Console.ReadLine();
        }
    }
}
