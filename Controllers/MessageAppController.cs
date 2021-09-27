using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_sofka.Contexts;
using webapi_sofka.Entities;
using webapi_sofka.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi_sofka.Controllers
{
    [Route("api/MessageApp")]
    [ApiController]
    public class MessageAppController : ControllerBase
    {
        private readonly IMessageApp _interfaceMessageApp;
        public MessageAppController(IMessageApp MessageApp)
        {
            _interfaceMessageApp = MessageApp;
        }

        [HttpGet("{id}")]
        public MessageApp Get(int id)
        {
            return  _interfaceMessageApp.GetMessage(id);
        }
    }
}
