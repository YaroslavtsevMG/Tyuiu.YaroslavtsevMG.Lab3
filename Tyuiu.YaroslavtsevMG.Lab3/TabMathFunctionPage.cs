using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolveTabMathFuction;
using SolveTabMathFuction.Lib;

namespace Tyuiu.YaroslavtsevMG.Lab3.Review.V26
{
    internal class TabMathFunctionPage : IPage
    {
        public TabMathFunctionPage()
        {
            Render();
            Console.CursorVisible = false;
        }
        public void DownButtonPressed()
        {
            
        }

        public IPage EnterButtonPressed()
        {
            Console.CursorVisible = true;
            //чистим поля от прошлых значений
            Console.CursorLeft = 17;
            Console.CursorTop = 6;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 16;
            Console.CursorTop = 7;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 17;
            Console.CursorTop = 6;
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                EnterButtonPressed();
                return this;
            }
            Console.CursorLeft = 16;
            Console.CursorTop = 7;
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                EnterButtonPressed();
                return this;
            }
            var z = TabMathFuction.CalculateTabMathFuction(a, b);
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                          *");
            Console.WriteLine("+--------+--------+");
            Console.WriteLine("|   X    |  f(x)  |");
            Console.WriteLine("+--------+--------+");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("|   ");
                if (Math.Round(a + i * ((double)(b - a) / 10), 2).ToString().Length > 5)
                {
                    Console.CursorLeft = Console.CursorLeft - 1;
                }
                if (Math.Round(a + i * ((double)(b - a) / 10), 2).ToString().Length > 6)
                {
                    Console.CursorLeft = Console.CursorLeft - 1;
                }
                if (Math.Round(a + i * ((double)(b - a) / 10), 2).ToString().Length > 7)
                {
                    Console.CursorLeft = Console.CursorLeft - 1;
                }
                Console.Write(Math.Round(a + i * ((double)(b - a) / 10), 2));
                for (int j = 0; j < 5 - Math.Round(a + i * ((double)(b - a) / 10), 2).ToString().Length; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("|  ");
                Console.Write(Math.Round(z[i], 2));
                for (int j = 0; j < 6- Math.Round(z[i], 2).ToString().Length; j++)
                { 
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("+--------+--------+");
            Console.CursorVisible = false;
            return this;
        }

        public IPage EscButtonPressed()
        {
            return new MenuPage();
        }

        public void NumberPressed(int value)
        {
            
        }

        public void UpButtonPressed()
        {
            
        }
        private void Render()
        {
            Console.Clear();
            RenderHead();
            RenderBody();
            RenderBot();
        }
        private void RenderHead()
        {
            Console.WriteLine("РАССЧИТАТЬ ТАБУЛИРОВАННОЕ ВЫРАЖЕНИЕ ВЫРАЖЕНИЕ");
            for (int i = 0; i < 120; i++)
            {
                Console.Write("═");
            }
        }
        private void RenderBody()
        {
            Console.WriteLine("Выполняется функция табулирования математического выражения...");
            Console.WriteLine("(1.0 + Sin(Sqrt(x * x + 1.0))) / (Cos((12.0 * x - 4.0)))");
            Console.WriteLine("");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Для ввода данных нажмите Enter");
            Console.ResetColor();
            Console.WriteLine("начало интервала: ");
            Console.WriteLine("конец интервала: ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        private void RenderBot()
        {
            for (int i = 0; i < 120; i++)
            {
                Console.Write("═");
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню");
            Console.ResetColor();
        }

        public IPage F1ButtonPressed()
        {
            return this;
        }
    }
}
