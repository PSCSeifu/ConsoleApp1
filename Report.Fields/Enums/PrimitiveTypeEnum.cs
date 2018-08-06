using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.eReport.Domain
{
    public enum PrimitiveTypeEnum
    {
        None,
        Int,    //Signed 32-bit integer [-2,147,483,648 to 2,147,483,647]

        String,
        DateTime,

        Boolean,
        Double,
        Decimal,
        Byte,   //Unsigned    [8-bit integer 0 to 255]
        Sbyte,  //Signed     [8-bit integer -128 to 127]
        Char,
        Single,
        UInt32, //          0 to [4,294,967,295]
        UInt16, //ushort    [0 to 65,535]
        Int16,  //short     [-32,768 to 32,767]
        UInt64, //ulong     [0 to 18,446,744,073,709,551,615]
        Int64,  //Long      [-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807]

        NullableInt,
        NullableDateTime,
        NullableBool,
        NullableDouble,
        NullableDecimal,
    }
}
