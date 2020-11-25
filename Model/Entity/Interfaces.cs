using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    internal interface IMovable
    {
     
        void Move();
    }

    internal interface IHit
    {
        void Hit(ref Hero enemyHero);
        
    }

    internal interface IUseble
    {
        void Use();

    }

}
