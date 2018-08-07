using System;

namespace Report.Fields.Model
{
    public class PaymentDDM 
    {
        public int Id { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }

        public double? BasicSalary { get; set; }
        public double? SalarySupplement { get; set; }
        public double? HourlyRate { get; set; }
        public double? OvertimeRate { get; set; }
        public double? PayPeriods { get; set; }
        public double? ContractedHours { get; set; }
        public int? DaysWorked { get; set; }
        public int? AllowOvertime { get; set; }
        public double? AnnualPay { get; set; }
        public double? PayPerPeriod { get; set; }
        public double? MonthlyPay { get; set; }
        public double? WeeklyPay { get; set; }
        public double? FullTimeEquivalent { get; set; }
        public double? FullTimeSalary { get; set; }
        public int? Type { get; set; }
        public string Grade { get; set; }
        public double? SpinalPoint { get; set; }
        public int? EmployeeId { get; set; }

        public string LastModifiedUser { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
