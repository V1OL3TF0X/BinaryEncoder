using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryEncoder
{
    internal class PolynomialCoder : Coder
    {
        private bool[] poly;
        public int polyLen { get; private set; }
        public static implicit operator PolynomialCoder(string v)
        {
            return new PolynomialCoder(v);
        }
        public PolynomialCoder(string message = "") : base(message)
        {
            poly = new bool[] { true, false, true, true };
            polyLen = 4;
        }
        public override (string message, int errorNo, string errorPos) DecodeMessage()
        {
            _number_of_bytes = _message.Length;
            _msg = new bool[_number_of_bytes];
            for (int i = 0; i < _message.Length; i++)
                _msg[i] = _message[i] == '1';
            bool[] transmitted_msg = new bool[_number_of_bytes];
            _msg.CopyTo(transmitted_msg, 0);
            var rem = dividePolynomials(transmitted_msg);
            int errorNo = 0;
            foreach (var b in rem)
                if (b) errorNo++;
            return (ToString()[..^(polyLen - 1)], errorNo, "undefined");
        }

        public override string EncodeMessage()
        {
            _number_of_bytes = _message.Length + polyLen - 1;
            _msg = new bool[_number_of_bytes];
            for (int i = 0; i < _message.Length; i++)
                _msg[i] = _message[i] == '1';
            bool[] transmitted_msg = new bool[_number_of_bytes];
            _msg.CopyTo(transmitted_msg, 0);
            dividePolynomials(transmitted_msg).CopyTo(_msg, _message.Length);
            return ToString();
        }
        public bool[] dividePolynomials(bool[] toDivide)
        {
            var polyVal = eval(poly);
            Console.WriteLine(polyVal);
            int first = 0;
            for (int i = 0; i <= toDivide.Length - polyLen; i++)
            {   
                var toEval = toDivide[first..(i + polyLen)];
                Console.WriteLine(string.Join("", toEval.Select(x => Convert.ToInt32(x))));
                Console.WriteLine(eval(toEval));
                if (eval(toEval) >= polyVal)
                {
                    for (int j = 0; j < polyLen; j++)
                    {
                        toDivide[first + j] ^= poly[j];
                    }
                        
                }
                    
                var toEval2 = toDivide[first..(i + polyLen)];
                Console.WriteLine(string.Join("", toEval2.Select(x => Convert.ToInt32(x))));
                Console.WriteLine(eval(toEval2));
                if (eval(toEval) < polyVal && toEval[0]) first = i;
                else first = i + 1;
                
            }
                
            return toDivide[^(polyLen - 1)..];
        }
        public int eval(bool[] slice)
        {
            int val = 0;
            for (int i = 0; i < slice.Length; i++)
            {
                if (slice[i]) val++;
                val *= 2;
            }
            return val / 2;
        }
    }
}
