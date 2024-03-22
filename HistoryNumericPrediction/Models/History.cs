namespace HistoryNumericPrediction.Models
{
	public class History
	{
		public string? UUID { get; set; }
		public string? Name { get; set; }
		public List<string>? Tags { get; set; }
		public int Value { get; set; }
		public DateTime Moment { get; set; }
	}
}