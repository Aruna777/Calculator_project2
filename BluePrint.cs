using System;
namespace WebAPI.Data
{
	public class BluePrint
	{
		public int Id { get; set; }
		public string ToCalculator { get; set; }
		public int CorrectIndex { get; set; }
		public List<int> Tokens { get; set; }
	}
}

