using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocService.Core
{
    public class Engine
    {
        

        private readonly IFsWatcher _watcher;
        private readonly IStorageConnector _storageConnector;

        public Engine(IFsWatcher watcher, IStorageConnector storageConnector)
        {
            
            _watcher = watcher;
            _storageConnector = storageConnector;
        }

        public void Start()
        {
            
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
