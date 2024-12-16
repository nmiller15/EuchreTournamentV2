namespace Euchre.Models.Interfaces;

public interface ISchedule
{
    public string RoomCode { get; set; }
    public int NumberOfRounds { get; set; }
    public List<IRound> Rounds { get; set; }
}