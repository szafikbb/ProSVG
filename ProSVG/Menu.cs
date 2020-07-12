using ProSVG.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSVG
{
    class Menu
    {
        private ImageSVG img = new ImageSVG();

        private void ShowMenu()
        {
            Console.WriteLine("Co chcesz zrobic?");
            Console.WriteLine("1. Dodanie linii do obrazka.");
            Console.WriteLine("2. Dodanie kółka do obrazka.");
            Console.WriteLine("3. Wygenerowanie obrazka.");
            Console.WriteLine("0. Wyjście.");
        }

        public void ParseChoice(int choice)
        {
            switch(choice)
            {
                case 1:
                    //dodanie linii
                    break;
                case 2:
                    //Dodanie kolka
                    break;
                case 3:
                    //Wygenerowanie obrazka
                    break;
                case 0:
                    Console.WriteLine("Koniec programu!");
                    break;
                default:
                    Console.WriteLine("Podano zła wartość!");
                    break;
            }
        }

        public void Loop()
        {
            int choice = -1;
            while(choice != 0)
            {
                ShowMenu();
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                ParseChoice(choice);
            }
        }
    }
}
