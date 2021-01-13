using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public abstract class DetranConsultarPontuacaoRepositoryCrawlerBase : IDetranConsultarPontuacaoRepository
    {
        public async Task<IEnumerable<Pontuacao>> ConsultarPontuacao(Habilitacao habilitacao)
        {
            var html = await RealizarAcesso(habilitacao);
            return await PadronizarResultado(html);
        }

        protected abstract Task<string> RealizarAcesso(Habilitacao habilitacao);
        protected abstract Task<IEnumerable<Pontuacao>> PadronizarResultado(string html);
    }
}
