using Bookinghut.Model;
using Bookinghut.Model.Request;
using Bookinghut.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookinghut.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenueController : ControllerBase
    {
        private readonly IVenueService _eventService;

        public VenueController(IVenueService eventService)
        {
            _eventService = eventService;
        }
        [HttpGet]
        public async Task<List<MVenue>> Get([FromQuery] VenueSearchRequest search)
        {
            return await _eventService.Get(search);
        }
        [HttpGet("{ID}")]
        public async Task<MVenue> GetById(int ID)
        {
            return await _eventService.GetById(ID);
        }
        [HttpPost]
        public async Task<MVenue> Insert(VenueUpsertRequest request)
        {
            return await _eventService.Insert(request);
        }
        [HttpPut("{ID}")]
        public async Task<MVenue> Update(int ID, VenueUpsertRequest request)
        {
            return await _eventService.Update(ID, request);
        }
        [HttpDelete("{ID}")]
        public async Task<bool> Delete(int ID)
        {
            return await _eventService.Delete(ID);
        }
    }

}
