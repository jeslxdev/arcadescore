namespace arcadescore_api.Domain;

public class PlayerStatistics
{
    public string Player { get; set; }
    public int TotalGames { get; set; }
    public double AverageScore { get; set; }
    public int HighestScore { get; set; }
    public int LowestScore { get; set; }
    public int RecordBeatenTimes { get; set; }
    public TimeSpan PlayingTime { get; set; }
}
