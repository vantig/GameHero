using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Item
    {

        protected Item(int s, int a, int i)
        {
            Strength = s;
            Agility = a;
            Intelligence = i;


        }
        public int Count { get; set; } = 0;
        public bool Useable { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Item))
                return false;

            return Name == ((Item)obj).Name;
        }
        public override int GetHashCode() => Name.GetHashCode() * Cost.GetHashCode() * Strength.GetHashCode() * Agility.GetHashCode() * Intelligence.GetHashCode();

        public override string ToString() => Name;

    }
}
