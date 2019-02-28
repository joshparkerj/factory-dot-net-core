namespace CS3450_Program03_JNP
{
    class LowResRenderFactory : IRenderFactory
    {

        public IPrintDriver GetPrintDriver()
        {
            return LowResPrintDriver.GetInstance();
        }

        public IDisplayDriver GetDisplayDriver()
        {
            return LowResDisplayDriver.GetInstance();
        }

    }
}
