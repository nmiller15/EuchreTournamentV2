using Euchre.Models.Interfaces;

namespace Euchre.Models;

public class Message<T> : MessageBase, IMessage<T>
{
    public T? Payload { get; set; }
    
    public Message() { }

    public Message(T payload)
    {
        Payload = payload;
    }
    
}