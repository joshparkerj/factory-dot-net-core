using System;

namespace CS3450_Program03_JNP
{
    class LowResPrintDriver : IPrintDriver
    {
        private static LowResPrintDriver uniqueInstance;

        public static LowResPrintDriver GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new LowResPrintDriver();
            return uniqueInstance;
        }

        public void Print(Document document)
        {
            Console.WriteLine($"Printing document, {document.GetName()}, in low resolution.");
        }

    }
}
