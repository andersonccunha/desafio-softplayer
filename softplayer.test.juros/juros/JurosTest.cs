using softplayer.domain.Interfaces;
using softplayer.domain.Models;
using Xunit;

namespace softplayer.test.juros.juros
{
    public class JurosTest
    {

        private IJurosRepository rep;


        public JurosTest(IJurosRepository _rep)
        {
            this.rep = _rep;
        }

        /// <summary>
        /// teste salvar
        /// </summary>
        [Theory]
        [InlineData(3)]
        [InlineData(1)]
        public void SaveOk(decimal taxajuros)
        {
            Juros _juros = new Juros(taxajuros);
            rep.Add(_juros);
        }
         

        /// <summary>
        /// Entidade nula
        /// </summary>
        /// <param name="juros"></param>
        [Theory]
        [InlineData(null)]
        public void SaveEntityNull(Juros juros)
        {
            Assert.Equal(null, juros);
        }

        /// <summary>
        /// Verificar se esta retornando Taxa Juros
        /// </summary>
        [Fact]
        public void NotNull()
        {
            Assert.NotNull(rep.GetJuros());
        }
    }
}
