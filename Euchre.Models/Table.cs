using Euchre.Models.Interfaces;

namespace Euchre.Models;

public class Table : BaseModel, ITable
{
    public int RoundNumber { get; set; }
    public Guid TeamOneId { get; set; }
    public Guid TeamTwoId { get; set; }
    
    Table() { }

    Table(int roundNumber, Guid teamOneId, Guid teamTwoId)
    {
        RoundNumber = roundNumber;
        TeamOneId = teamOneId;
        TeamTwoId = teamTwoId;
    }
}