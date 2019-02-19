using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            {

                {
                    Console.Write("Меню:\n1) Введите A \n2) Введите B \n3) Сложение \n4) Вычитание \n5) Умножение \n6) Деление \n7) Выход");
                    i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
<<<<<<< HEAD
                        //case 1:
                        //    Console.WriteLine("1");                           
                        //    break;
                        //case 2:
                        //    Console.WriteLine("2");
                        //    break;
                        //case 3:
                        //    Console.WriteLine("3");
=======
<<<<<<< HEAD
                
=======
<<<<<<< HEAD
                        
                        case 2:
                            Console.WriteLine("Введите B");
                            int b = int.Parse(Console.ReadLine());
                            break;
=======
                        case 1:
                            Console.WriteLine("Введите A");
                            int a= int.Parse(Console.ReadLine());
                            break;
                       
>>>>>>> case1
                     
                        case 3:
                            int sum = a + b;
                            Console.WriteLine("{0}", sum);
                            break;
                        //case 4:
                        //    Console.WriteLine("4");
>>>>>>> case3
                        //    break;
                        case 4:
                            int raz = a - b;
                            Console.WriteLine("{0}", raz);
                            break;
                        //case 5:
                        //    Console.WriteLine("5");
                        //    break;
                        //case 6:
                        //    Console.WriteLine("6");
                        //    break;
                        default:
                            Console.WriteLine("");
                            break;
                    }
                    Console.Write("\nНажмите любую клавишу...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
