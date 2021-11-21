using NetDevPack.Domain;
using System;

namespace softplayer.domain.Models
{
    public class Juros 
    {   
        public Juros(decimal juros) {
            this.juros = juros;
        }

        public long Id { get; set; }
        public decimal juros { get; private set; } 
    }
}
