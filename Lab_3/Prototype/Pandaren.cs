using Lab_1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Pandaren : Hero
    {
        public IState PandarenState { get; set; }

        public int drunkPercantage;
        public Pandaren(string name, int strength, int agility, int intelligence, int weaponDamage, int percentage): 
            base(name, strength, agility, intelligence, weaponDamage)
        {
            PandarenState = new StandingState();
            this.drunkPercantage = percentage;
        }

        public override Hero Clone()
        {
            Pandaren cloned = (Pandaren)this.MemberwiseClone();
            cloned.weapon = new Weapon(this.weapon.damage);
            cloned.name = String.Copy(this.name);
            return cloned;
        }

        public void HealPanda()
        {
            var rand = new Random();
            Console.WriteLine($"Healing on {rand.Next(1,15)}");
        }

        public void Walk()
        {
            Console.WriteLine("Walking ot my target");
        }

        public void DrunkenHaze()
        {
            Console.WriteLine($"Attacked on {drunkPercantage * weapon.damage / 100}");
            Console.WriteLine($"Beer reduced my Intelligence by 1, but maid me angrier: strength and agility increased");
            intelligence--;
            strength++;
            agility++;
        }

        public void HowDumb()
        {
            Console.WriteLine($"My intelligense is {intelligence}");
        }

        public void Atack()
        {
            PandarenState.Attack(this);
        }

        public void Heal()
        {
            PandarenState.Heal(this);
        }

        public void Rest()
        {
            PandarenState.Rest(this);
        }

        public override string ToString()
        {
            return $"Current status:\nIntelligence {intelligence}\nAgility {agility}\nStrength {strength}\nState{PandarenState}";
        }

        public Memento.PandaMemento SaveState()
        {
            return new Memento.PandaMemento(strength, agility, intelligence, weapon.damage, drunkPercantage, PandarenState);
        }

        public void RestoreState(Memento.PandaMemento memento)
        {
            strength = memento.Strength;
            agility = memento.Agility;
            intelligence = memento.Intellignce;
            drunkPercantage = memento.Percentage;
            weapon.damage = memento.WeaponDamage;
            PandarenState = memento.PandaState;
        }
    }
}
