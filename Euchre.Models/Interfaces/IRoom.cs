namespace Euchre.Models.Interfaces;

public interface IRoom
{
    public string RoomCode { get; set; }
    public int CurrentRound { get; set; }
    public Dictionary<Guid, User> Users { get; set; }
    public Dictionary<string, Result> Results { get; set; }
    public Room.RoomStatus Status { get; set; }
    
}