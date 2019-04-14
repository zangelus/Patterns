using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class UsrModernAdapter : ISerialCommPort
    {
        IUsRoboticsModem _modem;

        public UsrModernAdapter(IUsRoboticsModem modem)
        {
            _modem = modem;
        }

        public void Send(string msg, string destination)
        {
            _modem.PhoneNum = 1111111;
            _modem.send(msg);
        }
    }
}
