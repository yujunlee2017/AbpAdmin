using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAdmin.System
{
    public class DictDetail : FullAuditedAggregateRoot<Guid>
    {
        public string DictType { get; set; }
        public int? DictSort { get; set; }
        public int? DictKey { get; set; }
        /// <summary>
        /// 字典值
        /// </summary>
        /// <returns></returns>
        public string DictValue { get; set; }
        public string ListClass { get; set; }
        public int? DictStatus { get; set; }
        public int? IsDefault { get; set; }
        public string Remark { get; set; }
    }
}
