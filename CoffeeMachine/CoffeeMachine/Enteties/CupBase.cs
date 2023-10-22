using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Enteties
{
    internal abstract class CupBase
    {
        public void Stir()
        {
            Console.WriteLine("Stirring the cup...");
        }
    }
}
