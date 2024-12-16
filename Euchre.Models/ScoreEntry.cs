using Euchre.Models.Interfaces;

namespace Euchre.Models;

public class ScoreEntry : BaseModel, IScoreEntry
{
    public int RoundNumber { get; set; }
    public string RoomCode { get; set; }
    public Guid PlayerId { get; set; }
    
    public int Points { get; set; }
    public int Loners { get; set; }
}