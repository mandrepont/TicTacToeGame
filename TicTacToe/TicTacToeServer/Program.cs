﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeServer.Database;
using TicTacToeServer.Database.Domains;
using TicTacToeServer.Database.Respositorys;
using TicTacToeServer.Enums;
using TicTacToeServer.Networking;
using TicTacToeServer.Other;

namespace TicTacToeServer
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Server server = new Server();
            server.StartListening();
            NHibernateHelper.CreateSessionFactory();
            while (true)
            {
                Console.Read();
                return;
            }
        }
    }
}