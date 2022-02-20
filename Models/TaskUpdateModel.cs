using System.ComponentModel;
namespace WEB_API_DAY1.Models;
public class TaskUpdateModel : TaskCreateModel
{
    [DefaultValue(0)]
    public bool Completed {get;set;}
    
}