namespace InterfaceSegregation
{
    public interface IPrinter
    {
        void Print();
    }
    public interface IScan
    {
        void Scan();
    }
    public interface IFax
    {
        void Fax();
    }
}
