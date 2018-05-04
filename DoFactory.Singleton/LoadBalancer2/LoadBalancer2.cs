using System;
using System.Collections.Generic;
using System.Linq;

namespace DoFactory.Singleton.LoadBalancer2
{
    class LoadBalancer2
    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        private static readonly LoadBalancer2 _singleInstance = new LoadBalancer2();

        private List<Server> _serversList;
        private Random _random = new Random();

        private LoadBalancer2()
        {
            _serversList = new List<Server>
            {
                new Server{ Name = "ServerI", IP = "120.14.220.18" },
                new Server{ Name = "ServerII", IP = "120.14.220.19" },
                new Server{ Name = "ServerIII", IP = "120.14.220.20" },
                new Server{ Name = "ServerIV", IP = "120.14.220.21" },
                new Server{ Name = "ServerV", IP = "120.14.220.22" }
            };
        }

        public static LoadBalancer2 SingleInstance
        {
            get
            {
                return _singleInstance;
            }
        }

        public Server NextServer
        {
            get
            {
                var i = _random.Next(_serversList.Count());
                return _serversList[i];
            }
        }

    }
}
