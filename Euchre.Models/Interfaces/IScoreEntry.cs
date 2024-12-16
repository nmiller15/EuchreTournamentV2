namespace Euchre.Models.Interfaces;

public interface IScoreEntry
{
    public int RoundNumber { get; set; }
    public string RoomCode { get; set; }
    public Guid PlayerId { get; set; }
    
    public int Points { get; set; }
    public int Loners { get; set; }
}