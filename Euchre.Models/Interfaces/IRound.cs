namespace Euchre.Models.Interfaces;

public interface IRound
{
    public int RoundNumber { get; set; }
    public List<Table> Tables { get; set; }
    public bool IsComplete { get; set; }
    
}