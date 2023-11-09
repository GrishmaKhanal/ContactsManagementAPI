using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContactsManagementAPI.Models;
using ContactsManagementAPI.Services.ContactDetailService;

namespace ContactsManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDetailsController : ControllerBase
    {
        private readonly IContactDetailService _contactDetailService;
        public ContactDetailsController(IContactDetailService contactDetailService) 
        {
            _contactDetailService = contactDetailService;
        }

        [HttpGet]

        public async Task<ActionResult<List<ContactDetails>>> GetAllContacts()
        {
            return await _contactDetailService.GetAllContacts();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<ContactDetails>>> GetContactById(int id)
        {
            var result = await _contactDetailService.GetContactById(id);

            if (result == null) return NotFound("The Contact Doesn't Exist.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<ContactDetails>>> AddContact(ContactDetails contact)
        {
            return await _contactDetailService.AddContact(contact);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<ContactDetails>>> UpdateContact(int id, ContactDetails request)
        {
            var result = await _contactDetailService.UpdateContact(id, request);
            if (result == null) return NotFound("This contact Doesnot exist to Update."); 

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ContactDetails>>> DeleteContact(int id)
        {
            var result = await _contactDetailService.DeleteContact(id);
            if (result == null) return NotFound("This Contact Doesn't Exist.");

            return Ok(result);
        }
    }
}
