
using System;
using AbstractFactory.AbstractFactory.Factories;
using AbstractFactory.AbstractFactory.Interfaces;

namespace AbstractFactory
{
    // The client code works with factories and products only through abstract
    // types: AbstractFactory and AbstractProduct. This lets you pass any
    // factory or product subclass to the client code without breaking it.
    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code can work with any concrete factory class.
            IAbstractFactory qrFactory = new QrCodeFactory();
            IAbstractFactory barcodeFactory = new BarcodeFactory();

            var qr = qrFactory.GetQrBarcode();
            var barcode = barcodeFactory.GetQrBarcode();

            qr.Read();
            qr.Write();

            barcode.Read();
            barcode.Write();

            Console.ReadKey();
        }
    }
}
