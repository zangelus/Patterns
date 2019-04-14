using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface IUsRoboticsModem
    {
        int PhoneNum { get; set; }
        void send(string octectString);
    }

    class UsRoboticsModem : IUsRoboticsModem
    {
        //private string _octectString = "octectString";
        public int PhoneNum { get; set; }

        public void send(string octectString)
        {
            Console.WriteLine(octectString);
        }
    }
}
