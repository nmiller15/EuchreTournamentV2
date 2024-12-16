using Euchre.Models.Interfaces;

namespace Euchre.Models;

public class Room : BaseModel, IRoom
{
    public string RoomCode { get; set; }
    public RoomStatus Status { get; set; }
    public IRound? CurrentRound { get; set; }
    public Dictionary<Guid, IUser> Users { get; set; } = new Dictionary<Guid, IUser>();
    public Dictionary<string, IResult> Results { get; set; } = new Dictionary<string, IResult>();
    public List<ScoreEntry> ScoreEntries = [];
    
    
    public enum RoomStatus
    {
        Lobby,
        ReadyToStart,
        Playing,
        WaitingForResults,
        Results
    }

    public Room()
    {
        RoomCode = GenerateRoomCode();
    }

    public Room(User hostUser)
    {
        RoomCode = GenerateRoomCode();
        Users.Add(hostUser.Id, hostUser);
    }
    
    private string GenerateRoomCode()
    {
        // Random random = new Random();
        // string code = "";
        // for (int i = 0; i < 4; i++)
        // {
        //     int randomNumber = random.Next(0, 26);
        //     char randomAlpha = (char)('A' + randomNumber);
        //
        //     code = $"{code}{randomAlpha}";
        // }
        // return code;
        // For Dev:
        return "ABCD";
    }
}