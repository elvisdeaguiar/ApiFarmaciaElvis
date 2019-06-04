using ApiFarmaciaElvis.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFarmarciaElvis.Repositorios
{
    public class ReportsServiceFactory
    {
        private const string PARAM_CONNECTION_STRING = "connectionString";

        public static ReportsService Build(string connectionString)
        {
            if (connectionString == null) throw new ArgumentNullException(PARAM_CONNECTION_STRING);

            return new ReportsService(connectionString);
        }
    }
}
