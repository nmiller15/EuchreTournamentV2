namespace Euchre.Models.Interfaces;

public interface IMessage<T>
{
    public T Payload { get; set; }
    
}