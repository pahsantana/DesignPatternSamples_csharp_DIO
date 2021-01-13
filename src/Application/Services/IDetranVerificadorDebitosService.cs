using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Services
{
    public interface IDetranConsultarPontuacaoService
    {
        Task<IEnumerable<Pontuacao>> ConsultarPontuacao(Habilitacao habilitacao);
    }
}
