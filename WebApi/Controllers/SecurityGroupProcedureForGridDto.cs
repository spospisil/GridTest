using System;

namespace WebApi.Models
{
    [Serializable]
    public class SecurityGroupProcedureForGridDto
    {
        public Guid? TenantId { get; set; }
        public Guid? SecurityGroupId { get; set; }
        public Guid ProcedureId { get; set; }
        public string ShortDescription { get; set; }
        public bool? Status { get; set; }
    }
}