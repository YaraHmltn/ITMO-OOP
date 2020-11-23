using System;
using System.Collections.Generic;
using System.Text;

namespace Parser
{
    public class ConversionErrorException : Exception
    {
        public ConversionErrorException(string message)
            : base(message)
        {

        }
    }
}
