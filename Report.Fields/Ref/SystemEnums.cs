using PscLib.Domain.Util.Enums;

namespace Report.Fields.Ref
{
    public static class SystemEnums
    {
        public static string GetEnumLinkItemValue(int linkValue, string targetLinkfieldName)
        {
            switch (targetLinkfieldName)
            {
                case "gender":
                    return linkValue.EnumValue<GenderEnum>().DisplayName();
                case "paybasis":
                    return linkValue.EnumValue<PayBasisEnum>().DisplayName();
                case "paymethod":
                    return linkValue.EnumValue<PayMethodEnum>().DisplayName();
                case "payrollstatus":
                    return linkValue.EnumValue<PayrollStatusEnum>().DisplayName();
                case "payrolltype":
                    return linkValue.EnumValue<PayFrequencyEnum>().DisplayName();
                case "taxbasis":
                    return linkValue.EnumValue<TaxBasisEnum>().DisplayName();
                case "niletter":
                    return linkValue.EnumValue<NILetterEnum>().DisplayName();
                case "martialstatus":
                    return linkValue.EnumValue<MaritalStatusEnum>().DisplayName();
                case "fullparttime":
                    return linkValue.EnumValue<FullPartTimeEnum>().DisplayName();
                default:
                    return "";
            }
        }
    }
}
