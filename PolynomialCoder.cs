using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryEncoder
{
    internal class PolynomialCoder : ICoder
    {
        public (string message, int errorNo, string errorPos) DecodeMessage()
        {
            throw new NotImplementedException();
        }

        public bool DisruptMessage(int disrupt)
        {
            throw new NotImplementedException();
        }

        public string EncodeMessage()
        {
            throw new NotImplementedException();
        }

        public void newMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
