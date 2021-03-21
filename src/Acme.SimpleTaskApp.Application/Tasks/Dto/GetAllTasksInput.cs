using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Tasks.Dto
{
    public class GetAllTasksInput
    {
        public TaskState? State { get; set; }
    }
   
}
