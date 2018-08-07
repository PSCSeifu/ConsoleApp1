using Report.Fields.Model;
using Report.Fields.Ref;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Report.Fields
{
    public class AbsenceFields
    {
        /// <summary>
        /// Returns a List of Tuple parameters of  the Linked type  Absence Report Fields
        /// </summary>
        /// <returns></returns>
        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> AbsenceLinkedFields()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();
            list.Add(AbsenceCost());
            list.Add(AbsenceCategory());
            list.Add(AbsenceReason()); 
            return list;
        }

        /// <summary>
        /// Returns a List of Tuple parameters of  the palin type  Absence Report Fields
        /// </summary>
        /// <returns></returns>
        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> AbsencePlainFields()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();
            list.Add(CreatedDate());
            list.Add(LastModifiedDate());
            list.Add(LastModifiedUser());
            list.Add(Cost());
            list.Add(Cost2());
            list.Add(CostPercentage());
            list.Add(CostValue());
            list.Add(Department());
            list.Add(Duration());
            list.Add(FromDate());
            list.Add(Grade());
            list.Add(IsAnnualLeave());
            list.Add(IsNextYearLeave());
            list.Add(Location());
            list.Add(MedicalDate1());
            list.Add(MedicalDate2());
            list.Add(Notes());
            list.Add(PaidSsp());
            list.Add(ToDate());
            list.Add(TotalCost());
            list.Add(WorkPattern());
            return list;
        }

        #region Linked

        /// <summary>
        /// Create the Report Field parameters of the Absence table AbsenceCost Linked field. 
        /// When a report is produced, the Absence Cost Id is linked to the Picklist to fetch the Absence Cost description for the particular Organisation
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> AbsenceCost()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Employee's Absence Cost Description";
            string fparams = $"absence:absencecost:AbsenceCost:Cost Type:{desc}:EmployeeSubrecord:Absence:String:Linked:Init";

            Type absenceType = new CareerHistoryDDM().GetType();
            PropertyInfo absencePropertyInfo = absenceType.GetProperty("AbsenceCost");

            Type picklistType = new PicklistDDM().GetType();
            PropertyInfo picklistId = picklistType.GetProperty("Id");
            PropertyInfo picklistDescription = picklistType.GetProperty("Description");

            LinkedInput linkedInput = new LinkedInput()
            {
                SourceFieldType = FieldTypeEnum.EmployeeSubrecord,
                SourceDataModelType = DataModelTypeEnum.Absence,
                SourceLinkFieldName = absencePropertyInfo.Name,
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Picklist,
                TargetFieldType = FieldTypeEnum.Organisation,
                TargetLinkFieldName = picklistId.Name,
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,
                               
                TargetFieldName = picklistDescription.Name,               
                TargetPrimitiveType = PrimitiveTypeEnum.String
            };

            string linkedDTO = LinkedInput.MapToDTO(linkedInput);

            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", linkedDTO, foptions, new FieldPermissions());
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table AbsenceCategory Linked field. 
        /// When a report is produced, the Absence Category Id is linked to the Picklist to fetch the Absence Category description for the particular Organisation
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> AbsenceCategory()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Employee's Absence Category Description";
            string fparams = $"absence:absencecategory:AbsenceCategory:Category:{desc}:EmployeeSubrecord:Absence:String:Linked:Init";

            Type absenceType = new CareerHistoryDDM().GetType();
            PropertyInfo absencePropertyInfo = absenceType.GetProperty("AbsenceCategory");

            Type picklistType = new PicklistDDM().GetType();
            PropertyInfo picklistId = picklistType.GetProperty("Id");
            PropertyInfo picklistDescription = picklistType.GetProperty("Description");

            LinkedInput linkedInput = new LinkedInput()
            {
                SourceFieldType = FieldTypeEnum.EmployeeSubrecord,
                SourceDataModelType = DataModelTypeEnum.Absence,
                SourceLinkFieldName = absencePropertyInfo.Name,
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Picklist,
                TargetFieldType = FieldTypeEnum.Organisation,
                TargetLinkFieldName = picklistId.Name,
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetFieldName = picklistDescription.Name,
                TargetPrimitiveType = PrimitiveTypeEnum.String
            };

            string linkedDTO = LinkedInput.MapToDTO(linkedInput);

            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", linkedDTO, foptions, new FieldPermissions());
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table AbsenceReason Linked field. 
        /// When a report is produced, the Absence Reason Id is linked to the Picklist to fetch the Absence Category description for the particular Organisation 
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> AbsenceReason()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Employee's Absence Reason Description";
            string fparams = $"absence:absencereason:AbsenceReason:Reason:{desc}:EmployeeSubrecord:Absence:String:Linked:Init";

            Type absenceType = new CareerHistoryDDM().GetType();
            PropertyInfo absencePropertyInfo = absenceType.GetProperty("AbsenceReason");

            Type picklistType = new PicklistDDM().GetType();
            PropertyInfo picklistId = picklistType.GetProperty("Id");
            PropertyInfo picklistDescription = picklistType.GetProperty("Description");

            LinkedInput linkedInput = new LinkedInput()
            {
                SourceFieldType = FieldTypeEnum.EmployeeSubrecord,
                SourceDataModelType = DataModelTypeEnum.Absence,
                SourceLinkFieldName = absencePropertyInfo.Name,
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Picklist,
                TargetFieldType = FieldTypeEnum.Organisation,
                TargetLinkFieldName = picklistId.Name,
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetFieldName = picklistDescription.Name,
                TargetPrimitiveType = PrimitiveTypeEnum.String
            };

            string linkedDTO = LinkedInput.MapToDTO(linkedInput);

            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", linkedDTO, foptions, new FieldPermissions());
        }

        #endregion
        
        #region Plain

        /// <summary>
        /// Create the Report Field parameters of the Absence table CreatedDate field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> CreatedDate()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:CreatedDate:CreatedDate:Created On:{desc}:EmployeeSubrecord:Absence:NullableDateTime:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy_hh_mm_ss,
                DecimalPlaces = 0,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table LastModifiedDate field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> LastModifiedDate()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:LastModifiedDate:LastModifiedDate:Last Modified On:{desc}:EmployeeSubrecord:Absence:NullableDateTime:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy_hh_mm_ss,
                DecimalPlaces = 0,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table LastModifiedUser field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> LastModifiedUser()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:LastModifiedUser:LastModifiedUser:Last Modified By:{desc}:EmployeeSubrecord:Absence:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table Cost field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Cost()
        {
            string desc = "Absence Cost";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:cost:Cost:Cost:{desc}:EmployeeSubrecord:Absence:NullableDecimal:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.DecimalPlaces,
                DecimalPlaces = 2,
                MaxColumnLength = 10,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table Cost2 field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Cost2()
        {
            string desc = "Absence Cost";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:cost2:Cost2:Addl Cost:{desc}:EmployeeSubrecord:Absence:NullableDecimal:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.DecimalPlaces,
                DecimalPlaces = 2,
                MaxColumnLength = 10,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        /// <summary>
        ///  Create the Report Field parameters of the Absence table CostPercentage field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> CostPercentage()
        {
            string desc = "Absence Cost Percentage";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:costpercentage:CostPercentage:% on Cost:{desc}:EmployeeSubrecord:Absence:NullableDecimal:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Percentage,
                DecimalPlaces = 3,
                MaxColumnLength = 10,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        /// <summary>
        ///  Create the Report Field parameters of the Absence table CostValue field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> CostValue()
        {
            string desc = "Absence Cost value";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:costvalue:CostValue:% Cost:{desc}:EmployeeSubrecord:Absence:NullableDecimal:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.DecimalPlaces,
                DecimalPlaces = 2,
                MaxColumnLength = 10,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table Department field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Department()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:department:Department:Department:{desc}:EmployeeSubrecord:Absence:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };

            var fpermissions = new FieldPermissions();

            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table Duration field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Duration()
        {
            string desc = "Absence Cost value";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:duration:Duration:Duration:{desc}:EmployeeSubrecord:Absence:NullableDecimal:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.VariablesDecimalPlaces,
                DecimalPlaces = 2,
                MaxColumnLength = 10,
                DisplayNamePlaceHolder = "unit"
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table FromDate field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> FromDate()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:FromDate:FromDate:From:{desc}:EmployeeSubrecord:Absence:NullableDateTime:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy,
                DecimalPlaces = 0,
                MaxColumnLength = 12,
                DisplayNamePlaceHolder = ""
            };

            var fpermissions = new FieldPermissions();

            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table Grade field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Grade()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:grade:Grade:Grade:{desc}:EmployeeSubrecord:Absence:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };

            var fpermissions = new FieldPermissions();

            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table IsAnnualLeave field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> IsAnnualLeave()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:isannualleave:IsAnnualLeave:This Years Hol?:{desc}:EmployeeSubrecord:Absence:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.ToYesNo,
                DecimalPlaces = 0,
                MaxColumnLength = 3,
                DisplayNamePlaceHolder = ""
            };

            var fpermissions = new FieldPermissions();

            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table IsNextYearLeave field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> IsNextYearLeave()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:isnextyearleave:IsNextYearLeave:Next Years Hol?:{desc}:EmployeeSubrecord:Absence:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.ToYesNo,
                DecimalPlaces = 0,
                MaxColumnLength = 3,
                DisplayNamePlaceHolder = ""
            };

            var fpermissions = new FieldPermissions();

            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table Location field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Location()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:location:Location:Location:{desc}:EmployeeSubrecord:Absence:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };

            var fpermissions = new FieldPermissions();

            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table MedicalDate1 field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> MedicalDate1()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:medicaldate1:MedicalDate1:MedicalDate1:{desc}:EmployeeSubrecord:Absence:NullableDateTime:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy,
                DecimalPlaces = 0,
                MaxColumnLength = 12,
                DisplayNamePlaceHolder = ""
            };

            var fpermissions = new FieldPermissions();

            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table MedicalDate2 field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> MedicalDate2()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:medicaldate2:MedicalDate2:MedicalDate2:{desc}:EmployeeSubrecord:Absence:NullableDateTime:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy,
                DecimalPlaces = 0,
                MaxColumnLength = 12,
                DisplayNamePlaceHolder = ""
            };

            var fpermissions = new FieldPermissions();

            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table Notes field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Notes()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:notes:Notes:Notes:{desc}:EmployeeSubrecord:Absence:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Memo,
                DecimalPlaces = 0,
                MaxColumnLength = 100,
                DisplayNamePlaceHolder = ""
            };

            var fpermissions = new FieldPermissions();

            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Create the Report Field parameters of the Absence table PaidSsp field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> PaidSsp()
        {
            string desc = "Flag that checks if SSP is paid";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:paidssp:PaidSsp:SSP Paid?:{desc}:EmployeeSubrecord:Absence:NullableBool:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.ToYesNo,
                DecimalPlaces = 0,
                MaxColumnLength = 3,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        /// <summary>
        /// Create the Report Field of the Absence table ToDate field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ToDate()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:todate:ToDate:To:{desc}:EmployeeSubrecord:Absence:NullableDateTime:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy,
                DecimalPlaces = 0,
                MaxColumnLength = 12,
                DisplayNamePlaceHolder = ""
            };

            var fpermissions = new FieldPermissions();

            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Create the Report Field parameters of the Absence table TotalCost field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> TotalCost()
        {
            string desc = "Absence Cost";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:totalcost:TotalCost:Total Cost:{desc}:EmployeeSubrecord:Absence:NullableDecimal:Plain:Init";

            var foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.DecimalPlaces,
                DecimalPlaces = 2,
                MaxColumnLength = 10,
                DisplayNamePlaceHolder = ""
            };

            return Tuple.Create(fparams, "", "", foptions, new FieldPermissions());
        }

        /// <summary>
        /// Create the Report Field parameters of the Absence table WorkPattern field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> WorkPattern()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"absence:workpattern:WorkPattern:Work Pattern:{desc}:EmployeeSubrecord:Absence:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 10,
                DisplayNamePlaceHolder = ""
            };

            var fpermissions = new FieldPermissions();

            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        #endregion
    }
}
