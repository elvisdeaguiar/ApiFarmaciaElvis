using System;

namespace ApiFarmaciaElvis.Entidades.Utils
{
    public class NullableDecimalConverterFromObject : IConverterFromObject<decimal?>
    {
        public decimal? Converter(object obj)
        {
            return obj == null ? (decimal?)null : Convert.ToDecimal(obj);
        }
    }
}
