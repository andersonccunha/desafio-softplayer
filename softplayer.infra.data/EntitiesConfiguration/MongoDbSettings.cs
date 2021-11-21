using System;
using System.Collections.Generic;
using System.Text;

namespace softplayer.infra.data.EntitiesConfiguration
{
    public class MongoDbSettings
    { 
        public string ConnectionString { get; set; } 
        public string DatabaseName { get; set; }
    }
}
