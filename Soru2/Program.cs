using System;

namespace Soru2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userName = "admin";
            string password = "123";

           Console.WriteLine("Kullanıcı adınızı giriniz");
            string _userName = Console.ReadLine();

            Console.WriteLine("Şifrenizi giriniz");
            string _password=Console.ReadLine();

            if (userName.Equals(_userName) && password.Equals(_password))
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Böyle bir kullanıcı bulunamadı");
            }
        }
    }
}
