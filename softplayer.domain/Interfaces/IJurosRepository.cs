using NetDevPack.Data;
using softplayer.domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace softplayer.domain.Interfaces
{
    public interface IJurosRepository  
    {
        Juros GetJuros(); 

        void Add(Juros juros);
        void Update(Juros juros);
        void Remove();
    }
}
