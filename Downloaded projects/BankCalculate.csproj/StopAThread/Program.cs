using System;
using System.Threading;

namespace StopAThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(() => {
                while(true)
                {
                    Console.Write(".");
                    Thread.Sleep(100);
                }
            });
            thread.Start();
            Thread thread1 = new Thread(() => {
                while(true)
                {
                    Console.Write("-");
                    Thread.Sleep(100);
                }
            });
            thread1.Start();

            try
            {
                thread.Abort();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Thread is successfuly Aborted");
        }
    }
}
