using CoffeeMachine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Enteties
{
    internal class Cup : CupBase, IContainingCoffee, IContainingWater, IContainingMilk, IContainingSugar
    {
        public void AddCoffee()
        {
            Console.WriteLine("Adding coffee to the cup.");
        }

        public void AddWater()
        {
            Console.WriteLine("Adding water to the cup.");
        }

        public void AddMilk()
        {
            Console.WriteLine("Adding milk to the cup.");
        }

        public void AddSugar()
        {
            Console.WriteLine("Adding sugar to the cup.");
        }
    }
}
