using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.YaroslavtsevMG.Lab3.Review.V26
{
    public class MenuPage : IPage
    {
        private List<string> listOptions = new List<string>();
        private int cursorList=0;
        private static bool checker = true;
        public MenuPage() 
        {
            Console.CursorVisible = false;
            listOptions.Add("1. Рассчитать первое математическое выражение");
            listOptions.Add("2. Рассчитать второе математическое выражение");
            listOptions.Add("3. Протабулировать функцию на заданном диапазоне");
            listOptions.Add("4. Калькулятор");
            listOptions.Add("5. Обработка одномерного массива");
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            Render();
            Console.CursorTop = 14;
            Console.CursorLeft = 58;
        }

        public new void  DownButtonPressed()
        {
            cursorList = (cursorList + 1) % 5;
            Console.CursorTop = 5;
            Console.CursorLeft = 0;
            RenderBody();
            Console.CursorTop = 14;
            Console.CursorLeft = 58;
        }
        public new void UpButtonPressed()
        {
            cursorList = (cursorList +5 - 1) % 5;
            Console.CursorTop = 5;
            Console.CursorLeft = 0;
            RenderBody();
            Console.CursorTop = 14;
            Console.CursorLeft = 58;
        }

        public IPage EnterButtonPressed()
        {
            
                switch (cursorList)
                {
                    case (0):
                        {
                            return new firstExpressionPage();
                            
                        }
                    case (1):
                        {
                            return new SecondExpressionPage();
                            
                        }
                    case (2):
                        {
                            return new TabMathFunctionPage();
                           
                        }
                    case (3):
                        {
                            return new CalculatorPage();
                            
                        }
                    case (4):
                        {
                            return new ArrayPage();
                            
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("курсор из диапазона вылетел");
                            Console.ReadKey();
                            break;
                        }
                        

                }
                return this;
            
        }

        public new IPage EscButtonPressed()
        {
            Console.CursorTop = 30;
            Console.CursorLeft = 0;
            Environment.Exit(0);
            return this;
        }

        public new void NumberPressed(int value)
        {
            cursorList = (value+5+1)%5;
            Console.CursorTop = 5;
            Console.CursorLeft = 0;
            RenderBody();
            Console.CursorTop = 14;
            Console.CursorLeft = 58;
            Console.Write((value + 5+1) % 6);
            Console.CursorTop = 14;
            Console.CursorLeft = 58;
        }

        public new void ReadTyped(string value)
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

            //1 row
            if(!checker)
            {
                Console.Write("╔");
            }
            checker = false;
            Console.Write("╔");
            for(int i=0;i<118;i++)
            {
                Console.Write("═");
            }
            Console.Write("╗");


            //2 row
            Console.Write("║");
            for (int i = 0; i < (120 - 2 - "Лабораторная работа #3".Length) / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("Лабораторная работа #3");
            for (int i = 0; i < (120 - 2 - "Лабораторная работа #3".Length) / 2 + (120 - 2 - "Лабораторная работа #3".Length) % 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("║");


            //3 row
            Console.Write("║");
            for (int i = 0; i < (120 - 2 - "Создание консольного интерфейса".Length) / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("Создание консольного интерфейса");
            for (int i = 0; i < (120 - 2 - "Создание консольного интерфейса".Length) / 2 + (120 - 2 - "Создание консольного интерфейса".Length) % 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("║");


            //4 row
            Console.Write("║");
            for (int i = 0; i < (120-2- "Выполнил Ярославцев Матвей Геннадьевич".Length)/2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("Выполнил Ярославцев Матвей Геннадьевич");
            for (int i = 0; i < (120 - 2 - "Выполнил Ярославцев Матвей Геннадьевич".Length) / 2+ (120 - 2 - "Выполнил Ярославцев Матвей Геннадьевич".Length) % 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("║");

            //5 row
            Console.Write("║");
            for (int i = 0; i < (120 - 2 - "ТИУ-2024, группа МКМб-22-1".Length) / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("ТИУ-2024, группа МКМб-22-1");
            for (int i = 0; i < (120 - 2 - "ТИУ-2024, группа МКМб-22-1".Length) / 2 + (120 - 2 - "ТИУ-2024, группа МКМб-22-1".Length) % 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("║");

            //6 row
            Console.Write("╚");
            for (int i = 0; i < 118; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝");
             
        }
        private void RenderBody()
        {
            
            Console.WriteLine("");
            Console.WriteLine("Меню:");
            for(int i = 0;i<listOptions.Count;i++)
            {
                Console.ResetColor();
                if(i==cursorList)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.WriteLine(listOptions[i]);
            }
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Выберите пункт меню стрелочками или нажмите номер пункта [ ]");
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
            for(int i=0;i<120;i++)
            {
                Console.Write("═");
            }
            Console.WriteLine("");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("[F1]");
            Console.ResetColor();
            Console.Write(" - Справка |");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("[F10]");
            Console.ResetColor();
            Console.Write(" - Выход     Перемещение:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("[СТРЕЛКА ВНИЗ]");
            Console.ResetColor();
            Console.Write("|");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("[СТРЕЛКА ВВЕРХ]");
            Console.ResetColor();
            
        }

        public IPage F1ButtonPressed()
        {
            return new InfoPage();
        }
    }
}
