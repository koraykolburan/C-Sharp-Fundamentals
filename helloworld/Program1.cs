using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
          // string num1 = "1";
           //string num2 = "2";
           //String veri tipinden Integer veri tipine dönüşüm
           // int a = int.Parse(num1);
           // int b = int.Parse(num2);
          //  System.Console.WriteLine(a + b);

         // int a = Convert.ToInt32(num1);
          //int b = Convert.ToInt32(num2);
            //-----------------------------------------------------------------------------
            //Int veri tipinden string veri tipine dönüştürme
            /*int num1 = 5;
            int num2 = 10;
            //System.Console.WriteLine(num1+num2);
            string a = num1.ToString();
            string b = num2.ToString();
            System.Console.WriteLine(b+a);*/
//----------------------------------------------------------------------------------
            //double veri tipinden int veri tipine dönüşüm
           /* double num1 = 5.22;
            int a = Convert.ToInt32(num1);
            

            System.Console.WriteLine(a); 
            System.Console.WriteLine(a.GetType()); */

            //Kullanıcıdan alınan değerler string veri  tipinde olur
            /*System.Console.WriteLine("Lütfen yaşınızı giriniz");
            string user_age = Console.ReadLine();
            int user_ageInt = int.Parse(user_age);
            int user_ageInt2 = Convert.ToInt32(user_age);

            System.Console.WriteLine(user_ageInt);
            System.Console.WriteLine(user_ageInt2);*/

            //Write the app from (to taking two result from user and to writing the result of summary)

            System.Console.WriteLine("1.sayıyı giriniz");
            string num1 = Console.ReadLine();

            System.Console.WriteLine("2.sayıyı giriniz");
            string num2 = Console.ReadLine();

            int a = int.Parse(num1);
            int b = int.Parse(num2);
        //Don't forget the paranthesis!
            System.Console.WriteLine("Sum of the two numbers: " + (a + b));
        }
    }
}
