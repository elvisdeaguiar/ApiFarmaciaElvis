using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFarmaciaElvis.Entidades.Utils
{
    public interface IConverterFromObject<T>
    {
        T Converter(object obj);
    }
}
