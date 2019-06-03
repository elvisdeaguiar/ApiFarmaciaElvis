using ApiFarmaciaElvis.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFarmarciaElvis.Data
{
    public class ReportsServiceFactory
    {
        public static ReportsService Build(string connectionString)
        {
            if (connectionString == null) throw new ArgumentNullException("connectionString");

            return new ReportsService(connectionString);
        }
    }
}
