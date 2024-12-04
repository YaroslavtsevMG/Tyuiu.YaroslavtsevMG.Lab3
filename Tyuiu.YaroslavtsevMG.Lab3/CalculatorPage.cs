using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolveCalculate;
using SolveCalculate.Lib;

namespace Tyuiu.YaroslavtsevMG.Lab3.Review.V26
{
    internal class CalculatorPage : IPage
    {
        public CalculatorPage()
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
            Console.CursorLeft = 0;
            Console.CursorTop = 6;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 0;
            Console.CursorTop = 7;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 0;
            Console.CursorTop = 8;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 0;
            Console.CursorTop = 9;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 17;
            Console.CursorTop = 3;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 16;
            Console.CursorTop = 4;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 17;
            Console.CursorTop = 3;
            if(!float.TryParse(Console.ReadLine(), out float a))
            {
                EnterButtonPressed();
                return this;
            }
            Console.CursorLeft = 17;
            Console.CursorTop = 4;
            if (!float.TryParse(Console.ReadLine(), out float b))
            {
                EnterButtonPressed();
                return this;
            }
            Console.CursorLeft = 0;
            Console.CursorTop = 6;
            Console.WriteLine($"{a} + {b} = {Calculate.CalculateSumma(a, b)}");
            Console.WriteLine($"{a} - {b} = {Calculate.CalculateDifference(a, b)}");
            Console.WriteLine($"{a} * {b} = {Calculate.CalculateMultiplication(a, b)}");
            Console.WriteLine($"{a} / {b} = {Calculate.CalculateQuotient(a, b)}");
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
            Console.WriteLine("КАЛЬКУЛЯТОР");
            for (int i = 0; i < 120; i++)
            {
                Console.Write("═");
            }
        }
        private void RenderBody()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Для ввода нажмите Enter");
            Console.ResetColor();
            Console.WriteLine("Первый аргумент: ");
            Console.WriteLine("Первый аргумент: ");
            Console.WriteLine("Результат: ");
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
