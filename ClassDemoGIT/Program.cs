using System;

namespace ClassDemoGIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Feature1Worker worker = new Feature1Worker();
            worker.Start();

            Console.WriteLine("Hello World!");
        }
    }
}
