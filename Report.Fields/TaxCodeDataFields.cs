using Report.Fields.Model;
using Report.Fields.Ref;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Report.Fields
{
    public class TaxCodeDataFields
    {
        /// <summary>
        /// Returns a List of Tuple parameters of  the Linked type  TaxCodeForm Report Fields
        /// </summary>
        /// <returns>List<Tuple<string, string, string, FieldOptions, FieldPermissions>></returns>
        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> TaxCodeChangesLinkedFields()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();            
            return list;
        }

        /// <summary>
        /// Returns a List of Tuple parameters of  the Plain type  TaxCodeForm Report Fields
        /// </summary>
        /// <returns>List<Tuple<string, string, string, FieldOptions, FieldPermissions>></returns>
        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> TaxCodeChangesPlainFields()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();            
            return list;
        }

        #region Linked

        /// <summary>
        /// Returns the Report Field parameters of the TaxCodeForm table's Type Linked field.
        /// When a report is produced, the FormType int? field value is linked to the a
        /// Systemn Enum & its description is returned as the value for the particular Organisation.
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> FormType()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"taxcodedata:type:Type:Type:{desc}:EmployeeSubrecord:Payment:NullableDateTime:Linked:Init";

            Type taxCodeDataType = new TaxCodeDataDDM().GetType();
            PropertyInfo pyPropertyInfo = taxCodeDataType.GetProperty("FormType");

            LinkedInput linkedInput = new LinkedInput()
            {
                SourceFieldType = FieldTypeEnum.EmployeeSubrecord,
                SourceDataModelType = DataModelTypeEnum.Payment,
                SourceLinkFieldName = taxCodeDataType.Name,
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Enum,
                TargetFieldType = FieldTypeEnum.Organisation,
                TargetLinkFieldName = taxCodeDataType.Name,
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetFieldName = taxCodeDataType.Name,
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
    }
}
