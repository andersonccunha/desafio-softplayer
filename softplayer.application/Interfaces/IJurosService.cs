using softplayer.application.Model;
using softplayer.domain.Models;

namespace softplayer.application.Interfaces
{
    public interface IJurosService
    {
        JurosViewModel GetJuros();

        void Add(JurosViewModel juros);
        void Update(JurosViewModel juros);
        void Remove();
    }
}
