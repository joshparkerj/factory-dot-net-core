using System;

namespace CS3450_Program03_JNP
{
    class Program
    {

        static void Main(string[] args)
        {
            ProgramDriver programDriver = new ProgramDriver();
            programDriver.InitializeRenderFactory();
            programDriver.Menu();
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

    }
}
