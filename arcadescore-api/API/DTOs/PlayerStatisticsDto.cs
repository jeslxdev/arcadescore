namespace arcadescore_api.API.DTOs;

public class PlayerStatisticsDto
{
    public required string Player { get; set; }
    public int TotalGames { get; set; }
    public double AverageScore { get; set; }
    public int HighestScore { get; set; }
    public int LowestScore { get; set; }
    public int RecordBeatenTimes { get; set; }
    public TimeSpan PlayingTime { get; set; }
}
