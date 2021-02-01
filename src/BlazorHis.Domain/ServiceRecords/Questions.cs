using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BlazorHis.ServiceRecords
{
    public class Questions : AuditedAggregateRoot<Guid>
    {
        public DateTime Date { get; set; }

        public string Phone { get; set; }

        public string Dept { get; set; }

        public string User { get; set; }

        public string Ptno { get; set; }

        public KINDS Kind { get; set; }

        public ROLES Role { get; set; }

        public TYPES Type { get; set; }

        public string Question { get; set; }

        public string Reason { get; set; }

        public string Answer { get; set; }

        public string Images { get; set; }
        public string[] ImageArray
        {
            get
            {
                var list = new List<string>();
                if (Images != null)
                {
                    foreach (var item in Images.Split('|'))
                    {
                        if (!item.Equals(string.Empty))
                        {
                            list.Add($@"{item}");
                        }
                    }

                    return list.ToArray();
                }
                return new string[] { };
            }
        }
    }
}
