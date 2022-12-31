namespace AbstractFactory.AbstractFactory.Interfaces
{
    // Each distinct object of a object family should have a base class or interface.
    // All variants of the object must implement this class or interface.
    public abstract class QrBarcode
    {
        public abstract void Read();
        public abstract void Write();
    }
}
