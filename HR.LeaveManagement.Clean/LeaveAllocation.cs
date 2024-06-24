using HR.LeaveManagement.Clean.Common;

namespace HR.LeaveManagement.Clean
{
     public class LeaveAllocation : BaseEntity
     {
          public int Id { get; set; }
          public int NomberOfDays { get; set; }
          public LeaveType LeaveType { get; set; }
          public int LeaveTypeId { get; set; }
          public int Period { get; set; }
     }
}
