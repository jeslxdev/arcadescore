using arcadescore_api.Domain;

namespace arcadescore_api.Infrastructure;

public class InMemoryScoreRepository : IScoreRepository
{
    private readonly List<Score> _scores = new();
    private int _nextId = 1;

    public void Add(Score score)
    {
        // Garante Id auto-incremento
        score.Id = _nextId++;
        _scores.Add(score);
    }

    public IEnumerable<Score> GetTopScores() => _scores.OrderByDescending(s => s.Points).Take(10);

    public IEnumerable<Score> GetByPlayer(string player) => _scores.Where(s => s.Player == player);
}

