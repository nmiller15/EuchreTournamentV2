namespace Euchre.Models.Interfaces;

public interface ITable
{
    public int RoundNumber { get; set; }
    public Guid TeamOneId { get; set; }
    public Guid TeamTwoId { get; set; }
}