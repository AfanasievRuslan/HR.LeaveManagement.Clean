using HR.LeaveManagement.Clean.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR.LeaveManagement.Clean
{
     public class LeaveRequest : BaseEntity
     {
          public int Id { get; set; }
          public DateTime StartDate { get; set; }
          public DateTime EndDate { get; set; }
          [ForeignKey("LeaveType")]
          public LeaveType LeaveType { get; set; }
          public int LeaveTypeId { get; set; }
          public DateTime DateRequest { get; set; }
          public String RequestComments { get; set; } = string.Empty;
          public bool Approved { get; set; }
          public bool Cancelled { get; set; }
          public string RequestingEmployeeId { get; set; } = string.Empty;
     }
}
