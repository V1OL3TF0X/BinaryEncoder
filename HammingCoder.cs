using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryEncoder
{
        public class HammingCoder : ICoder
        {
            private string _message;
            private bool[] _msg;
            private int _number_of_bytes;
            bool ExtendedHamming { get; set; }
            public static implicit operator HammingCoder(string v)
            {
                return new HammingCoder(v);
            }
            public HammingCoder(string message = "", bool ExtendedHC = true)
            {
                _message = "";
                _msg = new bool[1];
                newMessage(message);
                ExtendedHamming = ExtendedHC;
            }
            public void newMessage(string message)
            {
                 _message = message;
            }
            public bool DisruptMessage(int disrupt)
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
            public string EncodeMessage()
            {
                _number_of_bytes = 2;
                int encodedBytes = 1;
                while (_message.Length + encodedBytes + 1 > _number_of_bytes)
                {
                    encodedBytes++;
                    _number_of_bytes *= 2;
                } //finds the nearest power of 2 sufficient to code out message
                _number_of_bytes = _message.Length + encodedBytes + 1;
                _msg = new bool[_number_of_bytes];
                int tmp = 1;
                int DataByte = 0;
                for (int i = 1; i < _number_of_bytes; i++)
                {
                    if (i == tmp)
                    {
                        tmp *= 2;
                    }
                    else
                    {
                        if (DataByte < _message.Length) _msg[i] = (int)char.GetNumericValue(_message[DataByte++]) == 1;
                    }
                }


                int ParityCheck = 0;
                for (int i = 0; i < _number_of_bytes; i++)
                {
                    if (_msg[i]) //bits set to 0 won't changee the parity therefore don't need to be checked
                    {
                        ParityCheck ^= i; //because the index signals which parity bits are responsible for checking this bit, we do a xor operation on indeces
                        _msg[0] ^= _msg[i]; //0th bit is the parity bit for the whole message
                    }
                } //for a more thorough explanation of the algorithm see 3Blue1Brown's video: https://www.youtube.com/watch?v=b3NxrZOu_CE
                for (int i = 1; i < _number_of_bytes; i *= 2)
                {
                    _msg[i] = ParityCheck % 2 == 1;
                    _msg[0] ^= _msg[i]; //0th bit is the parity bit for the whole message
                    ParityCheck /= 2;
                }//setting parity bits
                return ToString();
            }
            public (string message, int errorNo, string errorPos) DecodeMessage()
            {
                _msg = new bool[_message.Length];
                _number_of_bytes = _message.Length;

                for (int i = 0; i < _msg.Length; i++)
                    _msg[i] = _message[i] == '1';
                int error_position = 0, number_of_errors = 0;
                bool overallParity = false;
                for (int i = 0; i < _number_of_bytes; i++)
                {
                    if(IsPowerOf2(i)) _msg[i]=false;
                    else _msg[i] = (_message[i]=='1');
                }
                int ParityCheck = 0;
                for (int i = 0; i < _message.Length; i++)
                {
                    if (_msg[i]) //bits set to 0 won't changee the parity therefore don't need to be checked
                    {
                        ParityCheck ^= i; //because the index signals which parity bits are responsible for checking this bit, we do a xor operation on indeces
                        _msg[0] ^= _msg[i]; //0th bit is the parity bit for the whole message
                    }
                } //for a more thorough explanation of the algorithm see 3Blue1Brown's video: https://www.youtube.com/watch?v=b3NxrZOu_CE
                for (int i = 1; i < _message.Length; i *= 2)
                {
                    _msg[i] = ParityCheck % 2 == 1;
                    _msg[0] ^= _msg[i]; //0th bit is the parity bit for the whole message
                    ParityCheck /= 2;
                }//setting parity bits
                string mess = ToString();
                if (mess[0] != _message[0])
                {
                    overallParity = !overallParity;
                }
                for (int i = 1; i < _message.Length; i*=2)
                {
                    if(mess[i]!=_message[i])
                    {
                        error_position+=i;
                        overallParity = !overallParity;
                    }
                }
                if (error_position != 0) //we encountered an error
                {
                    if (!overallParity) //overall parity is even - at least two errors
                        return ("", 2, "");
                    _msg[error_position] ^= true; //error_position points at the bit that d=needs to be flipped
                    number_of_errors++;

                }
                string s = ToString();
                string r = "";
                for(int i = 1; i < s.Length; i++)
                {
                    if(!IsPowerOf2(i)) r+=s[i];
                }
                return (r, number_of_errors, Convert.ToString(error_position));
            }
            private static bool IsPowerOf2(int x)
            {
                return (x & (x - 1)) == 0;
            }
            
            public override string ToString()
            {
                string s = string.Join("", _msg.Select(x => Convert.ToInt32(x)));
                return ExtendedHamming ? s : s[1..];
            }

            int highestPowerof2(int n)
            {
                int res = 0;
                for (int i = n; i >= 1; i--)
                {
                    // If i is a power of 2
                    if ((i & (i - 1)) == 0)
                    {
                        res = i;
                        break;
                    }
                }
                return res;
            }
    }

}
