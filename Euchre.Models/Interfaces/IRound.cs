namespace Euchre.Models.Interfaces;

public interface IRound
{
    public int RoundNumber { get; set; }
    public List<ITable> Tables { get; set; }
    public bool IsComplete { get; set; }
    
}