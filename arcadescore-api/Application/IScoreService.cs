namespace arcadescore_api.Application;

using arcadescore_api.Domain;

public interface IScoreService
{
    void AddScore(Score score);
    IEnumerable<Score> GetTopScores();
    PlayerStatistics? GetPlayerStatistics(string player);
}
