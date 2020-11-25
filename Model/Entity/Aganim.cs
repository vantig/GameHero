using System;

namespace Model.Entity
{
    public class Aganim : Item
    {
        public Aganim() : base(10, 10, 10)
        {
            Name = "Aganim";
            Cost = 4200;
            Useable = false;
            Count = 1;
        }
    }
}
