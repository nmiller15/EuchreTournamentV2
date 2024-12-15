namespace Euchre.Models;

public abstract class BaseModel
{
    public Guid Id { get; set; }

    public BaseModel()
    {
        Id = Guid.NewGuid();
    }
}