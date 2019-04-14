using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Client
    {
        public Client()
        {
            var modem = new UsRoboticsModem();
            var request = new UsrModernAdapter(modem);
            request.Send("octectStringTest", "destination");
        }
    }
}
