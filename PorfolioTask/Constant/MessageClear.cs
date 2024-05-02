using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.Constant
{
    public class MessageClear
    { 
        public void Message(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine("-------------------------------");
        }
    }
}
