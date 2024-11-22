using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.YaroslavtsevMG.Lab3.Review.V26
{
    internal class InfoPage : IPage
    {
        public InfoPage()
        {
            Render();
            Console.CursorVisible = false;
        }
        public void DownButtonPressed()
        {
            
        }

        public IPage EnterButtonPressed()
        {
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
            RenderTop();
            RenderBody();
            RenderBot();
        }
        private void RenderTop()
        {
            Console.WriteLine("СПРАВКА");
            for (int i = 0; i < 120; i++)
            {
                Console.Write("═");
            }
        }
        private void RenderBody()
        {
            Console.WriteLine();
            Console.WriteLine("Справочные сведения по работе с программой");
            Console.WriteLine();
            Console.WriteLine("РАЗДЕЛ МЕНЮ                 Описание                          ПАРАМЕТР КОМ. СТРОКИ");
            Console.WriteLine("1. Рассчитать ПЕРВОЕ МАТ... Вычислить мат. выражение...       /1");
            Console.WriteLine("2. Рассчитать ВТОРОЕ МАТ... Вычислить мат. выражение...       /2");
            Console.WriteLine("3. ПРОТАБУЛИРОВАТЬ ФУНК...  Табулирует функцию...             /3");
            Console.WriteLine("4. КАЛЬКУЛЯТОР              Выполняет расчет +,-,*./          /4");
            Console.WriteLine("5. ОБРАБОТКА ОДНОМЕРНОГО... Обрабатывает одномерный массив... /5");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
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
