using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAdmin.Organization
{
    public class User : FullAuditedAggregateRoot<Guid>
    {
        [Description("用户名")]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        [Description("真实姓名")]
        public string RealName { get; set; }
        [Description("性别")]
        public int? Gender { get; set; }
        public string Birthday { get; set; }
        public string Portrait { get; set; }
        public string Email { get; set; }
        [Description("手机号")]
        public string Mobile { get; set; }
        public string QQ { get; set; }
        public string Wechat { get; set; }
        public int? LoginCount { get; set; }
        public int? UserStatus { get; set; }
        public int? IsSystem { get; set; }
        public int? IsOnline { get; set; }
        public DateTime? FirstVisit { get; set; }
        public DateTime? PreviousVisit { get; set; }
        public DateTime? LastVisit { get; set; }
        public string Remark { get; set; }
        public string WebToken { get; set; }
        public string ApiToken { get; set; }

        public long? DepartmentId { get; set; }

        [NotMapped]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 岗位Id
        /// </summary>
        [NotMapped]
        public string PositionIds { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        [NotMapped]
        public string RoleIds { get; set; }
    }
}
