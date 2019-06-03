using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFarmaciaElvis.Entidades.Utils
{
    public class NullableIntConverterFromObject : IConverterFromObject<int?>
    {
        public int? Converter(object obj)
        {
            return obj == null ? (int?)null : Convert.ToInt32(obj);
        }
    }
}
