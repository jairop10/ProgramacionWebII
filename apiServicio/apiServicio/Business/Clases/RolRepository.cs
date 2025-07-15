using apiServicio.Business.Contracts;
using apiServicio.Models;
using System.Data.SqlClient;

namespace apiServicio.Business.Clases
{
	public class RolRepository : IRolRepository
	{
		private readonly string connect;
		public RolRepository(IConfiguration configuration) 
		{
			connect = configuration.GetConnectionString("conBase");
		}
		public async Task<List<Rol>> GetList()
		{
			List<Rol> list = new List<Rol>();
			Rol l;
			using (SqlConnection conn = new SqlConnection(connect))
			{
				await conn.OpenAsync();
				SqlCommand cmd = new SqlCommand("SELECT * FROM Rol;", conn);
				using (var reader = await cmd.ExecuteReaderAsync())
				{
					while (await reader.ReadAsync())
					{
						l = new Rol();
						l.Id = Convert.ToInt32(reader["Id"]);
						l.NombreRol = Convert.ToString(reader["NombreRol"]);
						list.Add(l);
					}
				}
			}
			return list;
		}
	}
}
