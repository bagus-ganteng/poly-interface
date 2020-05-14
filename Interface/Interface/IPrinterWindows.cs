using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
   
        public interface IPrinterWindows
        {
            void Show();
            void Print();

        }
        public class LasetJet : IPrinterWindows
        {
            public void Show()
            {
                Console.WriteLine("LasetJet display dimension : 12*12");
            }

            public void Print()
            {
                Console.WriteLine("LasetJet printer printing ...");
            }
        }

        public class Canon : IPrinterWindows
        {
            public void Show()
            {
                Console.WriteLine("Canon display dimension : 9.5*12");
            }

            public void Print()
            {
                Console.WriteLine("Canon printer printing ...");
            }
        }

        public class Epson : IPrinterWindows
        {
            public void Show()
            {
                Console.WriteLine("Epson display dimension : 10*11");
            }

            public void Print()
            {
                Console.WriteLine("Epson printer printing ...");
            }
        }

    
}
