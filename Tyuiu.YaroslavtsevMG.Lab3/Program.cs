using System;
using System.Text;

namespace Tyuiu.YaroslavtsevMG.Lab3.Review.V26;// Note: actual namespace depends on the project name.

public class Program
{
    
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        IPage currentPage = new MenuPage();
        var x = ConsoleKey.F10;
        
        
        while (true)
        {
            x = Console.ReadKey().Key;
            switch (x)
            {
                case ConsoleKey.F10:
                    {
                        Environment.Exit(0);
                        break;
                    }
                case ConsoleKey.F1:
                    {
                        currentPage = currentPage.F1ButtonPressed();
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        currentPage.DownButtonPressed();
                        break;
                    }
                case ConsoleKey.UpArrow:
                    {
                        currentPage.UpButtonPressed();
                        break;
                    }
                case ConsoleKey.Escape:
                    {
                        
                        currentPage=currentPage.EscButtonPressed();
                        break;
                    }
                case ConsoleKey.Enter:
                    {
                        
                        currentPage = currentPage.EnterButtonPressed();
                        break;
                    }
                case ConsoleKey.D0:
                    {
                        currentPage.NumberPressed(Convert.ToInt32(x));
                        break;
                    }
                case ConsoleKey.D1:
                    {
                        currentPage.NumberPressed(Convert.ToInt32(x));
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        currentPage.NumberPressed(Convert.ToInt32(x));
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        currentPage.NumberPressed(Convert.ToInt32(x));
                        break;
                    }
                case ConsoleKey.D4:
                    {
                        currentPage.NumberPressed(Convert.ToInt32(x));
                        break;
                    }
                case ConsoleKey.D5:
                    {
                        currentPage.NumberPressed(Convert.ToInt32(x));
                        break;
                    }
                case ConsoleKey.D6:
                    {
                        currentPage.NumberPressed(Convert.ToInt32(x));
                        break;
                    }
                case ConsoleKey.D7:
                    {
                        currentPage.NumberPressed(Convert.ToInt32(x));
                        break;
                    }
                case ConsoleKey.D8:
                    {
                        currentPage.NumberPressed(Convert.ToInt32(x));
                        break;
                    }
                case ConsoleKey.D9:
                    {
                        currentPage.NumberPressed(Convert.ToInt32(x));
                        break;
                    }
                default:
                    {
                        
                        break;
                    }

            }
        }
    }
}