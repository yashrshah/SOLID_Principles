namespace InterfaceSegregation
{
    public class MultiFunctionMachine : IScan, IPrinter
    {
        // What if we want to add new machine and we just need to combine two existing functionality then
        // we can use delagation also known as decorative pattern
        private IPrinter printer;
        private IScan scan;
        public MultiFunctionMachine(IPrinter printer, IScan scan)
        {
            this.printer = printer;
            this.scan = scan;
        }
        public void Print()
        {
            printer.Print();
        }

        public void Scan()
        {
            scan.Scan();
        }
    }
}
