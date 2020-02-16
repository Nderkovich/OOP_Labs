using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.Factories;
using Lab_1.UnitInterfaces;

namespace Lab_1
{
    class Application
    {
        private IUnitFactory unitFactory;
        private List<ILightUnit> lighUnits = new List<ILightUnit>();
        private List<IWorkerUnit> workerUnits = new List<IWorkerUnit>();
        private IHeroUnit heroUnit;
        
        public Application(IUnitFactory factory)
        {
            this.unitFactory = factory;
        }

        //Unit creating
        public void CreateWorkerUnits(int number) 
        {
            for (int i = 0; i < number; i++)
            {
                workerUnits.Add(unitFactory.CreateWorker());
            }
        }
        public void CreateLightUnits(int number)
        {
            for (int i = 0; i < number; i++)
            {
                lighUnits.Add(unitFactory.CreateLightUnit());
            }
        }

        //Hero unit act
        public void CreateHero()
        {
            heroUnit = unitFactory.CreateHero();
        }
        public void HeroSpeak()
        {
            Console.WriteLine(heroUnit.Speak());
        }
        public void HeroUserAbility()
        {
            heroUnit.UseAbility();
        }

        //Worker unit act
        public void WorkersBuild()
        {
            foreach (var worker in workerUnits)
            {
                worker.Build();
            }
        }

        //Light unit act
        public void LighTUnitAttack(int damage)
        {
            foreach (var light in lighUnits)
            {
                light.Attack(damage);
            }
        }
    }
}
