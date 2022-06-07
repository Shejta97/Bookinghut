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
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<List<MUser>> Get([FromQuery] UserSearchRequestdto search)
        {
            return await _service.Get(search);
        }
        [HttpGet("{ID}")]
        public async Task<MUser> GetById(int ID)
        {
            return await _service.GetById(ID);
        }
        [HttpPost]
        public async Task<MUser> Insert(UserUpsertRequestdto request)
        {
            return await _service.Insert(request);
        }
        [HttpPut("{ID}")]
        public async Task<MUser> Update(int ID, UserUpsertRequestdto request)
        {
            return await _service.Update(ID, request);
        }
        [HttpDelete("{ID}")]
        public async Task<bool> Delete(int ID)
        {
            return await _service.Delete(ID);
        }
    }
}
