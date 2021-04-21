using System;

namespace ClassDemoGIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Feature2Worker worker = new Feature2Worker();
            worker.Start();


            Console.WriteLine("Hello World!");
        }
    }
}
