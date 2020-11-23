using System;
using System.Collections.Generic;
using System.Text;

namespace Parser
{
    public class SectionKeyPairDoesntExistsException : Exception
    {
        public SectionKeyPairDoesntExistsException(string message)
            : base(message)
        {

        }
    }
}
