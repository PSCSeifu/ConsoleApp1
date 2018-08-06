namespace ms.eReport.Domain
{
    public enum DataModelTypeEnum
    {
        None,

        ReportQueryParam = 1,
        Enum = 2,

        Payroll = 11,
        Period = 12,

        Employee = 100,

        Absence = 201,
        AutoEnrolment = 202,
        CareerHistory = 203,
        ExitInterview = 204,
        Payment = 205,
        PersonContact = 206,
        TaxCodeData = 207,
        WorkPattern = 208,
        PayrollElement = 209,
        BankAccount = 210,


        Department = 301,
        Grade = 302,
        JobTitle = 303,
        Picklist = 304,
        Site = 305,
        BankRecord = 306,
        CostCode = 307,

        DataCode = 600,
        Balance = 601
    }
}