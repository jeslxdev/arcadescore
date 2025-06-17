using arcadescore_api.Domain;
using arcadescore_api.Application;

namespace arcadescore_api.Services;

public class ScoreService : IScoreService
{
    private readonly IScoreRepository _repo;
    public ScoreService(IScoreRepository repo) => _repo = repo;

    public void AddScore(Score score) => _repo.Add(score);

    public IEnumerable<Score> GetTopScores() => _repo.GetTopScores();

    public PlayerStatistics? GetPlayerStatistics(string player)
    {
        var scores = _repo.GetByPlayer(player).OrderBy(s => s.Date).ToList();
        if (!scores.Any())
            return null;

        int recordBeatenCount = 0;
        int currentRecord = scores.First().Points;
        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i].Points > currentRecord)
            {
                recordBeatenCount++;
                currentRecord = scores[i].Points;
            }
        }

        // Corrigir cálculo do tempo jogado: se só tem uma partida, tempo é zero
        TimeSpan playingTime = TimeSpan.Zero;
        if (scores.Count > 1)
            playingTime = scores.Last().Date - scores.First().Date;

        return new PlayerStatistics
        {
            Player = player,
            TotalGames = scores.Count,
            AverageScore = scores.Average(s => s.Points),
            HighestScore = scores.Max(s => s.Points),
            LowestScore = scores.Min(s => s.Points),
            RecordBeatenTimes = recordBeatenCount,
            PlayingTime = playingTime
        };
    }
}
