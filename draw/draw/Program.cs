using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draw
{
    internal class Program
    {   
        static bool userChoice(int choice)
        {
            bool status = true;
            switch (choice)
            {
                case 1:
                    rectangle();
                    break;
                case 2:
                    squareTriangle();
                    break;
                case 3:
                    isoscelesTriangle();
                    break;
                case 4:
                    status = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection!");
                    break;
            }
            return status;
        }
        static int handleChoice()
        {
            bool condition = true;
            do
            {
                //Console.WriteLine("Enter your choice: ");
                string input = Console.ReadLine();
                condition = !(int.TryParse(input, out int choice));
                if (condition)
                {
                    Console.WriteLine("Try Again!");
                }
                else
                {
                    return choice;
                }
            }while (condition);
            return -1;
        }
        static void rectangle()  
        {
            Console.WriteLine("Enter the length: ");
            int length = handleChoice();
            Console.WriteLine("Enter the width: ");
            int width = handleChoice();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void menuForSquareTriangle()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("0. exit");
            Console.WriteLine("1. top-left");
            Console.WriteLine("2. top-right");
            Console.WriteLine("3. botton-left");
            Console.WriteLine("4. botton-right");
            Console.WriteLine("-------------------");
        }
        static void squareTriangle()
        {
            bool condition = true;
            do
            {
                menuForSquareTriangle();
                Console.WriteLine("Enter your choice:");
                int choice = handleChoice();
                int edge = 0;
                if (choice != 0)
                {
                    Console.WriteLine("Enter the length of edge:");
                    edge = handleChoice();
                }               
                switch (choice)
                {
                    case 0:
                        condition = false;
                        break;
                    case 1:
                        for (int i = 0; i < edge; i++)
                        {
                            for (int j = 0; j < (edge - i); j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        for (int i = 0; i < edge; i++)
                        {
                            for (int k = 0; k < i; k++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < (edge - i); j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        for (int i = edge - 1; i >= 0; i--)
                        {
                            for (int j = 0; j < (edge - i); j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        for (int i = edge - 1; i >= 0; i--)
                        {   
                            for (int k = i; k > 0; k--)
                            {
                                Console.Write(' ');
                            }
                            for (int j = 0; j < (edge - i); j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
            }while (condition);
        }
        static void isoscelesTriangle()
        {
            Console.WriteLine("Enter the height: ");
            int height = handleChoice();
            for (int i = 0; i < height; i++)
            {
                for (int k = height - 1 - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (i * 2 + 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void menu()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("4. Exit");
            Console.WriteLine("-----------------------------");
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                menu();
                Console.WriteLine("Enter your choice:");
                choice = handleChoice();
            }while (userChoice(choice));
            Console.ReadLine();
        }
    }
}
