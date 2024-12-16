namespace Euchre.Models.Interfaces;

public interface ITeam
{
    public int RoundNumber { get; set; }
    public Guid PlayerOneId { get; set; }
    public Guid PlayerTwoId { get; set; }
}