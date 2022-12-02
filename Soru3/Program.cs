using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace Soru3
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("ADET GİRİNİZ");
            int[] score = new int[100];
            int[] sort = new int[100];
            int scoreExtra = 0;
            int adet = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < adet; i++)
            {

                Console.WriteLine("Puanlarını gir");

                score[i] = int.Parse(Console.ReadLine());
                list.Add(score[i]);
            }
            list.Sort();
            list.Reverse();

  
            list.ForEach(lst => Console.Write($" {lst} - "));
            Console.WriteLine("  \n---------------------------------------------\n");

            int[] deneme =  score;
            int tutucu;
            int sayac;
            for (int i = 1; i < adet; i++)
            {
                sayac = 0;
                for (int j = 0; j < adet; j++)
                {
                    
                    if (deneme[i] == score[j])
                    {
                        sayac++;

                        tutucu = deneme[i];

                        Console.WriteLine($"{i} tane {tutucu}. var");

                    }
                }
             
               
            }
            Console.WriteLine("Extra olarak kaç adet puan girmek istiyorsun?");
            int extraAdet = int.Parse(Console.ReadLine());

            for (int j = 0; j < extraAdet; j++)
            {
                Console.WriteLine("Puanları giriniz ");
                scoreExtra = int.Parse(Console.ReadLine());
                list.Add(scoreExtra);
            }
            list.Sort();
            list.Reverse();

            Console.WriteLine("---------------SKORLAR--------------------");
           


        }

    }
}


    
    

