using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;

namespace Soru3
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("ADET GİRİNİZ");
            int adet=int.Parse(Console.ReadLine());
            for (int i = 1; i <= adet; i++)
            {
                Console.WriteLine("Puanlarını gir");
                List<int> list = new List<int>(int.Parse(Console.ReadLine()));
                for (int j = 1; j <= adet; i++)
                {
                    Console.WriteLine(list[i]);
                }
               
            }
           
            //int[] dizi;
            //Console.WriteLine("Gireceğiniz puan adedini yazınız");
            //int adet=int.Parse(Console.ReadLine());
            //if (adet>0)
            //{
            //    dizi=new int[adet];
            //    for (int i=0; i<dizi.Length; i++)
            //    {
            //        int eklenenPuan;
            //        Console.WriteLine("Puanlarınızı giriniz");

            //        eklenenPuan=int.Parse(Console.ReadLine());
            //        dizi[i]=eklenenPuan;


            //    }
        }
           
            
        }
    }

