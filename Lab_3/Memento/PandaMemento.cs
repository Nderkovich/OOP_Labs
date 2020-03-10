using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.State;

namespace Lab_1.Memento
{
    class PandaMemento
    {
        public int Intellignce { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int WeaponDamage { get; set; }
        public int Percentage { get; set; }
        public IState PandaState { get; set; }
        public PandaMemento(int strength, int agility, int intelligence, int weaponDamage, int percentage,  IState state)
        {
            Strength = strength;
            Agility = agility;
            Intellignce = intelligence;
            WeaponDamage = weaponDamage;
            Percentage = percentage;
            PandaState = state;
        }
    }
}
