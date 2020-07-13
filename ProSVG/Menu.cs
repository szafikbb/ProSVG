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
                    AddLine();
                    break;
                case 2:
                    //Dodanie kolka
                    AddCircle();
                    break;
                case 3:
                    //Wygenerowanie obrazka
                    ShowSVG();
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
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    ParseChoice(choice);
                }
                catch(Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Zła wartość, podaj ponownie!");
                }
            }
        }

        private void AddLine()
        {
            Console.WriteLine("Podaj współrzędną x1 linii.");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współrzędną y1 linii.");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współrzędną x2 linii.");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współrzędną y2 linii.");
            int y2 = int.Parse(Console.ReadLine());
            ColorSVG color = GetColor();

            img.AddElement(new Line(x1, y1, x2, y2, color));
        }

        private ColorSVG GetColor()
        {
            Console.WriteLine("Wybierz kolor:");
            Array values = Enum.GetValues(typeof(ColorSVG));
            int i = 0;
            foreach(ColorSVG col in values)
            {
                Console.WriteLine(i++ + ". " + col.ToString());
            }
            int choice = int.Parse(Console.ReadLine());

            return (ColorSVG)choice;
        }

        private void AddCircle()
        {
            Console.WriteLine("Podaj współrzędną x1 koła.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współrzędną y1 koła.");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj promień koła.");
            int r = int.Parse(Console.ReadLine());
            ColorSVG color = GetColor();

            img.AddElement(new Circle(x, y, r, color));
        }

        private void ShowSVG()
        {
            Console.WriteLine("Wygenerowany obrazek:");
            Console.WriteLine(img.Generate());
        }
    }
}
