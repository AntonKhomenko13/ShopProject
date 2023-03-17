using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class HrMenu: AbstractMenu
    {
        ConsoleColor defaultColor;
        protected override void Init()
        {
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        protected override void Idle()
        {
            Console.WriteLine("1 - Product Manager CRUD Menu");
            Console.WriteLine("2 - Sales Manager CRUD Menu");
            Console.WriteLine("3 - HR Services Menu");
            Console.WriteLine("4 - Exit");

            int menuNumber = int.Parse(Console.ReadLine());
            switch (menuNumber)
            {
                case 1:
                    Console.WriteLine("Product Manager CRUD Menu");
                    break;
                case 2:
                    Console.WriteLine("Sales Manager CRUD Menu");
                    break;
                case 3:
                    Console.WriteLine("HR Services Menu");
                    break;
                case 4:
                    Flag = false;
                    break;
                case 5:
                    Console.WriteLine("Input the right number!");
                    break;
            }
        }
        protected override void CleanUp()
        {
            Console.ForegroundColor = defaultColor;
        }
    }
}
