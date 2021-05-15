namespace InterfaceSegregation
{
    public class MultiFunctionPrinter : IPrinter,IScan,IFax
    {
        public void Fax()
        {
            //
        }

        public void Print()
        {
            //
        }

        public void Scan()
        {
           //
        }
    }
}
