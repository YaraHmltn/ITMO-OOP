using System;
using System.Collections.Generic;
using System.Text;

namespace Parser
{
    public class InvalidExtensionException : Exception
    {
        public InvalidExtensionException(string message)
            : base(message)
        {

        }
    }
}
