using System;
using AbstractFactory.AbstractFactory.Interfaces;

namespace AbstractFactory.AbstractFactory
{
    public class QrCode : QrBarcode
    {
        public override void Read()
        {
            Console.WriteLine("QrCode Read...");
        }

        public override void Write()
        {
            Console.WriteLine("QrCode Write...");
        }
    }
}
