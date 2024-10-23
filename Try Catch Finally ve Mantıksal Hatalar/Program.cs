using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Finally_ve_Mantıksal_Hatalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //    // try içine hataya neden olabilecek kodu  yazıyoruz
            //{ Console.WriteLine(" lütfen bir sayı giriniz:");
            //int sayi=int.Parse(Console.ReadLine());
            //Console.WriteLine(" girdiğiniz  sayı :"+sayi);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine(" işlem tamamlandı");

            //}

            try
            // parse stringleri inte çevirmel için kullanılır
            {
                //int a = int.Parse(null);
                int a = int.Parse("test");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(" boş bir değer girdiniz:");
                Console.WriteLine(ex);


            }
            catch (FormatException ex)
            {
                Console.WriteLine(" veri tipi uygun değil");
                Console.WriteLine(ex);

            }

            Console.Read();

        }
    }
}
