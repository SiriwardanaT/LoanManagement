using LoanManagement.Models.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using LoanManagement.Query;
using LoanManagement.DataAcesses;
using System.Diagnostics;

namespace LoanManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator) {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<UserInfoes>> Get()
        {
          
            return await _mediator.Send(new UserListQuery());
        }

        [HttpGet("{id}")]
        public async Task<UserInfoes> Get(Guid id) {
            return await _mediator.Send(new GetUserById(id));
        }
    }
}
