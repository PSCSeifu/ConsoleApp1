namespace Report.Fields.Ref
{
    public enum DataDisplayModeEnum
    {
        None = 0,

        /*Decimal/Double*/
        DecimalPlaces = 100,
        VariablesDecimalPlaces = 101,
        Cash = 102, //2 dp
        Rate = 103,// 4 dp
        Percentage = 104,//3  dp
        
        /*String*/
        Text = 200,
        Memo = 201,
        SortCode = 202, 
        LeadingZeros = 203,

        /*Date Time*/
        dd_MMM_yyyy = 300,
        dd_MMM_yyyy_hh_mm_ss= 301,

        /*Boolean*/
        ToYesNo = 400,
        ToYesNoEmpty = 401,
        ToYesDash = 402,
        ToOneZero = 403,

    }
}
