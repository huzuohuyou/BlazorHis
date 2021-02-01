using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BlazorHis.ServiceRecords
{
    public class QuestionsAppService :
        CrudAppService<
            Questions,
            QuestionsDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateQuestionsDto>,
        IQuestionsAppService
    {
        public QuestionsAppService(IRepository<Questions, Guid> repository)
            : base(repository)
        {

        }
    }
}
