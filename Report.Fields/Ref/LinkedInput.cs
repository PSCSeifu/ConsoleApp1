using ms.eReport.Domain;
using PscLib.Domain.Util.Enums;
using System;
using System.Linq;

namespace Report.Fields.Ref
{
    [Serializable]
    public class LinkedInput
    {
        /* Source table - the table the field is identified with */
        public FieldTypeEnum SourceFieldType { get; set; }
        public DataModelTypeEnum SourceDataModelType { get; set; }

        /* Source Field - the field in teh source table that links to the target table ( "the foreign key" )*/
        public string SourceLinkFieldName { get; set; }
        public PrimitiveTypeEnum SourceLinkPrimitiveType { get; set; }

        /* Target table - the table the data is going to be fetched from */
        public DataModelTypeEnum TargetDataModelType { get; set; }
        public FieldTypeEnum TargetFieldType { get; set; }

        /* Target Link Field - the field in the target table the links with the source ( "the primary key") */
        public string TargetLinkFieldName { get; set; }
        public PrimitiveTypeEnum TargetLinkPrimitiveType { get; set; }

        /* Target Feild - the data field */
        public string TargetFieldName { get; set; }
        public PrimitiveTypeEnum TargetPrimitiveType { get; set; }

        public LinkedInput()
        {

        }

        public static LinkedInput Empty() => null;

        public static bool IsEmpty(LinkedInput linkedInput) => Object.Equals(Empty(), linkedInput);

        public static string MapToDTO(LinkedInput linkedInput)
        {
            if (linkedInput == null)
                return $"";

            int sft = (int)linkedInput.SourceFieldType;
            int sdmt = (int)linkedInput.SourceDataModelType;
            string slfn = linkedInput.SourceLinkFieldName;
            int slpt = (int)linkedInput.SourceLinkPrimitiveType;

            int tgmt = (int)linkedInput.TargetDataModelType;
            int tft = (int)linkedInput.TargetFieldType;
            string tlfn = linkedInput.TargetLinkFieldName;
            int tlpt = (int)linkedInput.TargetLinkPrimitiveType;

            string tfn = linkedInput.TargetFieldName;
            int tpt = (int)linkedInput.TargetPrimitiveType;

            return $"{sft.ToString()},{sdmt.ToString()},{slfn},{slpt.ToString()},{tgmt.ToString()},{tft.ToString()},{tlfn},{tlpt.ToString()},{tfn},{tpt.ToString()}";
        }

        public static LinkedInput MapFromDTO(string linkedInputDTO)
        {
            LinkedInput domain = new LinkedInput();

            if (string.IsNullOrEmpty(linkedInputDTO)) return Empty();

            try
            {
                string[] array = linkedInputDTO.Split(',');

                if (array.Count() == 0)
                {
                    domain = Empty();
                }
                else if (array.Count() >= 10)
                {
                    domain.SourceFieldType = Convert.ToInt32(array[0]).EnumValue<FieldTypeEnum>();
                    domain.SourceDataModelType = Convert.ToInt32(array[1]).EnumValue<DataModelTypeEnum>();

                    domain.SourceLinkFieldName = array[2];
                    domain.SourceLinkPrimitiveType = Convert.ToInt32(array[3]).EnumValue<PrimitiveTypeEnum>();

                    domain.TargetDataModelType = Convert.ToInt32(array[4]).EnumValue<DataModelTypeEnum>();
                    domain.TargetFieldType = Convert.ToInt32(array[5]).EnumValue<FieldTypeEnum>();

                    domain.TargetLinkFieldName = array[6];
                    domain.TargetLinkPrimitiveType = Convert.ToInt32(array[7]).EnumValue<PrimitiveTypeEnum>();

                    domain.TargetFieldName = array[8];
                    domain.TargetPrimitiveType = Convert.ToInt32(array[9]).EnumValue<PrimitiveTypeEnum>();
                }
            }
            catch (Exception)
            {
                return Empty();
            }

            return domain;
        }

        public static PrimitiveTypeEnum GetTargetPrimitiveType(LinkedInput linkedInput)
            => linkedInput?.TargetPrimitiveType ?? PrimitiveTypeEnum.None;

        public static FieldTypeEnum GetSourceFieldType(LinkedInput linkedInput)
            => linkedInput?.SourceFieldType ?? FieldTypeEnum.None;

        public static FieldTypeEnum GetTargetFieldType(LinkedInput linkedInput)
           => linkedInput?.TargetFieldType ?? FieldTypeEnum.None;

        public static DataModelTypeEnum GetSourceDataModelType(LinkedInput linkedInput)
            => linkedInput?.SourceDataModelType ?? DataModelTypeEnum.None;

        public static DataModelTypeEnum GetTargetDataModelType(LinkedInput linkedInput)
           => linkedInput?.TargetDataModelType ?? DataModelTypeEnum.None;
    }
}
