using Microsoft.AspNetCore.Mvc;
using Http_Server.Models;
using Http_Server.Data;
using System.Collections.Generic;

namespace Http_Server.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {   
        private readonly IServerRepo _repo;    
        public MessagesController(IServerRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]  
        public ActionResult <IEnumerable<Message>> GetAllMessages()
        {
            var msgItems = _repo.GetAllMessages();
            
            return Ok(msgItems);
        }

        [HttpPost]  
        public ActionResult <Message> CreateMessage(Message msg)
        {
            _repo.CreateMessage(msg);
            
            return Created("/messages", msg);
        }
    }
}