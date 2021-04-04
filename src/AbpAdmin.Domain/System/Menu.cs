using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAdmin.System
{
    public class Menu : FullAuditedAggregateRoot<Guid>
    {
        public long? ParentId { get; set; }

        public string Name { get; set; }

        public string Icon { get; set; }

        public string Url { get; set; }

        public string Target { get; set; }

        public int? Sort { get; set; }

        public int? Type { get; set; }

        public int? Status { get; set; }
        public string Authorize { get; set; }

        public string Remark { get; set; }

        [NotMapped]
        public string ParentName { get; set; }
    }
}
