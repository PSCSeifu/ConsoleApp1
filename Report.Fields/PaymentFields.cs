using Report.Fields.Model;
using Report.Fields.Ref;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Report.Fields
{
    public class PaymentFields
    {
        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> PaymentLinkedFields()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();
            list.Add(Type());
            return list;
        }

        public static List<Tuple<string, string, string, FieldOptions, FieldPermissions>> PaymentPlainFields()
        {
            List<Tuple<string, string, string, FieldOptions, FieldPermissions>> list = new List<Tuple<string, string, string, FieldOptions, FieldPermissions>>();
            list.Add(EffectiveFrom());
            list.Add(EffectiveTo());
            list.Add(BasicSalary());
            list.Add(HourlyRate());
            list.Add(OvertimeRate());
            list.Add(PayPeriods());
            list.Add(ContractedHours());
            list.Add(AllowOvertime());
            list.Add(AnnualPay());
            list.Add(MonthlyPay());
            list.Add(FullTimeEquivalent());
            list.Add(FullTimeSalary());
            list.Add(DaysWorked());
            return list;
        }

        #region Linked

        /// <summary>
        /// Returns the Report Field parameters of the Payment table's Type Linked field.
        /// When a report is produced, the Type int? field value is linked to the a
        /// Systemn Enum & its description is returned as the value for the particular Organisation.
        /// </summary>
        /// <returns>Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> Type()
        {
            string desc = "Payment Start Date";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:type:Type:Type:{desc}:EmployeeSubrecord:Payment:NullableDateTime:Linked:Init";

            Type paymentType = new PaymentDDM().GetType();
            PropertyInfo pyPropertyInfo = paymentType.GetProperty("Type");

            LinkedInput linkedInput = new LinkedInput()
            {
                SourceFieldType = FieldTypeEnum.EmployeeSubrecord,
                SourceDataModelType = DataModelTypeEnum.Payment,
                SourceLinkFieldName = pyPropertyInfo.Name,
                SourceLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetDataModelType = DataModelTypeEnum.Enum,
                TargetFieldType = FieldTypeEnum.Organisation,
                TargetLinkFieldName = pyPropertyInfo.Name,
                TargetLinkPrimitiveType = PrimitiveTypeEnum.NullableInt,

                TargetFieldName = pyPropertyInfo.Name,
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
        ///  Returns the Report Field parameters of the Payment table EffectiveFrom field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> EffectiveFrom()
        {
            string desc = "Payment Start Date";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:effectivefrom:EffectiveFrom:Payment Start Date:{desc}:EmployeeSubrecord:Payment:NullableDateTime:Direct:Init";
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
        ///  Returns the Report Field parameters of the Payment table EffectiveTo field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> EffectiveTo()
        {
            string desc = "Payment End Date";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:effectiveto:EffectiveTo:Payment End Date:{desc}:EmployeeSubrecord:Payment:NullableDateTime:Direct:Init";
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
        ///  Returns the Report Field parameters of the Payment table BasicSalary field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> BasicSalary()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:basicsalary:BasicSalary:Basic Salary:{desc}:EmployeeSubrecord:Payment:NullableDecimal:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.DecimalPlaces,
                DecimalPlaces = 2,
                MaxColumnLength = 15,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the Payment table HourlyRate field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> HourlyRate()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:hourlyrate:HourlyRate:Hourly Rate:{desc}:EmployeeSubrecord:Payment:NullableDecimal:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Rate,
                DecimalPlaces = 4,
                MaxColumnLength = 15,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the Payment table OvertimeRate field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> OvertimeRate()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:overtimerate:OvertimeRate:Overtime Rate:{desc}:EmployeeSubrecord:Payment:NullableDecimal:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Rate,
                DecimalPlaces = 4,
                MaxColumnLength = 15,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the Payment table PayPeriods field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> PayPeriods()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:payperiods:PayPeriods:Pay Periods /Y:{desc}:EmployeeSubrecord:Payment:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 2,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the Payment table ContractedHours field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> ContractedHours()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:contractedhours:ContractedHours:Contracted Hours /W:{desc}:EmployeeSubrecord:Payment:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 2,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the Payment table AllowOvertime field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> AllowOvertime()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:allowovertime:AllowOvertime:Allow Overtime?:{desc}:EmployeeSubrecord:Payment:NullableBool:Direct:Init";
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
        ///  Returns the Report Field parameters of the Payment table AnnualPay field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> AnnualPay()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:annualpay:AnnualPay:Annual Pay:{desc}:EmployeeSubrecord:Payment:NullableDecimal:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.DecimalPlaces,
                DecimalPlaces = 2,
                MaxColumnLength = 15,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the Payment table MonthlyPay field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> MonthlyPay()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:monthlypay:MonthlyPay:Monthly Pay:{desc}:EmployeeSubrecord:Payment:NullableDecimal:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.DecimalPlaces,
                DecimalPlaces = 2,
                MaxColumnLength = 15,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the Payment table FullTimeEquivalent field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> FullTimeEquivalent()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:fulltimeequivalent:FullTimeEquivalent:Full Time Equivalent:{desc}:EmployeeSubrecord:Payment:NullableDecimal:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.DecimalPlaces,
                DecimalPlaces = 2,
                MaxColumnLength = 15,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the Payment table FullTimeSalary field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> FullTimeSalary()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:fulltimesalary:FullTimeSalary:Full Time Salary:{desc}:EmployeeSubrecord:Payment:NullableDecimal:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.DecimalPlaces,
                DecimalPlaces = 2,
                MaxColumnLength = 15,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        /// <summary>
        ///  Returns the Report Field parameters of the Payment table DaysWorked field
        /// </summary>
        /// <returns> Tuple<string, string, string, FieldOptions, FieldPermissions> </returns>
        private static Tuple<string, string, string, FieldOptions, FieldPermissions> DaysWorked()
        {
            string desc = "";
            /* fparams = sqlTableName: sqlFieldName: fieldName: displayName: description: fieldType:dataModelType: primitiveType:extractionType: LastModifiedUser */
            string fparams = $"payment:daysworked:DaysWorked:Days Worked /W:{desc}:EmployeeSubrecord:Payment:String:Direct:Init";
            FieldOptions foptions = new FieldOptions()
            {
                CustomFormatString = "",
                DisplayMode = DataDisplayModeEnum.Text,
                DecimalPlaces = 0,
                MaxColumnLength = 2,
                DisplayNamePlaceHolder = ""
            };
            var fpermissions = new FieldPermissions();
            return Tuple.Create(fparams, "", "", foptions, fpermissions);
        }

        #endregion
    }
}
