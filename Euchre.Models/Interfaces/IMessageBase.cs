namespace Euchre.Models.Interfaces;

public interface IMessageBase
{
    public string Type { get; set; }
    public string RoomCode { get; set; }
    public string Description { get; set; }
    public MessageBase.MessageSender Sender { get; set; }
    
}