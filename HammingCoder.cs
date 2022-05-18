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
            private bool[] msg;
            private int numOfBytes;
            bool ExtendedHamming { get; set; }
            public static implicit operator HammingCoder(string v)
            {
                return new HammingCoder(v);
            }
            public HammingCoder(string message = "", bool ExtendedHC = true)
            {
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
                        disrupt = r.Next(0, msg.Length - 1);
                    }
                    else if (disrupt >= msg.Length) disrupt = msg.Length - 1;
                    msg[disrupt] ^= true;
                } //gets a random/specified bit in the coded data and flips it 
                return true;
            }
            public string EncodeMessage()
            {
                numOfBytes = 2;
                int encodedBytes = 1;
                while (_message.Length + encodedBytes + 1 > numOfBytes)
                {
                    encodedBytes++;
                    numOfBytes *= 2;
                } //finds the nearest power of 2 sufficient to code out message
                numOfBytes = _message.Length + encodedBytes + 1;
                msg = new bool[numOfBytes];
                int tmp = 1;
                int DataByte = 0;
                for (int i = 1; i < numOfBytes; i++)
                {
                    if (i == tmp)
                    {
                        tmp *= 2;
                    }
                    else
                    {
                        if (DataByte < _message.Length) msg[i] = (int)char.GetNumericValue(_message[DataByte++]) == 1;
                    }
                }


                int ParityCheck = 0;
                for (int i = 0; i < numOfBytes; i++)
                {
                    if (msg[i]) //bits set to 0 won't changee the parity therefore don't need to be checked
                    {
                        ParityCheck ^= i; //because the index signals which parity bits are responsible for checking this bit, we do a xor operation on indeces
                        msg[0] ^= msg[i]; //0th bit is the parity bit for the whole message
                    }
                } //for a more thorough explanation of the algorithm see 3Blue1Brown's video: https://www.youtube.com/watch?v=b3NxrZOu_CE
                for (int i = 1; i < numOfBytes; i *= 2)
                {
                    msg[i] = ParityCheck % 2 == 1;
                    msg[0] ^= msg[i]; //0th bit is the parity bit for the whole message
                    ParityCheck /= 2;
                }//setting parity bits
                return ToString();
            }
            public (string message, int errorNo) DecodeMessage()
            {
                msg = new bool[_message.Length];
                numOfBytes = _message.Length;

                for (int i = 0; i < msg.Length; i++)
                    msg[i] = _message[i] == '1';
                int ErrPos = 0, errNo = 0;
                bool overallParity = false;
                for (int i = 0; i < numOfBytes; i++)
                {
                    if(IsPowerOf2(i)) msg[i]=false;
                    else msg[i] = (_message[i]=='1');
                }
                int ParityCheck = 0;
                for (int i = 0; i < _message.Length; i++)
                {
                    if (msg[i]) //bits set to 0 won't changee the parity therefore don't need to be checked
                    {
                        ParityCheck ^= i; //because the index signals which parity bits are responsible for checking this bit, we do a xor operation on indeces
                        msg[0] ^= msg[i]; //0th bit is the parity bit for the whole message
                    }
                } //for a more thorough explanation of the algorithm see 3Blue1Brown's video: https://www.youtube.com/watch?v=b3NxrZOu_CE
                for (int i = 1; i < _message.Length; i *= 2)
                {
                    msg[i] = ParityCheck % 2 == 1;
                    msg[0] ^= msg[i]; //0th bit is the parity bit for the whole message
                    ParityCheck /= 2;
                }//setting parity bits
                string mess = ToString();
                for(int i = 1; i < _message.Length; i*=2)
                {
                    if(mess[i]!=_message[i])
                    {
                        ErrPos+=i;
                        overallParity = !overallParity;
                    }
                }
                if (ErrPos != 0) //we encountered an error
                {
                    if (!overallParity) //overall parity is even - at least two errors
                        return ("", 2);
                    msg[ErrPos] ^= true; //ErrPos points at the bit that d=needs to be flipped
                    errNo++;

                }
                string s = ToString();
                string r = "";
                for(int i = 1; i < s.Length; i++)
                {
                    if(!IsPowerOf2(i)) r+=s[i];
                }
                return (r, errNo);
            }
            private static bool IsPowerOf2(int x)
            {
                return (x & (x - 1)) == 0;
            }
            
            public override string ToString()
            {
                string s = string.Join("", msg.Select(x => Convert.ToInt32(x)));
                return ExtendedHamming ? s : s[1..];
            }
        }

}
