namespace CS3450_Program03_JNP
{
    class Document
    {
        IPrintDriver printDriver;
        readonly string name;

        public Document(IPrintDriver p, string n)
        {
            printDriver = p;
            name = n;
        }

        public void Print()
        {
            printDriver.Print(this);
        }

        public string GetName()
        {
            return name;
        }

    }
}
