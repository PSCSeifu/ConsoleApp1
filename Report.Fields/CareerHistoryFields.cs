using Report.Fields.Model;
using Report.Fields.Ref;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Report.Fields
{
    public class CareerHistoryFields
    {
        /// <summary>
        /// Returns a List of Tuple parameters of  the Linked type  Career History Report Fields
        /// </summary>
        /// <returns></returns>
        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> CareerHistoryLinkedFields()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();
            list.Add(CareerEvent());
            list.Add(CareerReason());
            return list;
        }

        /// <summary>
        /// Returns a List of Tuple parameters of  the plain type  Career History Report Fields
        /// </summary>
        /// <returns></returns>
        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> CareerHistoryPlainFields()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();
            list.Add(CreatedDate());
            list.Add(LastModifiedDate());
            list.Add(LastModifiedUser());
            list.Add(FromDate());
            list.Add(FromDepartment());
            list.Add(FromGrade());
            list.Add(FromJobTitle());
            list.Add(FromPay());
            list.Add(FromSite());
            list.Add(Notes());
            list.Add(ToDate());
            list.Add(ToDepartment());
            list.Add(ToGrade());
            list.Add(ToJobTitle());
            return list;
        }

        #region Linked

        /// <summary>
        ///  Returns the Report Field parameters of the CareerHistory table Career Event plain fields.
        ///  When a report is produced, the Event int? field value is linked to the Picklist to fetch the Career Event description for the particular Organisation.
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> CareerEvent()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Career Event Description";
            string fparams = $"careerhistory:careerevent:CareerEvent:Career Event:{desc}:EmployeeSubrecord:CareerHistory:String:Linked:Init";

            Type careerhistoryType = new CareerHistoryDDM().GetType();
            PropertyInfo chPropertyInfo = careerhistoryType.GetProperty("Event");

            Type picklistType = new PicklistDDM().GetType();
            PropertyInfo picklistId = picklistType.GetProperty("Id");
            PropertyInfo picklistDescription = picklistType.GetProperty("Description");

            LinkedInput linkedInput = new LinkedInput()
            {
                SourceFieldType = FieldTypeEnum.EmployeeSubrecord,
                SourceDataModelType = DataModelTypeEnum.CareerHistory,
                SourceLinkFieldName = chPropertyInfo.Name,
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
        ///  Returns the Report Field parameters of the CareerHistory table Career Reason Linked field.
        ///  When a report is produced, the Reason int? field value is linked to the Picklist to fetch the Career Reason description for the particular Organisation.
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> CareerReason()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Career Reason Description";
            string fparams = $"careerhistory:careereason:CareerReason:Career Reason:{desc}:EmployeeSubrecord:CareerHistory:String:Linked:Init";
            
            Type careerhistoryType = new CareerHistoryDDM().GetType();
            PropertyInfo chPropertyInfo = careerhistoryType.GetProperty("Reason");

            Type picklistType = new PicklistDDM().GetType();
            PropertyInfo picklistId = picklistType.GetProperty("Id");
            PropertyInfo picklistDescription = picklistType.GetProperty("Description");
            
            LinkedInput linkedInput = new LinkedInput()
            {
                SourceFieldType = FieldTypeEnum.EmployeeSubrecord,
                SourceDataModelType = DataModelTypeEnum.CareerHistory,
                SourceLinkFieldName = chPropertyInfo.Name,
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
        /// Returns the Report Field parameters of the Career History table CreatedDate field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> CreatedDate()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:CreatedDate:CreatedDate:Created On:{desc}:EmployeeSubrecord:v:NullableDateTime:Direct:Init";
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
        /// Retuens the Report Field parameters of the Career History table LastModifiedDate field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> LastModifiedDate()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:LastModifiedDate:LastModifiedDate:Last Modified On:{desc}:EmployeeSubrecord:CareerHistory:NullableDateTime:Direct:Init";
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
        /// Returns the Report Field parameters of the Career History table LastModifiedUser field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> LastModifiedUser()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:LastModifiedUser:LastModifiedUser:Last Modified By:{desc}:EmployeeSubrecord:CareerHistory:String:Direct:Init";
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
        /// Returns the Report Field parameters of the Career History table FromDate field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> FromDate()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:fromdate:FromDate:From Date:{desc}:EmployeeSubrecord:CareerHistory:NullableDateTime:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy,
                DecimalPlaces = 0,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Returns the Report Field parameters of the Career History table FromDepartment field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> FromDepartment()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:fromdepartment:FromDepartment:From Department:{desc}:EmployeeSubrecord:CareerHistory:String:Direct:Init";
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
        /// Returns the Report Field parameters of the Career History table FromGrade field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> FromGrade()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:fromgrade:FromGrade:From Grade:{desc}:EmployeeSubrecord:CareerHistory:String:Direct:Init";
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
        /// Returns the Report Field parameters of the Career History table FromJobTitle field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> FromJobTitle()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:fromjobtitle:FromJobTitle:From Job Title:{desc}:EmployeeSubrecord:CareerHistory:String:Direct:Init";
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
        /// Returns the Report Field parameters of the Career History table FromPay field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> FromPay()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:frompay:FromPay:From Pay:{desc}:EmployeeSubrecord:CareerHistory:NullableDecimal:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.VariablesDecimalPlaces,
                DecimalPlaces = 2,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Retruns the Report Field parameters of the Career History table FromSite field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> FromSite()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:fromsite:FromSite:From Site:{desc}:EmployeeSubrecord:CareerHistory:String:Direct:Init";
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
        /// Retruns the Report Field parameters of the Career History table Notes field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Notes()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:notes:Notes:Notes:{desc}:EmployeeSubrecord:CareerHistory:String:Direct:Init";
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
        /// Returns the Report Field parameters of the Career History table ToDate field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ToDate()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:todate:ToDate:To Date:{desc}:EmployeeSubrecord:CareerHistory:NullableDateTime:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.dd_MMM_yyyy,
                DecimalPlaces = 0,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Returns the Report Field parameters of the Career History table ToDepartment field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ToDepartment()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:todepartment:ToDepartment:To Department:{desc}:EmployeeSubrecord:CareerHistory:String:Direct:Init";
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
        /// Returns the Report Field parameters of the Career History table ToGrade field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ToGrade()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:tograde:ToGrade:To Grade:{desc}:EmployeeSubrecord:CareerHistory:String:Direct:Init";
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
        /// Returns the Report Field parameters of the Career History table ToJobTitle field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ToJobTitle()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:tojobtitle:ToJobTitle:To Job Title:{desc}:EmployeeSubrecord:CareerHistory:String:Direct:Init";
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
        /// Returns the Report Field parameters of the Career History table ToPay field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ToPay()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:topay:ToPay:To Pay:{desc}:EmployeeSubrecord:CareerHistory:NullableDecimal:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.VariablesDecimalPlaces,
                DecimalPlaces = 2,
                MaxColumnLength = 25,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        /// Retruns the Report Field parameters of the Career History table ToSite field
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ToSite()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"careerhistory:tosite:ToSite:To Site:{desc}:EmployeeSubrecord:CareerHistory:String:Direct:Init";
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
        #endregion
    }
}
