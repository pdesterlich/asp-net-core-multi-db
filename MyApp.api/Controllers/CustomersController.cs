using Microsoft.AspNetCore.Mvc;
using MyApp.repo;

namespace MyApp.api.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController: Controller
    {
        private readonly IUnitOfWork _repo;

        public CustomersController(IUnitOfWork repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetCustomers());
        }
    }
}