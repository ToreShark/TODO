using System.ComponentModel.DataAnnotations;

namespace To_Do_list.Models;

[DisplayColumn("Tasks")]
public class TaskEntity
{
    [Key] 
    public int Id { get; set; }

    [Display(Name = "Task Name")]
    [Required]
    public string Name { get; set; }

    [Display(Name = "Task Priority")]
    [Required]
    public string Priority { get; set; }

    [Display(Name = "Status")] [Required] public string Status { get; set; }
    [Display(Name = "Action")] [Required] public string Action { get; set; }
}