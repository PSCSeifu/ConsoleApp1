using System;

namespace Report.Fields.Model
{
    public class TaxCodeDataDDM
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int FormType { get; set; }

        public DateTime? LeavingDate { get; set; }
        public int? PeriodNumber { get; set; }
        public bool? IsStudentLoan { get; set; }
        public int? PayPeriod { get; set; }
        public string TaxCode { get; set; }
        public int? TaxBasis { get; set; }
        public double? TotalPay { get; set; }
        public double? TotalTax { get; set; }

        public bool? DeclarationA { get; set; }
        public bool? DeclarationB { get; set; }
        public bool? DeclarationC { get; set; }
        public bool? DeclarationD { get; set; }
        public bool? ExpatDeclarationA { get; set; }
        public bool? ExpatDeclarationB { get; set; }
        public bool? ExpatDeclarationC { get; set; }
        public bool? ModifiedScheme { get; set; }
        public bool? EEACitizen { get; set; }

        public bool? FinishedStudiesBeforeLast6April { get; set; }
        public bool? IsStudentLoanNotFullyRepaid { get; set; }
        public bool? IsStudentLoanPaidDirectToSLC { get; set; }
        public bool? StudentLoanPlan1 { get; set; }
        public bool? StudentLoanPlan2 { get; set; }
        public Double? AnnualOccupationalPension { get; set; }

        public string LastModifiedUser { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
