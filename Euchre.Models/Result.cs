using Euchre.Models.Interfaces;

namespace Euchre.Models;

public class Result : BaseModel, IResult
{
    public Guid UserId { get; set; }
    public string Name { get; set; } = String.Empty;
    public int Value { get; set; } = 0;
    
    public Result() { }

    public Result(Guid userId, string name, int value)
    {
        UserId = userId;
        Name = name;
        Value = value;
    }
}