using System;

namespace CS3450_Program03_JNP
{
    class HighResPrintDriver : IPrintDriver
    {
        private static HighResPrintDriver uniqueInstance;

        public static HighResPrintDriver GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new HighResPrintDriver();
            return uniqueInstance;
        }

        public void Print(Document document)
        {
            Console.WriteLine($"Printing document, {document.GetName()}, in high resolution.");
        }

    }
}
