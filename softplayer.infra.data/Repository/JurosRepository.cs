using MongoDB.Driver;
using NetDevPack.Data;
using softplayer.domain.Interfaces;
using softplayer.domain.Models;
using softplayer.infra.data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.infra.data.Repository
{
    public class JurosRepository : IJurosRepository
    {
        private readonly MongoContext _mongoContext;

        public JurosRepository()
        { 
            _mongoContext = new MongoContext();
        }

        public void Add(Juros juros)
        { 
            _mongoContext.Juros.InsertOne(juros); 
        }
          
        public Juros GetJuros()
        {
           return _mongoContext.Juros.Find(x => true).FirstOrDefault();
        }

        public void Remove()
        {
            _mongoContext.Juros.DeleteMany(x=>true);
        }

        public void Update(Juros juros)
        {
            _mongoContext.Juros.ReplaceOne(x => true, juros);
        }
    }
}
