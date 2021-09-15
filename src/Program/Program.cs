using System;
using System.Collections;

namespace Roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory.AddElement("Wizard",new InventoryElements("Zaphiro","Un baston magico cpaz de brindar mucho mana","Baston",0,100,2000));
            Inventory.AddElement("Wizard",new InventoryElements("Ringlife","Un anillo magico capaz de subir la defensa de su usuario","Anillo",500,0,250));
            Wizard Mago1 = new Wizard ("Gandalf", 2000, 200, 350, 5000, new ArrayList{"Zaphiro","Ringlife"});
            Wizard Mago2 = new Wizard ("Gandalf", 2000, 200, 350, 5000, new ArrayList{"Zaphiro","Ringlife"});
            Console.WriteLine(Mago1.GetStatus());
            Console.WriteLine(Mago1.GetInventarySpecifications());
            GameActions.Atack(Mago1,Mago2);
        }
        
    }
}
