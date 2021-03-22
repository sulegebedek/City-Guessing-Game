using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace CityGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] city = new string[] { "Bursa", "Adana", "Mersin", "Afyon", "Kastamonu" };
            string[] country = new string[] { "Fransa", "İngiltere", "Yunanistan", "Polonya" };

            while (1 == 1) 
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Şehir-Ülke Tahmin Etme Oyununa Hoşgeldiniz");
                Console.WriteLine("---------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Oyun Kategorisini Seçiniz :");
                Console.WriteLine("\t 1-Şehir");
                Console.WriteLine("\t 2-ülke");
                Console.Write("\r\n\r\n Seçiminiz:");

                try
                {
                    string question = "";
                    string selectData = Console.ReadLine();
                    Random random = new Random();
                    if (selectData.ToLower() == "çıkış" || selectData.ToLower() == "exit")
                        goto exit;

                    int selection = Convert.ToInt32(selectData);

                    if (selection == 1)  
                    {
                        Console.Clear();
                        Console.WriteLine("<<<<<<< İSİM BİLMECE >>>>>>>>>");
                        int randomNumber = random.Next(city.Length - 1);
                        question = city[randomNumber];
                    }
                    else if (selection == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("<<<<<<< ŞEHİR BİLMECE >>>>>>>>>");
                        int randomNumber = random.Next(country.Length - 1);
                        question = country[randomNumber];
                    }

                    Console.Write(question.Substring(0, 1)); // E***N
                    for (int i = 1; i < question.Length - 1; i++)

                        Console.Write("*");

                    Console.Write(question.Substring(question.Length - 1, 1));
                    int counter = 0;
                    bool right = false;
                    do
                    {
                        counter++;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\r\n\r\n " + counter.ToString() + ". Tahmininizi Giriniz");
                        string guess = Console.ReadLine();

                        if (question == guess)
                        {
                            right = true; 
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(">>> Tekrar Deneyin");
                        }

                    } while (counter < 3);

                    if (!right)
                    {
                        Console.WriteLine("Oyunu Kaybettiniz :( Yeniden başlamak için Enter tuşuna basınız");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("  *** Tebrikler Bildiniz :) 100 puan *** \r\n\r\n Yeniden Başlamak için ENTER'a basınız...");
                        Console.ReadLine();
                    }


                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Hatayı Gizledim");

                }
            }

        exit:
            Console.WriteLine("Güle Güle");
        }
    }
}
