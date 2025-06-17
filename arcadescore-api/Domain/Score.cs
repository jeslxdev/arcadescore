namespace arcadescore_api.Domain;

public class Score
{
    // Id auto-incremento
    public int Id { get; set; }
    public required string Player { get; set; }
    public int Points { get; set; }
    public DateTime Date { get; set; }
}