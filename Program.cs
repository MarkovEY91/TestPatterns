using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestPatterns.Порождающие.Singleton;

namespace TestPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton singleton1 = new Singleton();
            //Singleton s1 = Singleton.GetInstance();
            //Singleton s2 = Singleton.GetInstance();

            //if (s1 == s2)
            //{
            //    Console.WriteLine($"s1 ({s1.GetHashCode()}) это s2 ({s2.GetHashCode()}) ");
            //}

            //s1.SomeBuisnessLogic();



            MyForm myForm1 = MyForm.GetInstance();
            MyForm myForm2 = MyForm.GetInstance();

            Thread.Sleep(3000);

            myForm2.SetWidth(1000);



            Console.Read();
        }
    }
}
