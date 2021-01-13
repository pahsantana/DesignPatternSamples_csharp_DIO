using DesignPatternSamples.Application.DTO;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranRJConsultarPontuacaoRepository : DetranConsultarPontuacaoRepositoryCrawlerBase
    {
        private readonly ILogger _LoggerP;

        public DetranRJConsultarPontuacaoRepository(ILogger<DetranRJConsultarPontuacaoRepository> logger)
        {
            _LoggerP = logger;
        }

        protected override Task<IEnumerable<Pontuacao>> PadronizarResultado(string html)
        {
            _LoggerP.LogDebug($"Padronizando o Resultado {html}.");
            return Task.FromResult<IEnumerable<Pontuacao>>(new List<Pontuacao>() { new Pontuacao() });
        }

        protected override Task<string> RealizarAcesso(Habilitacao habilitacao)
        {
            _LoggerP.LogDebug($"Consultando a pontuação da CNH {habilitacao.NumeroRegistro} para o estado de RJ.");
            return Task.FromResult("CONTEUDO DO SITE DO DETRAN/RJ");
        }
    }
}
