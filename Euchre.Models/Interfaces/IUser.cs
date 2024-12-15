namespace Euchre.Models.Interfaces;

public interface IUser
{
    public string Username { get; set; }
    public bool IsHost { get; set; }
    public bool IsReady { get; set; }
    public bool IsByeIndicator { get; set; }
}