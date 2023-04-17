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
        public int GenerateNumber()//Creates a method that generates a random number
        {
            Thread.Sleep(2000);//pauses the thread for 2 seconds
            return rnd.Next(-20, 121);//Generates a random number between -20 and 120

        }
        public void CheckTemp()//creates a method that that checks the temperature
        {
            int count = 0;//This is a count variable i use to check how many times the error code has been used
            while (count <3)//Runs the code beloe while count is below 3
            {
                int temp = GenerateNumber();//This uses the GenerateNumber method above and puts it into a variable
                Console.WriteLine(temp);//Writes the temp value to console
                if (temp < 0 || temp > 100)//Checks if the temp is below 0 or above 100
                {
                    Console.WriteLine("Temperaturen ligger ude for det ulovlige interval!!");//Sends the user an error message if true
                    count++;//adds 1 to count 
                }
            }
            Console.WriteLine("Alarm-tråd termineret!");//When count is 3 and the loop stops it gives the user an error code

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
