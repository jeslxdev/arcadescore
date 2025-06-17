using arcadescore_api.Application;
using arcadescore_api.Domain;
using arcadescore_api.API.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ScoresController : ControllerBase
{
    private readonly IScoreService _service;

    public ScoresController(IScoreService service) => _service = service;

    /// <summary>
    /// Registra uma nova pontuação para um jogador.
    /// Requer: Data da partida, Pontuação e Jogador.
    /// </summary>
    [HttpPost]
    public IActionResult AddScore([FromBody] ScoreDto scoreDto)
    {
        if (string.IsNullOrWhiteSpace(scoreDto.Player) || scoreDto.Points < 0)
            return BadRequest("Jogador e pontuação válidos são obrigatórios.");
        var score = new Score
        {
            Player = scoreDto.Player,
            Points = scoreDto.Points,
            Date = scoreDto.Date
        };
        _service.AddScore(score);
        return Ok();
    }

    [HttpGet("ranking")]
    public ActionResult<IEnumerable<ScoreDto>> GetRanking()
    {
        var scores = _service.GetTopScores().Select(s => new ScoreDto
        {
            Id = s.Id,
            Player = s.Player,
            Points = s.Points,
            Date = s.Date
        });
        return Ok(scores);
    }

    [HttpGet("player/{playerName}")]
    public ActionResult<PlayerStatisticsDto> GetStatistics(string playerName)
    {
        var stats = _service.GetPlayerStatistics(playerName);
        if (stats == null)
            return NotFound();
        var dto = new PlayerStatisticsDto
        {
            Player = stats.Player,
            TotalGames = stats.TotalGames,
            AverageScore = stats.AverageScore,
            HighestScore = stats.HighestScore,
            LowestScore = stats.LowestScore,
            RecordBeatenTimes = stats.RecordBeatenTimes,
            PlayingTime = stats.PlayingTime
        };
        return Ok(dto);
    }
}
