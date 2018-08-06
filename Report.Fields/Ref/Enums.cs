using System.ComponentModel.DataAnnotations;

namespace Report.Fields.Ref
{
    /* Any changes to this enum must be applied to the corresponding enum in eServices.Business/Common/Enums */
    public enum GenderEnum
    {
        [Display(Name = "-")]
        None,
        Male,
        Female
    }

    /* Any changes to this enum must be applied to the corresponding enum in eServices.Business/Common/Enums */
    public enum PayBasisEnum
    {
        [Display(Name = "-")]
        None,
        Salary,
        Hourly,
        Commission,
        [Display(Name = "Salary - AutoWage")]
        SalaryAutowage,
        Other
    }

    /* Any changes to this enum must be applied to the corresponding enum in eServices.Business/Common/Enums */
    public enum PayMethodEnum
    {
        [Display(Name = "-")]
        None,
        BACS,
        Cash,
        Cheque,
        Transfer
    }

    /* Any changes to this enum must be applied to the corresponding enum in eServices.Business/Common/Enums */
    public enum PayrollStatusEnum
    {
        Active,
        [Display(Name = "Left With Pay")]
        LeftWithPay,
        [Display(Name = "Left Without Pay")]
        LeftWithoutPay,
        Suspended
    }

    /* Any changes to this enum must be applied to the corresponding enum in eServices.Business/Common/Enums */
    public enum PayFrequencyEnum
    {
        [Display(Name = "-")]
        None,
        Monthly,
        Weekly,
        Fortnightly,
        Lunar,
        Quarterly,
        Annual
    }

    /* Any changes to this enum must be applied to the corresponding enum in eServices.Business/Common/Enums */
    public enum TaxBasisEnum
    {
        [Display(Name = "-")]
        None,
        [Display(Name = "")]
        Cumulative,
        [Display(Name = "W1/M1")]
        Month1Week1
    }

    /* Any changes to this enum must be applied to the corresponding enum in eServices.Business/Common/Enums */
    public enum NILetterEnum
    {
        [Display(Name = "-")]
        None = 0,
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        F = 6,
        G = 7,
        S = 8,
        J = 9,
        L = 10,
        X = 11,
        M = 12,
        Z = 13,
        I = 14,
        K = 15
    }

    /* Any changes to this enum must be applied to the corresponding enum in eServices.Business/Common/Enums */
    public enum MaritalStatusEnum
    {
        [Display(Name = "-")]
        None,
        Single,
        Married,
        Divorced,
        Separated,
        Widowed,
        Relationship
    }

    /* Any changes to this enum must be applied to the corresponding enum in eServices.Business/Common/Enums */
    public enum FullPartTimeEnum
    {
        [Display(Name = "-")]
        None,
        [Display(Name = "Full Time")]
        FullTime,
        [Display(Name = "Part Time")]
        PartTime
    }

}
