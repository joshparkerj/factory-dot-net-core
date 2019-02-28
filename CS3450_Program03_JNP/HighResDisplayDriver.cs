using System;

namespace CS3450_Program03_JNP
{
    class HighResDisplayDriver : IDisplayDriver
    {
        private static HighResDisplayDriver uniqueInstance;

        public static HighResDisplayDriver GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new HighResDisplayDriver();
            return uniqueInstance;
        }

        public void Display(Widget widget)
        {
            Console.WriteLine($"Drawing widget, {widget.GetName()}, in high resolution");
        }

    }
}
