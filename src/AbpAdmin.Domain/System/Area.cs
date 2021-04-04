using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAdmin.System
{
    public class Area : FullAuditedAggregateRoot<Guid>
    {
        public string AreaCode { get; set; }
        public string ParentAreaCode { get; set; }
        public string AreaName { get; set; }
        public string ZipCode { get; set; }
        public int? AreaLevel { get; set; }
    }
}
