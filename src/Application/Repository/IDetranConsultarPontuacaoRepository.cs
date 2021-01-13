using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranConsultarPontuacaoRepository
    {
        Task<IEnumerable<Pontuacao>> ConsultarPontuacao(Habilitacao habilitacao);
    }
}
