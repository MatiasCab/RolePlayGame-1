using System;
using Roleplay;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Paladin paladin1 = new Paladin("Arthur");
            Console.WriteLine($"Hello, my name is {paladin1.Name} and I have a base health of {paladin1.Health}, I also have a defence of {paladin1.Defence} and my base damage is {paladin1.BaseDamage}");
            Durendal Durendal1 = new Durendal();
            Console.WriteLine(" ");
            Console.WriteLine($"This is the {Durendal1.WeaponType} named {Durendal1.Name}, it's current durability is {Durendal1.Durability} and it seams to multiply the Base Damage {Durendal1.BaseDamageMultiplier} times, it also seems to have somthing inscribed on it");
            Console.WriteLine(" ");
            Console.WriteLine($"It says,\n\"{Durendal1.Description}\"");
            Greatshield_of_Artorias Greatshield_of_Artorias1 = new Greatshield_of_Artorias();
            Console.WriteLine(" ");
            Console.WriteLine($"This is the {Greatshield_of_Artorias1.WeaponType} named {Greatshield_of_Artorias1.Name}, it's current durability is... strange its current durability is {Greatshield_of_Artorias1.Durability} but that is rather a high number, ignoring that it seams to add {Greatshield_of_Artorias1.Defence} defence to its wielder");
            Console.WriteLine(" ");
            Console.WriteLine($"It's description says,\n\"{Greatshield_of_Artorias1.Description}\" so thats why it durability was that high");
        }
    }
}
