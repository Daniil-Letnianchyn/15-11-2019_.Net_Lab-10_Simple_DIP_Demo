using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DIP
{
    class WriteToXML : IWriteTo
    {
        public void Write(string message)
        {
            Console.WriteLine($"<string>{message}</srting>");
        }
    }
}
