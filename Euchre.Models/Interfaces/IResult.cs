namespace Euchre.Models.Interfaces;

public interface IResult 
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public int Value { get; set; }
}