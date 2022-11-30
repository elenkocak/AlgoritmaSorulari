using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Soru3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] dizi;
            Console.WriteLine("Gireceğiniz puan adedini yazınız");
            int adet=int.Parse(Console.ReadLine());
            if (adet>0)
            {
                dizi=new int[adet];
                for (int i=0; i<dizi.Length; i++)
                {
                    int eklenenPuan;
                    Console.WriteLine("Puanlarınızı giriniz");
                   
                    eklenenPuan=int.Parse(Console.ReadLine());
                    dizi[i]=eklenenPuan;

                   
                }
            }
           
            
        }
    }
}
