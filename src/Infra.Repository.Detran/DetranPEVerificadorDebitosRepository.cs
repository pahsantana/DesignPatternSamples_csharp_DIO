using DesignPatternSamples.Application.DTO;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranPEVerificadorDebitosRepository : DetranVerificadorDebitosRepositoryCrawlerBase
    {
        private readonly ILogger _LoggerV;

        public DetranPEVerificadorDebitosRepository(ILogger<DetranPEVerificadorDebitosRepository> logger)
        {
            _LoggerV = logger;
        }

        protected override Task<IEnumerable<DebitoVeiculo>> PadronizarResultado(string html)
        {
            _LoggerV.LogDebug($"Padronizando o Resultado {html}.");
            return Task.FromResult<IEnumerable<DebitoVeiculo>>(new List<DebitoVeiculo>() { new DebitoVeiculo() { DataOcorrencia = DateTime.UtcNow } });
        }

        protected override Task<string> RealizarAcesso(Veiculo veiculo)
        {
            Task.Delay(5000).Wait(); //Deixando o serviço mais lento para evidenciar o uso do CACHE.
            _LoggerV.LogDebug($"Consultando débitos do veículo placa {veiculo.Placa} para o estado de PE.");
            return Task.FromResult("CONTEUDO DO SITE DO DETRAN/PE");
        }
    }
}
