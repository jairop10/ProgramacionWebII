using apiServicio.Models;

namespace apiServicio.Services.Contracts
{
	public interface IRolServices
	{
		Task<List<Rol>> GetList();


	}
}
