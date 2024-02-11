namespace ProductCollege.Models
{
	public class Game
	{
		public int Id { get; set; }
		public string GameName { get; set; }
		public string GameType {  get; set; }	
		public string Video {  get; set; }
		public Nullable<int> FileSize { get; set; }
		public string FilePath { get; set; }



	}

	public class TGame
	{
		public List<Game>Games { get; set; } = new List<Game>();
	}
	public class VideoFiles
	{
		public int ID { get; set; }
		public string Name { get; set; }
		
	}
}
