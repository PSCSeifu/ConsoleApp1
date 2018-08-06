using PscLib.Domain.Util.Enums;
using System;
using System.Linq;

namespace Report.Fields.Ref
{
    public class FieldOptions
    {
        public string CustomFormatString { get; set; }
        public DataDisplayModeEnum DisplayMode { get; set; }
        public int DecimalPlaces { get; set; }
        public int MaxColumnLength { get; set; }
        public string DisplayNamePlaceHolder { get; set; }
         


        public FieldOptions()
        {

        }

        public static FieldOptions Empty() => null;

        /// <summary>
        /// Maps the FieldOptions in to a comma seprated string. The csv string is commited to the table storage database,
        /// </summary>
        /// <param name="domain"></param>
        /// <returns>string</returns>
        public static string MapToDTO(FieldOptions domain)
        {
            if (domain == null) return string.Empty;
            try
            {
                string s1 = domain.CustomFormatString;
                string s2 = Convert.ToString((int)domain.DisplayMode);
                string s3 = Convert.ToString(domain.DecimalPlaces);
                string s4 = Convert.ToString(domain.MaxColumnLength);
                string s5 = domain.DisplayNamePlaceHolder;

                return $"{s1},{s2},{s3},{s4},{s5}";
            }
            catch (Exception) { }

            return string.Empty;
        }

        /// <summary>
        /// Reads the csv string and maps it to the FieldOtions domain class. Returns the class from default constructor if the string is invalid or incorrect.
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>FieldOptions</returns>
        public static FieldOptions MapFromDTO(string dto)
        {
            FieldOptions domain = new FieldOptions();

            try
            {
                string[] array = dto.Split(',');

                if (array.Count() >= 5)
                {
                    /* Require array count >=5 as 5 items are expcted. If an additional items is added to the domain class, append at end by tenting if e.g. array[6]  exists first.*/
                    domain.CustomFormatString = array[0];

                    /*Get an int value first, then use the library method EnumValue, else nested conversion and method applicaiton results in error.*/
                    int displayMode = Convert.ToInt32(array[1]);

                    domain.DisplayMode = displayMode.EnumValue<DataDisplayModeEnum>();
                    domain.DecimalPlaces = Convert.ToInt32(array[2]);
                    domain.MaxColumnLength = Convert.ToInt32(array[3]);
                    domain.DisplayNamePlaceHolder = array[4];
                }
            }
            catch (Exception) { }

            return domain;
        }
    }
}
