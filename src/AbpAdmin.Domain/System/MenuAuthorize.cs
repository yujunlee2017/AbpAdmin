using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAdmin.System
{
    public class MenuAuthorize : FullAuditedAggregateRoot<Guid>
    {
        public long? MenuId { get; set; }

        public long? AuthorizeId { get; set; }

        public int? AuthorizeType { get; set; }

        public string AuthorizeIds { get; set; }
    }
}
