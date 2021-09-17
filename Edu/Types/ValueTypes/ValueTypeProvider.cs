using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Types.ValueTypes
{
    public class ValueTypeProvider
    {
        public ValueTypeProvider()
        { 
        }

        public string GetAllValueTypesInformation()
        {
            var valueTypesInformation = new StringBuilder();

            valueTypesInformation.AppendLine(GetBooleanTypeInformation());
            valueTypesInformation.AppendLine(GetByteTypeInformation());
            valueTypesInformation.AppendLine(GetSByteTypeInformation());
            valueTypesInformation.AppendLine(GetCharTypeInformation());
            valueTypesInformation.AppendLine(GetDecimalTypeInformation());
            valueTypesInformation.AppendLine(GetDoubleTypeInformation());
            valueTypesInformation.AppendLine(GetSingleTypeInformation());
            valueTypesInformation.AppendLine(GetInt16TypeInformation());
            valueTypesInformation.AppendLine(GetUInt16TypeInformation());
            valueTypesInformation.AppendLine(GetInt32TypeInformation());
            valueTypesInformation.AppendLine(GetUInt32TypeInformation());
            valueTypesInformation.AppendLine(GetIntPtrTypeInformation());
            valueTypesInformation.AppendLine(GetUIntPtrTypeInformation());
            valueTypesInformation.AppendLine(GetInt64TypeInformation());
            valueTypesInformation.AppendLine(GetUInt64TypeInformation());

            return valueTypesInformation.ToString();
        }

        public string GetBooleanTypeInformation()
        {
            return $"bool: [{true}, {false}]";
        }

        public string GetByteTypeInformation() 
        {
            return $"byte: [{byte.MinValue}, {byte.MaxValue}]";
        }

        public string GetSByteTypeInformation()
        {
            return $"sbyte: [{sbyte.MinValue}, {sbyte.MaxValue}]";
        }

        public string GetCharTypeInformation()
        {
            return $"char: [{char.MinValue}, {char.MaxValue}]";
        }

        public string GetDecimalTypeInformation()
        {
            return $"decimal: [{decimal.MinValue}, {decimal.MaxValue}]";
        }

        public string GetDoubleTypeInformation()
        {
            return $"double: [{double.MinValue}, {double.MaxValue}]";
        }

        public string GetSingleTypeInformation()
        {
            return $"float: [{float.MinValue}, {float.MaxValue}]";
        }

        public string GetInt16TypeInformation()
        {
            return $"short: [{short.MinValue}, {short.MaxValue}]";
        }

        public string GetUInt16TypeInformation()
        {
            return $"ushort: [{short.MinValue}, {short.MaxValue}]";
        }

        public string GetInt32TypeInformation()
        {
            return $"int: [{int.MinValue}, {int.MaxValue}]";
        }

        public string GetUInt32TypeInformation()
        {
            return $"uint: [{uint.MinValue}, {uint.MaxValue}]";
        }

        public string GetIntPtrTypeInformation() 
        {
            return $"nint: [{nint.MinValue}, {nint.MaxValue}]";
        }

        public string GetUIntPtrTypeInformation()
        {
            return $"nuint: [{nuint.MinValue}, {nuint.MaxValue}]";
        }

        public string GetInt64TypeInformation()
        {
            return $"long: [{long.MinValue}, {long.MaxValue}]";
        }

        public string GetUInt64TypeInformation()
        {
            return $"long: [{ulong.MinValue}, {ulong.MaxValue}]";
        }
    }
}
