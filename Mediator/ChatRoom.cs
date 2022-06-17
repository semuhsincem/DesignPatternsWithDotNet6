using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public  class ChatRoom
    {
        public static string SendMessage(User user,string message)
        {
            return $"{DateTime.Now.ToString()} [{user.GetName()}] :  {message}";
        }
    }
}
