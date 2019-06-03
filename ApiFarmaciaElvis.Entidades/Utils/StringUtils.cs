using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFarmaciaElvis.Entidades
{
    public class StringUtils
    {
        public static string NullWordOrToStringValue(object obj)
        {
            if (obj == null) return "null";

            return obj.ToString();
        }
    }
}
