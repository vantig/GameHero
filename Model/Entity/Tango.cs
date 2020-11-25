namespace Model.Entity
{
    public class Tango:Item,IUseble
    {
        public Tango() : base(6, 0, 3)
        {
            Name = "Tango";
            Cost = 250;
            Useable = true;
            Count = 3;
        }

        public void Use()
        {
            if (Count>0)
            {
                Count -= 1;
                Strength -= 2;
                Intelligence-=1;
            }
        
        }
    }
}