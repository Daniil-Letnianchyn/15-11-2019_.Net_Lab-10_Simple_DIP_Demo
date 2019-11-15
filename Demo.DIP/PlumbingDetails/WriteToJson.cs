using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DIP
{
    public class WriteToJson : IWriteTo
    {
        public void Write(string message)
        {
            Console.WriteLine($"\"string\": \"{message}\"");
        }
    }
}
