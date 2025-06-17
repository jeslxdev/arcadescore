namespace arcadescore_api.Domain;

using arcadescore_api.Domain;

public interface IScoreRepository
{
    void Add(Score score);
    IEnumerable<Score> GetTopScores();
    IEnumerable<Score> GetByPlayer(string player);
}
