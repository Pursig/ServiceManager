namespace ServiceManager.Models;

public class VerList
{
    public Guid Id { get; set; }
    public string VerName { get; set; } = string.Empty;
    public bool IsActual {get; set;}
    public DateTime CreatedDate {get; set;} = DateTime.Now;
}