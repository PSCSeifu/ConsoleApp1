using System;

namespace Report.Fields.Model
{
    public class PicklistDDM
    {
        public int Id { get; set; }
        public int OrganisationId { get; set; }
        public string Description { get; set; }
        public bool? InUse { get; set; }
        public int PicklistType { get; set; }
        public string LastModifiedUser { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
