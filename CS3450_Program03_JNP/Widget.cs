namespace CS3450_Program03_JNP
{
    class Widget
    {
        IDisplayDriver displayDriver;
        readonly string name;

        public Widget(IDisplayDriver d, string n)
        {
            displayDriver = d;
            name = n;
        }

        public void Draw()
        {
            displayDriver.Display(this);
        }

        public string GetName()
        {
            return name;
        }

    }
}
