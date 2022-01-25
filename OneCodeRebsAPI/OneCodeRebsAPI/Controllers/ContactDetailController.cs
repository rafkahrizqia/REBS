using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using OneCodeRebs.Models;
using Microsoft.AspNetCore.Mvc;
using OneCodeRebs.Repository;
using OneCodeRebs.Models.REBSModels;
using System.Collections.Generic;

namespace OneCodeRebsAPI.Controllers
{
    [Route("api/[controller]")]
    [Consumes("application/json")]
    [ApiController]
    public class ContactDetailController:ControllerBase
    {
        private readonly REBSContext _context;

        public ContactDetailController(REBSContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<ContactDetail> GetContactDetail()
        {
            return _context.ContactDetails;
        }

    }
}
