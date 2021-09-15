using System;
using System.Collections;

namespace Roleplay
{
    public class Inventory
    {
        static ArrayList wizardInventory = new ArrayList {};
        public static ArrayList WizardInventory
        {
            get
            {
                return Inventory.wizardInventory;
            }
        }

        public static void AddElement(string raza, InventoryElements elemento)
        {
            bool CorrectRaza = false;
            if (raza=="Wizard")
            {
                CorrectRaza=true;
                Inventory.wizardInventory.Add(elemento);
                Console.WriteLine("Element added");
            }

            if (!CorrectRaza)
            {
                Console.WriteLine("Raza invalida");
            }
        }

        public void RemoveElement()
        {

        }
    }

}