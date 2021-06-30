using System;
using System.Drawing;
using System.IO;
using IronBarCode;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tryImage = new Bitmap("C:\\MeterPhotos\\456.png");
            var dataByteArray = BarcodeReader.QuicklyReadOneBarcode(tryImage);
            if (dataByteArray == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                Console.WriteLine(dataByteArray.Text);
            }
        }
    }
}