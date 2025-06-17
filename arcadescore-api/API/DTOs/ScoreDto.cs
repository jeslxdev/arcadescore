namespace arcadescore_api.API.DTOs;

public class ScoreDto
{
    public int Id { get; set; } // Id retornado nas consultas
    public required string Player { get; set; }
    public int Points { get; set; }
    public DateTime Date { get; set; }
}
