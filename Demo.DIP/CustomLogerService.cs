using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DIP
{
    class CustomLogerService : ICustomLog
    {
        private IWriteTo _writeTo;
        public CustomLogerService(IWriteTo writeTo)
        {
            _writeTo = writeTo;
        }

        public void LogError(string message)
        {
            _writeTo.Write(message);
        }
    }
}
