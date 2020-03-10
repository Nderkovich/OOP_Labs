using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.Factories;

namespace Lab_1.AbstractFactory
{
    class Client
    {
        static public int UnitsEnter()
        {
            Console.WriteLine("Enter number of units to create");
            int numberOfUnitsToCreate;
            Int32.TryParse(Console.ReadLine(), out numberOfUnitsToCreate);
            return numberOfUnitsToCreate;
        }

        static public void emulation()
        {
            IUnitFactory factory;
            Console.WriteLine("Enter race\n1 Humans\n2 Undead");
            string factoryInput = Console.ReadLine();
            if (factoryInput == "1")
            {
                factory = new HumanFactory();
            }
            else if (factoryInput == "2")
            {
                factory = new UndeadFactory();
            }
            else
                throw new Exception();
            Application app = new Application(factory);

            bool isChoosing = true;
            while (isChoosing)
            {
                Console.WriteLine("1 Create workers\n2 Create light units\n3 Create hero unit\n4 Exit");
                string unitInput = Console.ReadLine();
                switch (unitInput)
                {
                    case "1":
                        app.CreateWorkerUnits(UnitsEnter());
                        break;
                    case "2":
                        app.CreateLightUnits(UnitsEnter());
                        break;
                    case "3":
                        app.CreateHero();
                        break;
                    case "4":
                        isChoosing = false;
                        break;
                }
            }

            app.HeroSpeak();
            app.HeroUserAbility();
            app.LighTUnitAttack(20);
        }
    }
}
