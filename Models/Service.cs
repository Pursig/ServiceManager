namespace ServiceManager.Models;

public class Service
{
    public Guid Id { get; set; }
    public string SeviceName { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public string Description { get; set; } = string.Empty;
    
    
    public List<VerList> VerLists { get; set; } = new List<VerList>();
}