using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CarrierInformationDLL;
using Log;
using Serialize;

namespace Volkov_HW_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriceList priceList = new PriceList();
            int menu = 0;
            int count = 0;
            string model = string.Empty, name = string.Empty, modelfind = string.Empty;
            float mediacapacity = 0;
            while (true) // меню
            {
                Console.WriteLine("1. Add\n2. Remove\n3. Find\n4. Edit\n5. Save\n6. Load\n7. Exit");
                menu = int.Parse(Console.ReadLine());
                switch(menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1. HDD\n2. Flash\n3. DVD");
                        menu = int.Parse(Console.ReadLine());
                        switch (menu)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("Enter spindle speed -> ");
                                int spindle = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.Write("Enter model -> ");
                                model = Console.ReadLine();
                                Console.Clear();
                                Console.Write("Enter name -> ");
                                name = Console.ReadLine();   
                                Console.Clear();
                                Console.Write("Enter media capacity -> ");
                                mediacapacity = float.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.Write("Enter count -> ");
                                count = int.Parse(Console.ReadLine());
                                Console.Clear();
                                priceList.Add(new HDD(spindle, model, name, mediacapacity, count));
                                break;
                            case 2:
                                Console.Clear();
                                Console.Write("Enter USB speed -> ");
                                int speedUsb = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.Write("Enter model -> ");
                                model = Console.ReadLine();
                                Console.Clear();
                                Console.Write("Enter name -> ");
                                name = Console.ReadLine();
                                Console.Clear();
                                Console.Write("Enter media capacity -> ");
                                mediacapacity = float.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.Write("Enter count -> ");
                                count = int.Parse(Console.ReadLine());
                                Console.Clear();
                                priceList.Add(new FlashMemory(speedUsb, model, name, mediacapacity, count));
                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("Enter write speed -> ");
                                int writeSpeed = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.Write("Enter model -> ");
                                model = Console.ReadLine();
                                Console.Clear();
                                Console.Write("Enter name -> ");
                                name = Console.ReadLine();
                                Console.Clear();
                                Console.Write("Enter media capacity -> ");
                                mediacapacity = float.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.Write("Enter count -> ");
                                count = int.Parse(Console.ReadLine());
                                Console.Clear();
                                priceList.Add(new DVD(writeSpeed, model, name, mediacapacity, count));
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Error...");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter model to remove -> ");
                        model = Console.ReadLine();
                        Console.Clear();
                        priceList.Remove(model);
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 3:
                        Console.Clear();
                        Console.Write("Enter model to find -> ");
                        model = Console.ReadLine();
                        Console.Clear();
                        priceList.Find(model);
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 4:
                        Console.Clear();
                        Console.Write("Enter model to find for edit -> ");
                        modelfind = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter model -> ");
                        model = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter name -> ");
                        name = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter media capacity -> ");
                        mediacapacity = float.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Enter count -> ");
                        count = int.Parse(Console.ReadLine());
                        Console.Clear();
                        priceList.Edit(modelfind, model, name, mediacapacity, count);
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 5:
                        Console.Clear();
                        priceList.Save();
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Load...");
                        priceList.Load();
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Exit...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                }
                break;
            }
        }
    }
}
