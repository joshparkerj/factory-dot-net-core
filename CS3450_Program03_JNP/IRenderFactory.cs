namespace CS3450_Program03_JNP
{
    interface IRenderFactory
    {
        IPrintDriver GetPrintDriver();
        IDisplayDriver GetDisplayDriver();
    }
}
