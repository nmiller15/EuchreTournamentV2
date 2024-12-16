namespace Euchre.Models.Interfaces;

public interface IRoom
{
    public string RoomCode { get; set; }
    public IRound? CurrentRound { get; set; }
    public Dictionary<Guid, IUser> Users { get; set; }
    public Dictionary<string, IResult> Results { get; set; }
    public Room.RoomStatus Status { get; set; }
    
}