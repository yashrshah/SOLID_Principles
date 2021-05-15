namespace InterfaceSegregation
{
    public class OldFashinePrinter : IMachine
    {
        public void Fax()
        {
            throw new System.NotImplementedException();
        }

        public void Print()
        {
            //
        }
        //Here Old fashine Printer can only do print. Why do we need to implement Fax and Scan??
        //It violating InterfaceSegregation principle
        //we will create separeate interface for each function
        public void Scan()
        {
            throw new System.NotImplementedException();
        }
    }
    // RESOLVED InterfaceSegregation
    public class OldFashinePrinter1 : IPrinter
    {
        public void Print()
        {
            //
        }
    }
}
