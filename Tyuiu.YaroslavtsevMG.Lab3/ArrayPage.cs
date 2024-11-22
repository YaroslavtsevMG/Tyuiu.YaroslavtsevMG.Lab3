using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolveArray;

namespace Tyuiu.YaroslavtsevMG.Lab3.Review.V26
{
    internal class ArrayPage : IPage
    {
        public ArrayPage()
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
            Console.CursorLeft = 22;
            Console.CursorTop = 3;
            Console.Write("                                                                                                  ");
            Console.CursorLeft = 22;
            Console.CursorTop = 4;
            Console.Write("                                                                                                  ");
            Console.CursorLeft = 23;
            Console.CursorTop = 5;
            Console.Write("                                                                                                 ");
            //ставим значения
            Console.CursorLeft = 22;
            Console.CursorTop = 3;
            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                EnterButtonPressed();
                return this;
            }
            Console.CursorLeft = 22;
            Console.CursorTop = 4;
            if (!int.TryParse(Console.ReadLine(), out int x1))
            {
                EnterButtonPressed();
                return this;
            }
            Console.CursorLeft = 23;
            Console.CursorTop = 5;
            if (!int.TryParse(Console.ReadLine(), out int x2))
            {
                EnterButtonPressed();
                return this;
            }
            float[] arr = new float[N];
            var rand = new Random();
            for(int i=0;i<N;i++)
            {
                arr[i] = rand.Next(x1, x2);
            }
            Console.CursorLeft = 24;
            Console.CursorTop = 8;
            Console.Write(SolveArray.Lib.Array.CalculateMinimum(arr));
            Console.CursorLeft = 25;
            Console.CursorTop = 9;
            Console.Write(SolveArray.Lib.Array.CalculateMaximum(arr));
            Console.CursorLeft = 12;
            Console.CursorTop = 10;
            Console.Write(SolveArray.Lib.Array.CalculateAverage(arr));
            Console.CursorLeft = 12;
            Console.CursorTop = 11;
            Console.Write(SolveArray.Lib.Array.CalculateMedian(arr));
            Console.CursorLeft = 32;
            Console.CursorTop = 12;
            Console.Write(SolveArray.Lib.Array.CalculateNumberOfEven(arr));
            Console.CursorLeft = 34;
            Console.CursorTop = 13;
            Console.Write(SolveArray.Lib.Array.CalculateNumberOfOdd(arr));
            Console.CursorLeft = 53;
            Console.CursorTop = 14;
            Console.Write(SolveArray.Lib.Array.SignsOfDivisibilityByTwo(arr));
            Console.CursorLeft = 53;
            Console.CursorTop = 15;
            Console.Write(SolveArray.Lib.Array.SignsOfDivisibilityByThree(arr));
            Console.CursorLeft = 53;
            Console.CursorTop = 16;
            Console.Write(SolveArray.Lib.Array.SignsOfDivisibilityByFive(arr));
            Console.CursorLeft = 55;
            Console.CursorTop = 17;
            Console.Write(SolveArray.Lib.Array.SignsOfDivisibilityByTen(arr));
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
            Console.WriteLine("Для ввода нажмите Enter");
            Console.WriteLine("Количество элементов: ");
            Console.WriteLine("Минимальное значение: ");
            Console.WriteLine("Максимальное значение: ");
            Console.WriteLine("");
            Console.WriteLine("Результат: ");
            Console.WriteLine("1. Минимальный элемент: ");
            Console.WriteLine("2. Максимальный элемент: ");
            Console.WriteLine("3. Среднее: ");
            Console.WriteLine("4. Медиана: ");
            Console.WriteLine("5. Количество четных элементов: ");
            Console.WriteLine("6. Количество нечетных элементов: ");
            Console.WriteLine("7. Количество элементов с признаками делимости на 2: ");
            Console.WriteLine("8. Количество элементов с признаками делимости на 3: ");
            Console.WriteLine("9. Количество элементов с признаками делимости на 5: ");
            Console.WriteLine("10. Количество элементов с признаками делимости на 10: ");
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
