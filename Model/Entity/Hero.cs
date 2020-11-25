using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public abstract class Hero : IMovable, IHit
    {

        protected Hero(int s, int a, int i)
        {
            Strength = s;
            Agility = a;
            Intelligence = i;
            Health = CalculateHealth();
            Items = new List<Item>(6);

        }

        private double CalculateHealth()
        {
            return (Agility + Intelligence * 1.5) * Strength / 0.25;
        }


        public List<Item> Items;
        public void AddItem(Item item)
        {
            Items.Add(item);
            Strength += item.Strength;
            Agility += item.Agility;
            Intelligence += item.Intelligence;
            Health = CalculateHealth();
        }
        public void DeleteItem(Item item)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (item.Name == Items[i].Name)
                {
                    Items[i] = null;
                    Strength -= item.Strength;
                    Agility -= item.Agility;
                    Intelligence -= item.Intelligence;
                    Health = CalculateHealth();
                }
            }
        }
        public double Health { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            string str= "Name: " + Name + " Health :" + Health + " Strength :" + Strength + " Agility :" + Agility + " Intelligence :" + Intelligence+ " Items : ";
            foreach (var i in Items)
            {
                str += i + "  ";
            }
            return str;
        }

        abstract public void Hit(ref Hero enemyHero);
        abstract public void Move();

    }
}
