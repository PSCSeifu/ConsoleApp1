using Report.Fields.Model;
using Report.Fields.Ref;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Report.Fields
{
    public class ExitInterviewFields
    {
        /// <summary>
        /// Returns a List of Tuple parameters of  the Linked type  ExitInterview Report Fields
        /// </summary>
        /// <returns></returns>
        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> ExitInterviewLinkedField()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();
            list.Add(LeavingReason());
            return list;
        }

        /// <summary>
        /// Returns a List of Tuple parameters of  the Plain type  ExitInterview Report Fields
        /// </summary>
        /// <returns></returns>
        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> ExitInterviewPlainField()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();
            list.Add(CreatedDate());
            list.Add(LastModifiedDate());
            list.Add(LastModifiedUser());
            list.Add(InterviewDate());
            list.Add(InterviewBy());
            list.Add(ReferenceGiven());
            list.Add(Notes());
            list.Add(ReEmploy());
            list.Add(ReEmployBy());
            return list;
        }

        #region Linked

        /// <summary>
        ///  Returns the Report Field parameters of the Exitinterview table LeavingReason Linked field.
        ///  When a report is produced, the LeavingReasonId int? field value is linked to the Picklist to fetch the Contact Relationship description for the particular Organisation.
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> LeavingReason()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Exit Interview Leaving Reason Description";
            string fparams = $"exitinterview:leavingreason:LeavingReasonId:Reason:{desc}:EmployeeSubrecord:ExitInterview:String:Linked:Init";

            Type personContactType = new ExitInterviewDDM().GetType();
            PropertyInfo pcPropertyInfo = personContactType.GetProperty("LeavingReasonId");

            Type picklistType = new PicklistDDM().GetType();
            PropertyInfo picklistId = picklistType.GetProperty("Id");
            PropertyInfo picklistDescription = picklistType.GetProperty("Description");

            LinkedInput linkedInput = new LinkedInput()
            {
                SourceFieldType = FieldTypeEnum.EmployeeSubrecord,
                SourceDataModelType = DataModelTypeEnum.PersonContact,
                SourceLinkFieldName = pcPropertyInfo.Name,
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
        ///  Returns the Report Field parameters of the ExitInterview table CreatedDate field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> CreatedDate()
        {
            string desc = "The day the Exit interview was conducted";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"exitinterview:createddate:CreatedDate:Created On:{desc}:EmployeeSubrecord:ExitInterview:NullableDateTime:Direct:Init";
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
        ///  Returns the Report Field parameters of the ExitInterview table LastModifiedDate field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> LastModifiedDate()
        {
            string desc = "The day the Exit interview was conducted";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"exitinterview:LastModifiedDate:LastModifiedDate:Last Modified On:{desc}:EmployeeSubrecord:ExitInterview:NullableDateTime:Direct:Init";
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
        ///  Returns the Report Field parameters of the ExitInterview table LastModifiedUser field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> LastModifiedUser()
        {
            string desc = "The day the Exit interview was conducted";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"exitinterview:lastmodifieduser:LastModifiedUser:Last Modified By:{desc}:EmployeeSubrecord:ExitInterview:String:Direct:Init";
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
        ///  Returns the Report Field parameters of the ExitInterview table InterviewDate field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> InterviewDate()
        {
            string desc = "The day the Exit interview was conducted";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"exitinterview:interviewdate:InterviewDate:Interview Date:{desc}:EmployeeSubrecord:ExitInterview:NullableDateTime:Direct:Init";
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
        ///  Returns the Report Field parameters of the ExitInterview table InterviewBy field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> InterviewBy()
        {
            string desc = "The name of the person the Exit interview was conducted by";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"exitinterview:interviewby:InterviewBy:Interview By:{desc}:EmployeeSubrecord:ExitInterview:String:Direct:Init";
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
        ///  Returns the Report Field parameters of the ExitInterview table ReferenceGiven field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ReferenceGiven()
        {
            string desc = "The name of the person the Exit interview was conducted by";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"exitinterview:referencegiven:ReferenceGiven:Reference Given?:{desc}:EmployeeSubrecord:ExitInterview:NullableBool:Direct:Init";
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
        ///  Returns the Report Field parameters of the ExitInterview table Notes field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Notes()
        {
            string desc = "The name of the person the Exit interview was conducted by";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"exitinterview:notes:Notes:Notes:{desc}:EmployeeSubrecord:ExitInterview:String:Direct:Init";
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
        ///  Returns the Report Field parameters of the ExitInterview table ReEmploy field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ReEmploy()
        {
            string desc = "The name of the person the Exit interview was conducted by";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"exitinterview:reemploy:ReEmploy:ReEmploy?:{desc}:EmployeeSubrecord:ExitInterview:NullableBool:Direct:Init";
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
        ///  Returns the Report Field parameters of the ExitInterview table ReEmployBy field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ReEmployBy()
        {
            string desc = "The name of the person the Exit interview was conducted by";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"exitinterview:reemployby:ReEmployBy:ReEmploy By:{desc}:EmployeeSubrecord:ExitInterview:String:Direct:Init";
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
