using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAdmin.System
{
    public class Dict : FullAuditedAggregateRoot<Guid>
    {
        public string Type { get; set; }
        public int? Sort { get; set; }
        public string Remark { get; set; }
    }
}
