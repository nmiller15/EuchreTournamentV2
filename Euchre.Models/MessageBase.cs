using Euchre.Models.Interfaces;

namespace Euchre.Models;

public class MessageBase : BaseModel, IMessageBase
{
    public string Type { get; set; } = String.Empty;
    public string RoomCode { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public Senders Sender { get; set; }
    public enum Senders
    {
        Server,
        Client
    }
    
    public MessageBase () { }

    public MessageBase(string type, string roomCode, string description)
    {
        Type = type;
        RoomCode = roomCode;
        Description = description;
    }
    
}