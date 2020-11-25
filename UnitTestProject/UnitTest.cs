using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Model.Entity;
using Model.logic;
namespace UnitTestProject
{


    public class StudentsCheck
    {

        public static bool AreEqualLists(List<Item> list1, List<Item> list2, IComparer<Item> compare)
        {
            var flag = true;
            for (var i = 0; i < list1.Count; i++)
            {
                if (compare.Compare(list1[i], list2[i]) != 0)
                {
                    flag = false;
                }
            }

            return flag;
        }
    }
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void ÑalculateCostOfItems_Returned_int_4500()
        {
            List<Item> items = new List<Item>() { new Aganim(), new IronBranch(), new Tango() };
            var expected = 4200 + 50 + 250;
            Assert.AreEqual(expected, Logic.ÑalculateÑostOfItems(items));
        }

        [TestMethod]
        public void ÑalculatePowerOfHero_Returned_int_39()
        {
            var hero = new Pudge();
            hero.AddItem(new Aganim());
            var expected = (Logic.ÑalculatePowerOfItems(hero.Items) + hero.Agility + hero.Strength + hero.Intelligence) / 3 + hero.Items.Count;
            Assert.AreEqual(expected, Logic.CalculatePowerOfHero(hero));
        }
        [TestMethod]
        public void SortItemsByAgility_Returned_true()
        {
            List<Item> items = new List<Item>() { new Aganim(), new Tango(), new IronBranch() };
            List<Item> expectedList = new List<Item>() { new Tango() ,new IronBranch(), new Aganim() };

            var expected = true;

            Logic.SortItemsByAttribute(items, new Logic.AgilityComp());
            Assert.AreEqual(expected, StudentsCheck.AreEqualLists(items, expectedList, new Logic.AgilityComp()));
        }
        [TestMethod]
        public void SortItemsByStrength_Returned_true()
        {
            List<Item> items = new List<Item>() { new Aganim(), new Tango(), new IronBranch() };
            List<Item> expectedList = new List<Item>() { new IronBranch() ,new Tango(), new Aganim() };

            var expected = true;

            Logic.SortItemsByAttribute(items, new Logic.StrengthComp());
            Assert.AreEqual(expected, StudentsCheck.AreEqualLists(items, expectedList, new Logic.StrengthComp()));
        }
        [TestMethod]
        public void SortItemsByIntelligence_Returned_true()
        {
            List<Item> items = new List<Item>() { new Aganim(), new Tango(), new IronBranch() };
            List<Item> expectedList = new List<Item>() { new Tango(), new IronBranch(), new Aganim() };

            var expected = true;

            Logic.SortItemsByAttribute(items, new Logic.IntelligenceComp());
            Assert.AreEqual(expected, StudentsCheck.AreEqualLists(items, expectedList, new Logic.IntelligenceComp()));
        }
        [TestMethod]
        public void FindIndexOfItemByAttributeAndValue_Returned_1()
        {
            List<Item> items = new List<Item>() { new Aganim(), new Tango(), new IronBranch() };
           

            var expected = 1;

           
            Assert.AreEqual(expected, Logic.FindIndexOfItemByAttribute(items,"Strength", 6));
        }
        
    }
}
