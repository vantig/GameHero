using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{

    interface IMovable
    {
     
        void Move();
    }
    interface IHit
    {
        void Hit(ref Hero enemyHero);
        
    }
}
