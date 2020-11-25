using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Model.Entity;

namespace Model.logic
{

    public class Logic
    {
        public static int СalculateСostOfItems(List<Item> Items) => Items.Sum(item => item.Cost);

        public static int СalculatePowerOfItems(List<Item> Items)
        {
            return Items.Sum(item => (item.Strength + item.Agility + item.Intelligence) * item.Count);

        }

        public static int CalculatePowerOfHero(Hero hero)
        {
            return (hero.Agility + hero.Intelligence + hero.Strength + СalculatePowerOfItems(hero.Items)) / 3 + hero.Items.Count;
        }

        public static void SortItemsByAttribute(List<Item> container, IComparer<Item> comparer)
        {
            var len = container.Count();
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (comparer.Compare(container[j], container[j + 1]) > 0)
                    {
                        var t = container[j];
                        container[j] = container[j + 1];
                        container[j + 1] = t;

                    }

                }
            }


        }
        public static int FindIndexOfItemByAttribute(List<Item> container, string attribute, int value)
        {
            int index = 0;
            switch (attribute)
            {
                case "Agility":
                    foreach (var item in container)
                    {
                        if (item.Agility == value)
                        {
                            return index;
                        }

                        index++;
                    }
                    break;
                case "Strength":
                    foreach (var item in container)
                    {
                        if (item.Strength == value)
                        {
                            return index;
                        }

                        index++;
                    }
                    break;
                case "Intelligence":
                    foreach (var item in container)
                    {
                        if (item.Intelligence == value)
                        {
                            return index;
                        }

                        index++;
                    }
                    break;

            };

            return -1;
        }
        //static void Swap(ref int x, ref int y)
        //{
        //    var t = x;
        //    x = y;
        //    y = t;
        //}
        public class AgilityComp : IComparer<Item>
        {

            public int Compare(Item x, Item y)
            {
                if (y != null && x != null)
                {

                    return x.Agility - y.Agility;
                }
                throw new NullReferenceException();
            }
        }

        public class IntelligenceComp : IComparer<Item>
        {



            public int Compare(Item x, Item y)
            {
                if (y != null && x != null)
                {
                    return x.Intelligence - y.Intelligence;
                }
                throw new NullReferenceException();
            }
        }

        public class StrengthComp : IComparer<Item>
        {

            public int Compare(Item x, Item y)
            {
                if (y != null && x != null)
                {
                    return x.Strength - y.Strength;
                }
                throw new NullReferenceException();
            }

        }
    }
}

