using Euchre.Models.Interfaces;

namespace Euchre.Models;

public class User : BaseModel, IUser
{
    public string Username { get; set; } = String.Empty;
    public bool IsHost { get; set; } = false;
    public bool IsReady { get; set; } = false;
    public bool IsByeIndicator { get; set; } = true;
    
    public User() : base() { }

    public User(string username, bool isHost) : base()
    {
        Username = username;
        IsHost = isHost;
        IsByeIndicator = false;
    }
}