using ApiFarmaciaElvis.Entidades.DTOs;
using ApiFarmaciaElvis.Entidades.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ApiFarmaciaElvis.Repositorios
{
    public class ReportsService : IReportsService
    {
        private readonly string connectionString;
        
        private const string CAMPO_ANO = "Ano";
        private const string CAMPO_MES = "Mes";
        private const string CAMPO_VALOR_VENDIDO = "ValorVendido";
        private const string CAMPO_CATEGORIA = "Categoria";
        private const string CAMPO_CODIGO_PRODUTO = "CodigoProduto";
        private const string CAMPO_QUANTIDADE = "Quantidade";

        public ReportsService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ReportsDTO GetReports()
        {
            const string commandText = "EXEC GetReports";

            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                using (SqlCommand dbCommand = dbConnection.CreateCommand())
                {
                    dbCommand.CommandText = commandText;

                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        var nullableIntConverter = new NullableIntConverterFromObject();
                        var nullableDecimalConverter = new NullableDecimalConverterFromObject();

                        ReportsDTO reportsDTO = new ReportsDTO();

                        var vendaPorPeriodoList = new List<VendaPorPeriodoDTO>();
                        while (reader.Read())
                        {
                            var vendaPorPeriodo = new VendaPorPeriodoDTO();

                            vendaPorPeriodo.Ano = nullableIntConverter.Converter(reader[CAMPO_ANO]);
                            vendaPorPeriodo.Mes = nullableIntConverter.Converter(reader[CAMPO_MES]);
                            vendaPorPeriodo.ValorVendido = nullableDecimalConverter.Converter(reader[CAMPO_VALOR_VENDIDO]);

                            vendaPorPeriodoList.Add(vendaPorPeriodo);
                        }

                        reader.NextResult();
                        
                        var vendaPorCategoriaList = new List<VendaPorCategoriaDTO>();
                        while (reader.Read())
                        {
                            var vendaPorCategoria = new VendaPorCategoriaDTO();

                            vendaPorCategoria.Categoria = Convert.ToString(reader[CAMPO_CATEGORIA]);
                            vendaPorCategoria.ValorVendido = nullableDecimalConverter.Converter(reader[CAMPO_VALOR_VENDIDO]);

                            vendaPorCategoriaList.Add(vendaPorCategoria);
                        }

                        reader.NextResult();

                        var vendaPorProdutoList = new List<VendaPorProdutoDTO>();
                        while(reader.Read())
                        {
                            var vendaPorProduto = new VendaPorProdutoDTO();

                            vendaPorProduto.CodigoProduto = nullableIntConverter.Converter(reader[CAMPO_CODIGO_PRODUTO]);
                            vendaPorProduto.Quantidade = nullableIntConverter.Converter(reader[CAMPO_QUANTIDADE]);

                            vendaPorProdutoList.Add(vendaPorProduto);
                        }

                        var reports = new ReportsDTO
                        {
                            VendasPorPeriodo = vendaPorPeriodoList,
                            VendasPorCategoria = vendaPorCategoriaList,
                            VendasPorProduto = vendaPorProdutoList
                        };

                        return reports;
                    }
                }
            }
        }
    }
}
