using AutoMapper;
using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using DesignPatternSamples.WebAPI.Models;
using DesignPatternSamples.WebAPI.Models.Detran;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.WebAPI.Controllers.Detran
{
    [Route("api/Detran/[controller]")]
    [ApiController]
    public class PontuacaoController : ControllerBase
    {
        private readonly IMapper _Mapper;
        private readonly IDetranConsultarPontuacaoService _DetranConsultarPontuacaoServices;

        public PontuacaoController(IMapper mapper, IDetranConsultarPontuacaoService detranConsultarPontuacaoServices)
        {
            _Mapper = mapper;
            _DetranConsultarPontuacaoServices = detranConsultarPontuacaoServices;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(SuccessResultModel<IEnumerable<PontuacaoModel>>), StatusCodes.Status200OK)]
        public async Task<ActionResult> Get([FromQuery]HabilitacaoModel model)
        {
            var pontuacao = await _DetranConsultarPontuacaoServices.ConsultarPontuacao(_Mapper.Map<Habilitacao>(model));

            var result = new SuccessResultModel<IEnumerable<PontuacaoModel>>(_Mapper.Map<IEnumerable<PontuacaoModel>>(pontuacao));

            return Ok(result);
        }
    }
}