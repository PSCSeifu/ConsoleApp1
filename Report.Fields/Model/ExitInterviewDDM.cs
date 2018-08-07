using System;

namespace Report.Fields.Model
{
    public class ExitInterviewDDM 
    {
        public int Id { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string InterviewBy { get; set; }
        public int? LeavingReasonId { get; set; }
        public string Notes { get; set; }
        public int? EmployeeId { get; set; }
        public bool? ReEmploy { get; set; }
        public string ReEmployBy { get; set; }
        public bool? ReferenceGiven { get; set; }

        public string LastModifiedUser { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
