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
    public class CompanyController:ControllerBase
    {

        private readonly REBSContext _context;

        public CompanyController(REBSContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Company> GetCompany()
        {
            using (var context = new REBSContext())
            {
                List<Company> companies = context.Companies.ToList();
                foreach (var rec in companies)
                {
                    rec.User = context.Users.Where(x => x.Id == rec.UserId).FirstOrDefault();
                    rec.Notes = context.Notes.Where(x => x.Id == rec.NotesId).FirstOrDefault();
                }
                return companies;
            }
        }
    }
}
