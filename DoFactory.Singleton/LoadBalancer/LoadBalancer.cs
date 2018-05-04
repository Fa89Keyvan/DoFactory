using System;
using System.Collections.Generic;
using System.Text;

namespace DoFactory.Singleton.LoadBalancer
{
    class LoadBalancer
    {
        private static LoadBalancer _instance;
        private List<string> _servers = new List<string>();

        private static object _syncLock = new object();
        protected LoadBalancer()
        {
            // List of available servers
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
            
        }

        // Support multithreaded applications through
        // 'Double checked locking' pattern which (once
        // the instance exists) avoids locking each
        // time the method is invoked
        public static LoadBalancer SingleInstance
        {
            get
            {
                if(_instance == null)
                {
                    lock (_syncLock)
                    {
                        if(_instance == null)
                        {
                            _instance = new LoadBalancer();
                        }
                    }
                }

                return _instance;
            }
        }

    }
}
