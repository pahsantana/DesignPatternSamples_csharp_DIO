using System.Threading.Tasks;

namespace DesignPatternSamples.Domain.Repository.Detran
{
    public interface IDetranConsultarPontuacao
    {
        Task<Pontuacao> ConsultarPontuacao(Habilitacao habilitacao);
    }
}
