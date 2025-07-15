using apiServicio.Models;
using apiServicio.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace apiServicio.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class RolController
	{
		private readonly IRolServices rolServices;
		public RolController(IRolServices rolServices)
		{
			this.rolServices = rolServices;
		}
		[HttpGet]
		public async Task<List<Rol>> GetList()
		{
			return await this.rolServices.GetList();
		}
	}
}
