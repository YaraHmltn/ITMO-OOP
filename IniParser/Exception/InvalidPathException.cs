using System;
using System.Collections.Generic;
using System.Text;

namespace Parser
{
    public class InvalidPathException : Exception
    {

        public InvalidPathException(string message)
            : base(message)
        {

        }
    }
}
