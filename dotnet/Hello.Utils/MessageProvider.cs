using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello.Utils
{
    public class MessageProvider
    {
        public static string GetMessage()
        {
          return $"Hello World from {System.Environment.MachineName}!";
        }
    }
}
