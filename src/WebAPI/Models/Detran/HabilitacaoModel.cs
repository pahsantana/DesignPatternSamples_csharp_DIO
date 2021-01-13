using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSamples.WebAPI.Models.Detran
{
    public class HabilitacaoModel
    {
        public string CPF { get; set; }
        public int NumeroRegistro { get; set; }
        public string UF { get; set; }
    }
}
