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
        public ActionResult CreateMessage(Message msg)
        {
            _repo.CreateMessage(msg);
            
            return Created("/messages", msg);
        }

        //PUT /messages/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateMessage(int id, Message msg)
        {
            msg.Id = id;
            _repo.UpdateMessage(msg);
            return Ok(msg);
        }

        //DELETE /messages/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteMessage(int id)
        {
            _repo.DeleteMessage(id);
            return Ok();
        }
    }
}