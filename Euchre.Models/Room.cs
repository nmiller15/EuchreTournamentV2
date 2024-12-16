using Euchre.Models.Interfaces;

namespace Euchre.Models;

public class Room : BaseModel, IRoom
{
    public string RoomCode { get; set; }
    public RoomStatus Status { get; set; }
    public Round CurrentRound { get; set; }
    public Dictionary<Guid, User> Users { get; set; }
    public Dictionary<string, Result> Results { get; set; } = new Dictionary<string, Result>();
    
    
    public enum RoomStatus
    {
        Lobby,
        ReadyToStart,
        Playing,
        WaitingForResults,
        Results
    }

    public Room(User hostUser)
    {
        RoomCode = GenerateRoomCode();
        Users = new Dictionary<Guid, User>();
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