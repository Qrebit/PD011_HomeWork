using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boards
{
    public delegate void Message(string Message);
    public abstract class BaseBoard
    {
        public Message Info;
        public Message Error;
        public Message List;
    }
}
