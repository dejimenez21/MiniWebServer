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

        //GET /messages
        [HttpGet]  
        public ActionResult <IEnumerable<Message>> GetAllMessages()
        {
            var msgItems = _repo.GetAllMessages();
            
            return Ok(msgItems);
        }

        //POST /messages
        [HttpPost]  
        public ActionResult <Message> CreateMessage(Message msg)
        {
            _repo.CreateMessage(msg);
            
            return Created("/messages", msg);
        }

        //PUT /messages/{id}
        [HttpPut("{id}")]
        public ActionResult<Message> UpdateMessage(int id, Message msg)
        {
            msg.Id = id;
            _repo.UpdateMessage(msg);
            return Ok(msg);
        }
    }
}