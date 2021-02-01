using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BlazorHis.ServiceRecords
{
    public class QuestionsDto : AuditedEntityDto<Guid>
    {
       public DateTime Date { get; set; }
public String Phone { get; set; }
public String Dept { get; set; }
public String User { get; set; }
public String Ptno { get; set; }
public KINDS Kind { get; set; }
public ROLES Role { get; set; }
public TYPES Type { get; set; }
public String Question { get; set; }
public String Reason { get; set; }
public String Answer { get; set; }
public String Images { get; set; }
public String[] ImageArray { get; set; }

    }
}

