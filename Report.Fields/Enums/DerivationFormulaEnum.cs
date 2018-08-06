namespace ms.eReport.Domain
{
    public enum DerivationFormulaEnum
    {
        None,
        HumanAgeYears,
        HumanAgeYearsMonths,  
        
        NextBirthday,       
        MonthBorn,

        MonthJoined,
        AnniversaryOfPayrollJoinDate,

        LengthOfService,
        LengthOfTotalService,


        /*
         * [Join Date]          = Payroll join date, can not be null in Database.
         * [Company Join Date]  = Company/Organisation join date, can be null in Database.
         
         Length Of Service          - based on [Join Date] & [LeavingDate] or ReportEffectiveDate]
         Length of Total Service    - based on [Company Join Date] & [LeavingDate] or ReportEffectiveDate]
        */
    }
}
