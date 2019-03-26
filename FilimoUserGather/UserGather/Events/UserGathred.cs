using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilimoUserGather.UserGather.Events
{
    public class UserGathred
    {
        public delegate void UsergathredDelegate(String username);
        public event UsergathredDelegate UsergathredEvent;

        public void Call(String username)
        {
            if (UsergathredEvent != null)
                UsergathredEvent(username);
        }
    }
}
