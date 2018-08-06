using System.ComponentModel.DataAnnotations;

namespace Report.Fields.Ref
{
    public enum FilterTypeEnum
    {
        None,

        [Display(Name = "Equal To")]
        EqualTo,

        [Display(Name = "Not Equal To")]
        NotEqualTo,

        [Display(Name = "Greater Than Or Equal To")]
        GreaterThanOrEqualTo,

        [Display(Name = "Less Than Or Equal To")]
        LessThanOrEqualTo,

        [Display(Name = "Greater Than")]
        GreaterThan,

        [Display(Name = "Less Than")]
        LessThan,

        [Display(Name = "Starts With")]
        StartsWith,

        [Display(Name = "Ends With")]
        EndsWith,

        Contains,

        [Display(Name = "Blank")]
        Blank,

        [Display(Name = "Not Blank")]
        NotBlank,

        Yes,

        No,
        //IncludingFromIncludingTo = 100,
        //ExcludingFromIncludingTo,
        //IncludingFromExcludingTo,
        //ExcludingFromExcludingTo
    }

    public enum BoolFilterTypeEnum
    {
        None,
        Yes,
        No
    }

    public enum DateTimeFilterTypeEnum
    {
        None,
        Blank,
        NotBlank,
        EqualTo,
        NotEqualTo,
        GreaterThan,
        LessThan,
        GreaterThanOrEqualTo,
        LessThanOrEqualTo
    }

    public enum StringFilterTypeEnum
    {
        None,
        Blank,
        NotBlank,
        EqualTo,
        NotEqualTo,               
        StartsWith,
        EndsWith,
        Contains
    }


    public enum NumberFilterTypeEnum
    {
        None,
        NotEqualTo,
        GreaterThan,
        LessThan,
        GreaterThanOrEqualTo,
        LessThanOrEqualTo       
    }

}
