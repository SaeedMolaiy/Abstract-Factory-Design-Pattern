using System;
using AbstractFactory.AbstractFactory.Interfaces;

namespace AbstractFactory.AbstractFactory
{
    public class BarCode : QrBarcode
    {
        public override void Read()
        {
            Console.WriteLine("BarCode Read...");
        }

        public override void Write()
        {
            Console.WriteLine("BarCode Write...");
        }
    }
}
