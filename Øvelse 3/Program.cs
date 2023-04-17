using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Øvelse_3
{
    class MyClass
    {
        Random rnd = new Random();
        public int GenerateNumber()
        {
            Thread.Sleep(2000);
            return rnd.Next(-20, 121);

        }
        public void CheckTemp()
        {
            int count = 0;
            while (count <3)
            {
                int temp = GenerateNumber();
                Console.WriteLine(temp.ToString());
                if (temp < 0 || temp > 100)
                {
                    Console.WriteLine("Temperaturen ligger ude for det ulovlige interval!!");
                    count++;
                }
            }
            Console.WriteLine("Alarm-tråd termineret!");

        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Thread t1 = new Thread(mc.CheckTemp);
            t1.Start();
            Console.Read();
        }
    }
}
