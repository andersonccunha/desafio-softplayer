using Microsoft.AspNetCore.Identity;
using System;

namespace softplayer.infra.data.EntitiesConfiguration
{
    public class MongoDbIdentityConfiguration
    { 
        public MongoDbSettings MongoDbSettings { get; set; } 
        public Action<IdentityOptions> IdentityOptionsAction { get; set; }
    }
}
