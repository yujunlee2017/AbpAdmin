using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAdmin.Organization
{
    public class Position : FullAuditedAggregateRoot<Guid>
    {
        public string PositionName { get; set; }
        public int? PositionSort { get; set; }
        public int? PositionStatus { get; set; }
        public string Remark { get; set; }
    }
}
