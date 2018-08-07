using System;

namespace Report.Fields.Model
{
    public class AbsenceDDM
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public double? Duration { get; set; }
        public double? OldDuration { get; set; }
        public int? AbsenceCategoryId { get; set; }
        public int? AbsenceReasonId { get; set; }
        public bool IsAnnualLeave { get; set; }
        public bool OldIsAnnualLeave { get; set; }
        public bool IsNextYearLeave { get; set; }
        public bool OldIsNextYearLeave { get; set; }
        public double? Cost { get; set; }
        public double? CostPercentage { get; set; }
        public double? CostValue { get; set; }
        public double? AdditionalCost { get; set; }
        public double? TotalCost { get; set; }
        public int? AbsenceCostId { get; set; }
        public bool PaidSsp { get; set; }
        public DateTime? MedicalDate1 { get; set; }
        public DateTime? MedicalDate2 { get; set; }
        public string Notes { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string Grade { get; set; }
        public string WorkPattern { get; set; }
        public int? SSPId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedUser { get; set; }
    }
}
