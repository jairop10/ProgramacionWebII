using apiServicio.Models;
using apiServicio.Services.Contracts;
using Microsoft.AspNetCore.Identity;

namespace apiServicio.Services.Clases
{
	public class RolServices:IRolServices
	{
		private readonly IRolServices _repository;
		public RolServices(IRolServices repository)
		{
			_repository = repository;
		}
		public Task<List<Rol>> GetList()
		{
			return _repository.GetList();
		}
	}
}
