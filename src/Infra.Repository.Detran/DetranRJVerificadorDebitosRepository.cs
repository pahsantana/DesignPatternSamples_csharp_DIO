using DesignPatternSamples.Application.DTO;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranRJVerificadorDebitosRepository : DetranVerificadorDebitosRepositoryCrawlerBase
    {
        private readonly ILogger _LoggerV;

        public DetranRJVerificadorDebitosRepository(ILogger<DetranRJVerificadorDebitosRepository> logger)
        {
            _LoggerV = logger;
        }

        protected override Task<IEnumerable<DebitoVeiculo>> PadronizarResultado(string html)
        {
            _LoggerV.LogDebug($"Padronizando o Resultado {html}.");
            return Task.FromResult<IEnumerable<DebitoVeiculo>>(new List<DebitoVeiculo>() { new DebitoVeiculo() });
        }

        protected override Task<string> RealizarAcesso(Veiculo veiculo)
        {
            _LoggerV.LogDebug($"Consultando débitos do veículo placa {veiculo.Placa} para o estado de RJ.");
            return Task.FromResult("CONTEUDO DO SITE DO DETRAN/RJ");
        }
    }
}
