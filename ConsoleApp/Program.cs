using System;
using Model.Entity;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pudge();
            p.AddItem(new Aganim());
            Console.WriteLine(p.ToString());
        }
    }
}
