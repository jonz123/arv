using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Wizard wizard1 = new Wizard();

            for (int i = 0; i < wizard1.spellList.Count; i++)
            {
                Console.WriteLine(wizard1.spellList[i].element);
            }



            Console.ReadKey();
        }
    }
}
