using System;
using System.Collections.Generic;
using System.Text;
using Model.Entity;
namespace Model.logic
{
    class logic
    {
       public int СalculateСostOfItems(Hero hero)
        {
            int cost=0;
            foreach(var item in hero.items)
            {
                cost += item.Cost;
            }
            return cost;
        }
    }
}
