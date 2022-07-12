using System;

namespace GridTest.Models
{
    [Serializable]
    public class SecurityGroupProcedureDto 
    {
        public Guid? TenantId { get; set; }
        public Guid SecurityGroupId { get; set; }
        public Guid ProcedureId { get; set; }
        public bool? Status { get; set; }
    }
}