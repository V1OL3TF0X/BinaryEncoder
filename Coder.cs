using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryEncoder
{
     public abstract class Coder
    {
        protected string _message;
        protected bool[] _msg;
        protected int _number_of_bytes;

        public Coder(string message = "")
        {
            _message = message;
            _msg = new bool[1];
            newMessage(message);
        }
        public virtual bool DisruptMessage(int disrupt)
        {
            if (disrupt > -2)
            {
                if (disrupt == -1)
                {
                    Random r = new();
                    disrupt = r.Next(0, _msg.Length - 1);
                }
                else if (disrupt >= _msg.Length) disrupt = _msg.Length - 1;
                _msg[disrupt] ^= true;
            } //gets a random/specified bit in the coded data and flips it 
            return true;
        }
        public virtual void newMessage(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return string.Join("", _msg.Select(x => Convert.ToInt32(x)));
        }

        public abstract string EncodeMessage();
        public abstract (string message, int errorNo, string errorPos) DecodeMessage();
    }
}
