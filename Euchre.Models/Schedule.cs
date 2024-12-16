using Euchre.Models.Interfaces;

namespace Euchre.Models;

public class Schedule : ISchedule
{
    public string? RoomCode { get; set; }
    public int NumberOfRounds { get; set; }
    public List<IRound> Rounds { get; set; } = new List<IRound>();
    
    public Schedule() { }
    
    public Schedule(string roomCode, int numberOfRounds, List<IRound> rounds)
    {
        RoomCode = roomCode;
        NumberOfRounds = numberOfRounds;
        Rounds = rounds;
    }
}