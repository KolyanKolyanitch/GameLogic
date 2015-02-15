using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Player
    {
        string Name;
        int[] cards;
        TcpClient client;
        StreamReader reader;
        StreamWriter writer;
    }
}
