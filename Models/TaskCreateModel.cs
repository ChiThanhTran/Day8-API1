using System.ComponentModel.DataAnnotations;
namespace WEB_API_DAY1.Models;
public class TaskCreateModel 
{
    [Required, MaxLength(100)]
    public string? Title {get;set;}
    public string? Description {get;set;}
    
}