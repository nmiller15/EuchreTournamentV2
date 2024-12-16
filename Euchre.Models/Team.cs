namespace Euchre.Models.Interfaces;

public class Team : BaseModel, ITeam 
{
    public int RoundNumber { get; set; }
    public Guid PlayerOneId { get; set; }
    public Guid PlayerTwoId { get; set; }
}