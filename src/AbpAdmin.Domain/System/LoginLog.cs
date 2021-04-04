using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAdmin.System
{
    public class LoginLog : FullAuditedAggregateRoot<Guid>
    {
        public int? LogStatus { get; set; }
        public string IpAddress { get; set; }
        public string IpLocation { get; set; }
        public string Browser { get; set; }
        public string OS { get; set; }
        public string Remark { get; set; }
        public string ExtraRemark { get; set; }

        [NotMapped]
        public string UserName { get; set; }
    }
}
