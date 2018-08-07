using System;

namespace Report.Fields.Model
{
    public class CareerHistoryDDM 
    {
        public int Id { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public string DepartmentChangedFrom { get; set; }
        public string SiteLocationChangedFrom { get; set; }
        public string JobTitleChangedFrom { get; set; }
        public string GradeChangedFrom { get; set; }
        public double? PayChangedFrom { get; set; }
        public int? Event { get; set; }
        public int? Reason { get; set; }
        public string DepartmentChangedTo { get; set; }
        public string SiteLocationChangedTo { get; set; }
        public string JobTitleChangedTo { get; set; }
        public string GradeChangedTo { get; set; }
        public double? PayChangedTo { get; set; }
        public string Notes { get; set; }
        public int EmployeeId { get; set; }

        public DateTime? LastModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifiedUser { get; set; }
    }
}
