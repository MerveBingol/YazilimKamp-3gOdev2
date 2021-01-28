using System;

namespace YazilimKampı3gOdev2
{
   
    class Referans
    {
       
        public void Kare(ref int i, ref int k)
        {
            i = i * k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Referans rf = new Referans();

            int a = 10;
            int b = 20;
            Console.WriteLine("---------REF KULLANIMI-----------------");

            Console.WriteLine("Çağrıdan önce: " + a);

            
            rf.Kare(ref a, ref b);

            Console.WriteLine("Çağrıdan sonra: " + a);

            Console.WriteLine("-----------------------------------------");
        }
    }
}
