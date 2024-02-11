using Dapper;
using Microsoft.EntityFrameworkCore;
using ProductCollege.Models;
using ProductCollege.ORMDapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProductCollege
{
	public class ServiceRepo:IserviceRepo
	{
		private readonly DapperContext _dapperContext;

		public ServiceRepo(DapperContext _da) {
		    _dapperContext = _da;
		}

		public async Task<IEnumerable<Game?>> GetallGames()
		{
			var query = "SELECT * FROM Game";
			using (var connection = _dapperContext.CreateConnection())
			{
				
				var Games = await connection.QueryAsync<Game>(query);
				return Games.ToList();
				
			}
		}
		

	}
}
