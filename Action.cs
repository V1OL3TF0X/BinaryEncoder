using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryEncoder
{
    enum Action
    {
        encode,
        decode,
        disrupt_and_decode,
    }
    internal class ActionUser
    {
        private Action _action;

        public ActionUser(Action action = Action.encode)
        {
            _action = action;
        }

        public void ChangeAction(Action action)
        {
            this._action = action;
        }
        public (string message, int errors, string? position) TakeAction(ICoder coder)
        {
            switch(_action)
            {
                case Action.encode:
                    return (coder.EncodeMessage(),0,"");
                case Action.decode:
                    return coder.DecodeMessage();
                case Action.disrupt_and_decode:
                    coder.DisruptMessage(-1);
                    coder.newMessage(coder.ToString());
                    return coder.DecodeMessage();
            }
            return ("",0,"");
        }
    }
}
