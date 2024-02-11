using ProductCollege.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProductCollege
{
	public interface IserviceRepo
	{

		public Task<IEnumerable<Game>> GetallGames();
	}
}
