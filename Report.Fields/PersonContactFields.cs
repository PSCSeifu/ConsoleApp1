using Report.Fields.Model;
using Report.Fields.Ref;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Report.Fields
{
    public class PersonContactFields
    {
        /// <summary>
        /// Returns a List of Tuple parameters of  the Linked type  Career History Report Fields
        /// </summary>
        /// <returns></returns>
        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> PersonContactLinkedField()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();
            list.Add(Relationship());
            return list;
        }

        /// <summary>
        /// Returns a List of Tuple parameters of  the plain type  Career History Report Fields
        /// </summary>
        /// <returns></returns>
        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> PersonContactPlainFields()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();
            list.Add(Address1());
            list.Add(Address2());
            list.Add(Address3());
            list.Add(Address4());
            list.Add(Address5());
            list.Add(Country());
            list.Add(DateOfBirth());
            list.Add(Email());
            list.Add(HomePhone());
            list.Add(IsDependent());
            list.Add(IsEmergency());
            list.Add(IsNextOfKin());
            list.Add(MobilePhone());
            list.Add(Name());
            list.Add(Notes());
            list.Add(WorkPhone());
            return list;
        }

        #region Linked

        /// <summary>
        ///  Returns the Report Field parameters of the PersonContact table Contact relationship Linked field.
        ///  When a report is produced, the ContactRelationshipId int? field value is linked to the Picklist to fetch the Contact Relationship description for the particular Organisation.
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Relationship()
        {
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string desc = "Person's contact Relationship Description";
            string fparams = $"personcontact:relationship:ContactRelationshipId:Relationship:{desc}:EmployeeSubrecord:PersonContact:String:Linked:Init";

            Type personContactType = new PersonContactDDM().GetType();
            PropertyInfo pcPropertyInfo = personContactType.GetProperty("ContactRelationshipId");

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
        /// Returns the Report Field parameters of the PersonContact table Address1 field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Address1()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:address1:Address1:Address1:{desc}:EmployeeSubrecord:PersonContact:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 50,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the PersonContact table Address2 field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Address2()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:address2:Address2:Address2:{desc}:EmployeeSubrecord:PersonContact:String:Direct:Init";
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
        /// Returns the Report Field parameters of the PersonContact table Address3 field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Address3()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:address3:Address3:Address3:{desc}:EmployeeSubrecord:PersonContact:String:Direct:Init";
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
        ///  Returns the Report Field parameters of the PersonContact table Address4 field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Address4()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:address4:Address4:Address4:{desc}:EmployeeSubrecord:PersonContact:String:Direct:Init";
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
        ///  Returns the Report Field parameters of the PersonContact table Address5 field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Address5()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:address5:Address5:Address-PC:{desc}:EmployeeSubrecord:PersonContact:String:Direct:Init";
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

        /// <summary>
        ///  Returns the Report Field parameters of the PersonContact table Country field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Country()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:country:Country:Country:{desc}:EmployeeSubrecord:PersonContact:String:Direct:Init";
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
        ///  Returns the Report Field parameters of the PersonContact table DateOfBirth field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> DateOfBirth()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:dateofbirth:DateOfBirth:DOB:{desc}:EmployeeSubrecord:PersonContact:NullableDateTime:Direct:Init";
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
        ///  Returns the Report Field parameters of the PersonContact table Email field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Email()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:email:Email:Email:{desc}:EmployeeSubrecord:PersonContact:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 50,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the PersonContact table HomePhone field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> HomePhone()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:homephone:HomePhone:Home Phone:{desc}:EmployeeSubrecord:PersonContact:String:Direct:Init";
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
        ///  Returns the Report Field parameters of the PersonContact table IsDependent field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> IsDependent()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:isdependent:IsDependent:Is Dependent?:{desc}:EmployeeSubrecord:PersonContact:NullableBool:Direct:Init";
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
        ///  Returns the Report Field parameters of the PersonContact table IsEmergency field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> IsEmergency()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:isemergency:IsEmergency:Is Emergency Contact?:{desc}:EmployeeSubrecord:PersonContact:NullableBool:Direct:Init";
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
        ///  Returns the Report Field parameters of the PersonContact table IsNextOfKin field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> IsNextOfKin()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:IsNextOfKin:IsNextOfKin:Is Next Of kin?:{desc}:EmployeeSubrecord:PersonContact:NullableBool:Direct:Init";
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
        ///  Returns the Report Field parameters of the PersonContact table MobilePhone field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> MobilePhone()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:mobilephone:MobilePhone:Mobile No:{desc}:EmployeeSubrecord:PersonContact:String:Direct:Init";
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
        ///  Returns the Report Field parameters of the PersonContact table Name field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Name()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:name:Name:Name:{desc}:EmployeeSubrecord:PersonContact:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 50,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the PersonContact table Notes field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Notes()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:notes:Notes:Notes:{desc}:EmployeeSubrecord:PersonContact:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 100,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the PersonContact table WorkPhone field
        /// </summary>
        /// <returns></returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> WorkPhone()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"personcontact:workphone:WorkPhone:Work Phone:{desc}:EmployeeSubrecord:PersonContact:String:Direct:Init";
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
