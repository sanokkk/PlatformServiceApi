using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.DAL.Dtos;
using PlatformService.DAL.Interfaces;
using PlatformService.Domain.Models;

namespace PlatformService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlatformController: ControllerBase
    {
        private readonly IPlatfromRepo _platform;
        private readonly IMapper _map;

        public PlatformController(IPlatfromRepo platform, IMapper map)
        {
            _platform = platform;
            _map = map;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> Get()
        {
            var response = _platform.Get();

            return Ok(_map.Map<IEnumerable<PlatformReadDto>>(response));
        }

        [HttpGet("{id}", Name ="GetById")]
        public ActionResult<PlatformReadDto> GetById(int id)
        {
            var response = _platform.GetById(id);
            if (response is not null)
                return Ok(_map.Map<PlatformReadDto>(response));
            return NotFound();
        }

        [HttpPost]
        public ActionResult<PlatformReadDto> Create([FromBody]CreatePlatformDto model)
        {
            var response = _map.Map<Platform>(model);

            _platform.Create(response);
            if (_platform.SaveChanges()) {
                var readModel = _map.Map<PlatformReadDto>(response);
                return CreatedAtRoute(nameof(GetById), new  { Id = readModel.Id }, readModel);
            }
            return BadRequest();
        }


    }
}
