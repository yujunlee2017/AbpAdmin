using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAdmin.System
{
    public class Role : FullAuditedAggregateRoot<Guid>
    {
        public string RoleName { get; set; }
        public int? RoleSort { get; set; }
        public int? RoleStatus { get; set; }
        public string Remark { get; set; }

        /// 角色对应的菜单，页面和按钮
        /// </summary>
        [NotMapped]
        public string MenuIds { get; set; }
    }
}
