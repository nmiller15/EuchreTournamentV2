using Euchre.Models.Interfaces;

namespace Euchre.Models;

public class Round : BaseModel, IRound
{
    public int RoundNumber { get; set; }
    public List<ITable> Tables { get; set; }
    public bool IsComplete { get; set; } = false;
    
    public Round() { }

    public Round(int roundNumber, List<ITable> tables)
    {
        RoundNumber = roundNumber;
        Tables = tables;
    }
}