using HR.LeaveManagement.Clean;
using HR.LeaveManagement.Clean.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Clean
{
     public class LeaveType : BaseEntity
     {
          public int Id { get; set; }
          public string Name { get; set; } = string.Empty;
          public int DefaultDays { get; set; }

     }
}
