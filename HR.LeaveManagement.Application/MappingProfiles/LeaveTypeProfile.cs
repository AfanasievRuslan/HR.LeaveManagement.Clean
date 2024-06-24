﻿using AutoMapper;
using HR.LeaveManagement.Application.Features.Commands.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Clean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.MappingProfiles
{
     public class LeaveTypeProfile : Profile
     {
          public LeaveTypeProfile() { 
          CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();     
          }
     }
}