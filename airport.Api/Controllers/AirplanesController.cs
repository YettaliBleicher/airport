﻿using airport.Core.Services;
using airport.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplanesController : ControllerBase
    {
        private readonly IAirplaneService _airplaneService;
        public AirplanesController(IAirplaneService airplaneService)
        {
            _airplaneService = airplaneService;
        }

        [HttpGet]
        public IEnumerable<Airplane> Get()
        {
            return _airplaneService.GetList();
        }

        [HttpGet("{id}")]
        public Airplane Get(int airplanId)
        {
            return _airplaneService.GetList().FirstOrDefault(a => a.airplanId == airplanId);
        }

        /*
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */
    }
}
