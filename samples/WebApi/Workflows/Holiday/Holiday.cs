using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tomware.Microwf.Engine;
using WebApi.Workflows.Holiday;

namespace WebApi.Workflows.Holiday
{
  [Table("Holiday")]
  public partial class Holiday : IEntityWorkflow
  {
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Type { get; set; }

    [Required]
    public string State { get; set; }

    [Required]
    public string Assignee { get; set; }

    [Required]
    public string Requester { get; set; }

    public string Superior { get; set; }

    public DateTime? From { get; set; }

    public DateTime? To { get; set; }

    public static Holiday Create(string requester)
    {
      return new Holiday
      {
        Type = HolidayApprovalWorkflow.TYPE,
        State = HolidayApprovalWorkflow.NEW_STATE,
        Assignee = requester,
        Requester = requester
      };
    }
  }
}
