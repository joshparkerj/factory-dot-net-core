using System;

namespace CS3450_Program03_JNP
{
    class LowResDisplayDriver : IDisplayDriver
    {
        private static LowResDisplayDriver uniqueInstance;

        public static LowResDisplayDriver GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new LowResDisplayDriver();
            return uniqueInstance;
        }

        public void Display(Widget widget)
        {
            Console.WriteLine($"Drawing widget, {widget.GetName()}, in low resolution");
        }

    }
}
