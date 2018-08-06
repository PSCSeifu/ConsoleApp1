using Report.Fields.Ref;
using System;
using System.Collections.Generic;

namespace Report.Fields
{
    public class EmployeeFields
    {
        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> EmployeePlainFields()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();
            list.Add(RetirementDate());
            list.Add(LastModifiedDate()); 
            return list;
        }

        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> EmployeeLinkedFields()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();

            list.Add(Gender());
            list.Add(PayBasis());
            list.Add(PayMethod());
            list.Add(PayrollStatus());
            list.Add(PayrollType());
            list.Add(TaxBasis());
            list.Add(FullPartTime());
            list.Add(NILetter());
            list.Add(MaritalStatus());

            return list;
        }
               
        #region Plain

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> RetirementDate()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Employee's Retirement Date";
            string fparams = $"employee:retirementdate:RetirementDate:State Pension Date:{desc}:Employee:Employee:NullableDateTime:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy,
                DecimalPlaces = 0,
                MaxColumnLength = 12,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> LastModifiedDate()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "The date Time value when the re cord was last modified";
            string fparams = $"employee:lastmodifieddate:LastModifiedDate:Last Modified On:{desc}:Employee:Employee:NullableDateTime:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy_hh_mm_ss,
                DecimalPlaces = 0,
                MaxColumnLength = 22,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Address1()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "";
            string fparams = $"employee:address1:Address1:Address 1:{desc}:Employee:Employee:String:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 50,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Address2()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "";
            string fparams = $"employee:address2:Address2:Address 2:{desc}:Employee:Employee:String:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 50,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Address3()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "";
            string fparams = $"employee:address3:Address3:Address 3:{desc}:Employee:Employee:String:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 50,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Address4()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "";
            string fparams = $"employee:address4:Address4:Address 4:{desc}:Employee:Employee:String:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Address5()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "";
            string fparams = $"employee:address5:Address5:Post Code:{desc}:Employee:Employee:String:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 10,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ApprenticeshipEndDate()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Employee's Apprentice End Date";
            string fparams = $"employee:apprenticeshipenddate:ApprenticeshipEndDate:Apprentice End Date:{desc}:Employee:Employee:NullableDateTime:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy,
                DecimalPlaces = 0,
                MaxColumnLength = 12,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ApprenticeshipStartDate()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Employee's Apprentice End Date";
            string fparams = $"employee:apprenticeshipstartdate:ApprenticeshipStartDate:Apprentice Start Date:{desc}:Employee:Employee:NullableDateTime:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy,
                DecimalPlaces = 0,
                MaxColumnLength = 12,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ClockNo()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "";
            string fparams = $"employee:clockno:ClockNo:Clock No:{desc}:Employee:Employee:String:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 10,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> CompanyJoinDate()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Employee's Apprentice End Date";
            string fparams = $"employee:CompanyJoinDate:CompanyJoinDate:CompanyJoinDate:{desc}:Employee:Employee:NullableDateTime:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy,
                DecimalPlaces = 0,
                MaxColumnLength = 12,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }



        #endregion

        #region Enum Linked

        //TODO: SourceLinkFieldName, TargetLinkFieldName, TargetFieldName- these are  magic strings, need a central place to fetch these values.

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Gender()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Employee's Gender Linked to the Gender Enumeration";
            string fparams = $"employee:gender:gender:Gender:{desc}:Employee:Employee:String:Linked:Init";

            LinkedInput linkedInput = new LinkedInput()
            {
                SourceDataModelType = DataModelTypeEnum.Employee,
                SourceFieldType = FieldTypeEnum.Employee,

                SourceLinkFieldName = "Gender",
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetLinkFieldName = "gender",
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Enum,
                TargetFieldName = "gender",

                TargetFieldType = FieldTypeEnum.None,
                TargetPrimitiveType = PrimitiveTypeEnum.String

            };

            string linkedDTO = LinkedInput.MapToDTO(linkedInput);

            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 10,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", linkedDTO, foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> PayBasis()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Employee's PayBasis Description Linked to the PayBasis Enumeration";
            string fparams = $"employee:paybasis:paybasis:Pay Basis:{desc}:Employee:Employee:String:Linked:Init";


            string linkedDTO = LinkedInput.MapToDTO(new LinkedInput()
            {
                SourceDataModelType = DataModelTypeEnum.Employee,
                SourceFieldType = FieldTypeEnum.Employee,

                SourceLinkFieldName = "PayBasis",
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetLinkFieldName = "paybasis",
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Enum,
                TargetFieldName = "paybasis",

                TargetFieldType = FieldTypeEnum.None,
                TargetPrimitiveType = PrimitiveTypeEnum.String
            });

            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 30,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", linkedDTO, foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> PayMethod()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Employee's Pay Method Description Linked to the PayMethod Enumeration";
            string fparams = $"employee:paymethod:paymethod:Pay Method:{desc}:Employee:Employee:String:Linked:Init";


            string linkedDTO = LinkedInput.MapToDTO(new LinkedInput()
            {
                SourceDataModelType = DataModelTypeEnum.Employee,
                SourceFieldType = FieldTypeEnum.Employee,

                SourceLinkFieldName = "PayMethod",
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetLinkFieldName = "paymethod",
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Enum,
                TargetFieldName = "paymethod",

                TargetFieldType = FieldTypeEnum.None,
                TargetPrimitiveType = PrimitiveTypeEnum.String
            });

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 30,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", linkedDTO, foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> PayrollStatus()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            var desc = "Employee's Payroll Status Description Linked to the PayrollStatus Enumeration";
            string fparams = $"employee:payrollstatus:payrollstatus:Payroll Status:{desc}:Employee:Employee:String:Linked:Init";


            string linkedDTO = LinkedInput.MapToDTO(new LinkedInput()
            {
                SourceDataModelType = DataModelTypeEnum.Employee,
                SourceFieldType = FieldTypeEnum.Employee,

                SourceLinkFieldName = "PayrollStatus",
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetLinkFieldName = "payrollstatus",
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Enum,
                TargetFieldName = "payrollstatus",

                TargetFieldType = FieldTypeEnum.None,
                TargetPrimitiveType = PrimitiveTypeEnum.String
            });

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 30,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", linkedDTO, foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> PayrollType()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            var desc = "Employee's Payroll Type  Description Linked to the PayrollType Enumeration";
            string fparams = $"employee:payrolltype:payrolltype:Pay Frequency:{desc}:Employee:Employee:String:Linked:Init";


            string linkedDTO = LinkedInput.MapToDTO(new LinkedInput()
            {
                SourceDataModelType = DataModelTypeEnum.Employee,
                SourceFieldType = FieldTypeEnum.Employee,

                SourceLinkFieldName = "PayrollType",
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetLinkFieldName = "payrolltype",
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Enum,
                TargetFieldName = "payrolltype",

                TargetFieldType = FieldTypeEnum.None,
                TargetPrimitiveType = PrimitiveTypeEnum.String
            });

            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 30,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", linkedDTO, foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> TaxBasis()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            var desc = "Employee's Tax Basis Description Linked to the TaxBasis Enumeration";
            string fparams = $"employee:taxbasis:taxbasis:Tax Basis:{desc}:Employee:Employee:String:Linked:Init";


            string linkedDTO = LinkedInput.MapToDTO(new LinkedInput()
            {
                SourceDataModelType = DataModelTypeEnum.Employee,
                SourceFieldType = FieldTypeEnum.Employee,

                SourceLinkFieldName = "TaxBasis",
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetLinkFieldName = "taxbasis",
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Enum,
                TargetFieldName = "taxbasis",

                TargetFieldType = FieldTypeEnum.None,
                TargetPrimitiveType = PrimitiveTypeEnum.String
            });

            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 30,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", linkedDTO, foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> NILetter()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            var desc = "Employee's NI alphabet Letter ( Character) Linked to the NILetter Enumeration";
            string fparams = $"employee:niletter:niletter:NI Letter:{desc}:Employee:Employee:String:Linked:Init";

            string linkedDTO = LinkedInput.MapToDTO(new LinkedInput()
            {
                SourceDataModelType = DataModelTypeEnum.Employee,
                SourceFieldType = FieldTypeEnum.Employee,

                SourceLinkFieldName = "NILetter",
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetLinkFieldName = "niletter",
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Enum,
                TargetFieldName = "niletter",

                TargetFieldType = FieldTypeEnum.None,
                TargetPrimitiveType = PrimitiveTypeEnum.String
            });

            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 1,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", linkedDTO, foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> MaritalStatus()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            var desc = "Employee's Marital Status Description Linked to the MaritalStatus Enumeration";
            string fparams = $"employee:martialstatus:martialstatus:Martial Status:{desc}:Employee:Employee:String:Linked:Init";

            string linkedDTO = LinkedInput.MapToDTO(new LinkedInput()
            {
                SourceDataModelType = DataModelTypeEnum.Employee,
                SourceFieldType = FieldTypeEnum.Employee,

                SourceLinkFieldName = "MartialStatus",
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetLinkFieldName = "martialstatus",
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Enum,
                TargetFieldName = "martialstatus",

                TargetFieldType = FieldTypeEnum.None,
                TargetPrimitiveType = PrimitiveTypeEnum.String
            });


            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 15,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", linkedDTO, foptions, new FieldPermissions());
        }

        private static Tuple<string, string, string, FieldOptions, FieldPermissions> FullPartTime()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            var desc = "Employee's Full / PartTime Description Linked to the FullPartTime Enumeration";
            string fparams = $"employee:fullparttime:fullparttime:Full/Part Time:{desc}:Employee:Employee:String:Linked:Init";

            string linkedDTO = LinkedInput.MapToDTO(new LinkedInput()
            {
                SourceDataModelType = DataModelTypeEnum.Employee,
                SourceFieldType = FieldTypeEnum.Employee,

                SourceLinkFieldName = "FullPartTime",
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetLinkFieldName = "fullparttime",
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Enum,
                TargetFieldName = "fullparttime",

                TargetFieldType = FieldTypeEnum.None,
                TargetPrimitiveType = PrimitiveTypeEnum.String
            });


            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 15,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", linkedDTO, foptions, new FieldPermissions());
        }

        #endregion
                
    }
}
