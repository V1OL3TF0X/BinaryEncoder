using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryEncoder
{
    interface ICoder
    {
        public bool DisruptMessage(int disrupt);
        public void newMessage(string message);
        public string EncodeMessage();
        public (string message, int errorNo) DecodeMessage();
    }
}
