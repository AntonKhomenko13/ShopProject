﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class SalesManagerServicesMenu: AbstractMenu
    {
        SMServivesPL smServivesPL;

        ConsoleColor defaultColor;

        public SalesManagerServicesMenu(SMServivesPL smServivesPL)
        {
            this.smServivesPL = smServivesPL;
        }

        protected override void Init()
        {
            Flag = true;
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        protected override void Idle()
        {
            Console.Clear();
            Console.WriteLine("1 - Get Client Orders");
            Console.WriteLine("2 - Get Client Sum");
            Console.WriteLine("3 - Exit");

            int menuNumber = int.Parse(Console.ReadLine());
            switch (menuNumber)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Get Client Orders");
                    smServivesPL.GetClientOrders();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Get Client Sum");
                    smServivesPL.GetClientSum();
                    Console.ReadKey();
                    break;
                case 3:
                    Flag = false;
                    Console.Clear();
                    break;
                default:
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