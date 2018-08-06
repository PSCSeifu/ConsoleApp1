namespace Report.Fields.Ref
{
    public enum FieldTypeEnum
    {
        None,
        Employee = 100,
        EmployeeSubrecord = 200,
        Organisation = 300,
        Picklist = 400,
        Derived = 500,

        DataCode = 600,
        Adjustment = 700,
        Formula = 900
    }
}