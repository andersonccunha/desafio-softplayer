using softplayer.application.Interfaces;
using softplayer.application.Model;
using softplayer.domain.Interfaces;
using softplayer.domain.Models;

namespace softplayer.application.Services
{
    public class JurosService : IJurosService
    {

        private readonly IJurosRepository _repository;
         
        public JurosService(IJurosRepository repository)
        {
            _repository = repository;
        }

        public void Add(JurosViewModel juros)
        {
            var _juros = new Juros(juros.juros); 
            _repository.Add(_juros); 
        }

        public JurosViewModel GetJuros()
        {
            var _juros = _repository.GetJuros();
            if (_juros == null) return new JurosViewModel(0);
            return new JurosViewModel(_juros.juros / 100);
        }

        public void Remove()
        {
           _repository.Remove();
        }

        public void Update(JurosViewModel juros)
        {
           var _juros = new Juros(juros.juros);
            _repository.Update(_juros);
        }
    }
}
