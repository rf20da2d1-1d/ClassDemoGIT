using System;

namespace ClassDemoGIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Feature1Worker worker1 = new Feature1Worker();
            worker1.Start();

            Feature2Worker worker2 = new Feature2Worker();
            worker2.Start();


            Console.WriteLine("Hello World!");
        }
    }
}
