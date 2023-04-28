using DesignPattern.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._01_SingletonPattern
{
    public class CallSingleton
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("El Singleton funciona! ambos tienen la misma instancia.");
            }
            else
            {
                Console.WriteLine("El singleton fallo! la instancia es diferencia.");
            }
        }
    }
}
