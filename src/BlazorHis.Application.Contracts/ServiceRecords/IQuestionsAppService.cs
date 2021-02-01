using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BlazorHis.ServiceRecords
{
    public interface IQuestionsAppService :
        ICrudAppService< 
            QuestionsDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateQuestionsDto> 
    {
    }
}


