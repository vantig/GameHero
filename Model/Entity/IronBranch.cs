namespace Model.Entity
{
    public class IronBranch : Item

    {
        public IronBranch() : base(1, 2, 3)
        {
            Name = "Iron Branch";
            Cost = 50;
            Useable = true;
            Count = 1;
        }

        public void Use()
        {
            if (Count > 0)
            {
                Count -= 0;
                Strength += 1;
            }

        }
    }
}