using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolveMathFirstExpression;
using SolveMathFirstExpression.Lib;

namespace Tyuiu.YaroslavtsevMG.Lab3.Review.V26
{
    internal class firstExpressionPage : IPage
    {
        public firstExpressionPage()
        {
            Render();
            Console.CursorVisible = false;

        }
        public void DownButtonPressed()
        {
            
        }
        public void UpButtonPressed()
        {
            
        }

        public IPage  EscButtonPressed()
        {
            return new MenuPage();
        }

        public void NumberPressed(int value)
        {
            
        }


        public void Render()
        {
            Console.Clear();
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            RenderHead();
            RenderBody();
            RenderBot();
            
        }
        private void RenderHead()
        {
            Console.WriteLine("РАССЧИТАТЬ ПЕРВОЕ МАТЕМАТИЧЕСКОЕ ВЫРАЖЕНИЕ");
            for (int i = 0; i < 120; i++)
            {
                Console.Write("═");
            }
        }
        private void RenderBody()
        {
            Console.WriteLine("Выполняется функция рассчета 1 математического выражения...");
            Console.WriteLine("6*y-(((a+3)/x)/((2-x*a)/(x*y)))+(2+3*a)/(10*x+3*a)+4*y");
            Console.WriteLine("");
            Console.WriteLine("Для вводв данных нажмите Enter");
            Console.WriteLine("первый агрумент(x): ");
            Console.WriteLine("второй агрумент(y): ");
            Console.WriteLine("третий агрумент(a): ");
            Console.WriteLine("Значение функции равно: ");
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

        public IPage EnterButtonPressed()
        {
            Console.CursorVisible = true;
            //чистим поля от прошлых значений
            Console.CursorLeft = 20;
            Console.CursorTop = 6;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 20;
            Console.CursorTop = 7;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 20;
            Console.CursorTop = 8;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 24;
            Console.CursorTop = 9;
            Console.Write("                                                                                                    ");
            //ставим значения
            Console.CursorLeft = 20;
            Console.CursorTop = 6;
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                EnterButtonPressed();
                return this;
            }
            Console.CursorLeft = 20;
            Console.CursorTop = 7;
            if (!double.TryParse(Console.ReadLine(), out double y))
            {
                EnterButtonPressed();
                return this;
            }
            Console.CursorLeft = 20;
            Console.CursorTop = 8;
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                EnterButtonPressed();
                return this;
            }
            Console.CursorLeft = 24;
            Console.CursorTop = 9;
            Console.Write(MathFirstExpression.CalculateFirstExpression(x,y,a));
            Console.CursorVisible = false;
            return this;
        }

        public IPage F1ButtonPressed()
        {
            return this;
        }
    }
}
