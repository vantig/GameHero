using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Pudge : Hero
    {
        public Pudge() : base(25, 14, 16)
        {
            Name = "Pudge";
        }
       
        public override void Hit(ref Hero enemyHero)
        {
            var rnd = new Random();

            enemyHero.Health = enemyHero.Health - this.Strength * rnd.NextDouble() + 0.5;
        }

        public override void Move()
        {
            Health += 1;
        }
    }
}
