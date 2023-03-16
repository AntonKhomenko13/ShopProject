using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class MainMenu : AbstractMenu
    {
        ConsoleColor defaultColor;
        protected override void Init()
        {
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        protected override void Idle()
        {
            Console.WriteLine("1 - HR Menu");
            Console.WriteLine("2 - Product Manager Menu");
            Console.WriteLine("3 - Sales Manager Menu");
            Console.WriteLine("4 - Exit");

            int menuNumber = int.Parse(Console.ReadLine());
            switch(menuNumber)
            {
                case 1:
                    Console.WriteLine("HR Menu");
                    break;
                case 2:
                    Console.WriteLine("Product Manager Menu");
                    break;
                case 3:
                    Console.WriteLine("Sales Manager Menu");
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
