using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAdmin.Organization
{
    public class UserBelong : FullAuditedAggregateRoot<Guid>
    {
        public long? UserId { get; set; }
        public long? BelongId { get; set; }
        public int? BelongType { get; set; }

        /// <summary>
        /// 多个用户Id
        /// </summary>
        [NotMapped]
        public string UserIds { get; set; }
    }
}
