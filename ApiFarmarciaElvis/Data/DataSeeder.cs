using ApiFarmaciaElvis.Entidades;
using ApiFarmarciaElvis.Repositorios;
using System;
using System.Linq;

namespace ApiFarmarciaElvis.Data
{
    public class DataSeeder
    {
        public static void Seed(ApiFarmarciaElvisContext context)
        {
            if (context.UltimaChanceProduto.Any()) return;

            UltimaChanceProduto ultimaChanceProduto1 = new UltimaChanceProduto
            {
                CodigoFilial = 1,
                CodigoProduto = 1,
                DataVencimento = new DateTime(2019, 6, 11),
                FlagAutorizadoEnum = SimNaoEnum.Sim,
                Lote = "1234",
                Quantidade = 2
            };

            UltimaChanceProduto ultimaChanceProduto2 = new UltimaChanceProduto
            {
                CodigoFilial = 1,
                CodigoProduto = 2,
                DataVencimento = new DateTime(2019, 6, 12),
                FlagAutorizadoEnum = SimNaoEnum.Sim,
                Lote = "2345",
                Quantidade = 4
            };

            UltimaChanceProduto ultimaChanceProduto3 = new UltimaChanceProduto
            {
                CodigoFilial = 1,
                CodigoProduto = 3,
                DataVencimento = new DateTime(2019, 6, 13),
                FlagAutorizadoEnum = SimNaoEnum.Sim,
                Lote = "3456",
                Quantidade = 2
            };

            context.UltimaChanceProduto.AddRange(new[] 
            {
                ultimaChanceProduto1,
                ultimaChanceProduto2,
                ultimaChanceProduto3
            });
            context.SaveChanges();

            if (context.UltimaChanceAutorizacao.Any()) return;

            ultimaChanceProduto1 = context.UltimaChanceProduto.FirstOrDefault(ucp => ucp.CodigoProduto == 1);
            ultimaChanceProduto2 = context.UltimaChanceProduto.FirstOrDefault(ucp => ucp.CodigoProduto == 2);
            ultimaChanceProduto3 = context.UltimaChanceProduto.FirstOrDefault(ucp => ucp.CodigoProduto == 3);

            var ultimaChanceAutorizacao1 = new UltimaChanceAutorizacao
            {
                UltimaChanceProduto = ultimaChanceProduto1,
                CodigoBarras = "1",
                DataVenda = DateTime.Now.AddDays(-1),
                FlagSituacaoEnum = FlagSituacaoUltimaChanceAutorizacaoEnum.FinalizadoVendido,
                FlagTipoProdutoEnum = FlagTipoProdutoEnum.Medicamento,
                MenorPreco = 10.11m,
                PercentualDesconto = null
            };

            var ultimaChanceAutorizacao2 = new UltimaChanceAutorizacao
            {
                UltimaChanceProduto = ultimaChanceProduto1,
                CodigoBarras = "2",
                DataVenda = DateTime.Now.AddDays(-1),
                FlagSituacaoEnum = FlagSituacaoUltimaChanceAutorizacaoEnum.FinalizadoVendido,
                FlagTipoProdutoEnum = FlagTipoProdutoEnum.Medicamento,
                MenorPreco = 10.11m,
                PercentualDesconto = null
            };

            var ultimaChanceAutorizacao3 = new UltimaChanceAutorizacao
            {
                UltimaChanceProduto = ultimaChanceProduto2,
                CodigoBarras = "3",
                DataVenda = DateTime.Now,
                FlagSituacaoEnum = FlagSituacaoUltimaChanceAutorizacaoEnum.FinalizadoVendido,
                FlagTipoProdutoEnum = FlagTipoProdutoEnum.NaoMedicamento,
                MenorPreco = 21.79m,
                PercentualDesconto = 5m
            };

            var ultimaChanceAutorizacao4 = new UltimaChanceAutorizacao
            {
                UltimaChanceProduto = ultimaChanceProduto2,
                CodigoBarras = "4",
                DataVenda = DateTime.Now,
                FlagSituacaoEnum = FlagSituacaoUltimaChanceAutorizacaoEnum.FinalizadoVendido,
                FlagTipoProdutoEnum = FlagTipoProdutoEnum.NaoMedicamento,
                MenorPreco = 21.79m,
                PercentualDesconto = 5m
            };

            var ultimaChanceAutorizacao5 = new UltimaChanceAutorizacao
            {
                UltimaChanceProduto = ultimaChanceProduto2,
                CodigoBarras = "5",
                DataVenda = DateTime.Now,
                FlagSituacaoEnum = FlagSituacaoUltimaChanceAutorizacaoEnum.FinalizadoVendido,
                FlagTipoProdutoEnum = FlagTipoProdutoEnum.NaoMedicamento,
                MenorPreco = 21.79m,
                PercentualDesconto = 5m
            };
            
            var ultimaChanceAutorizacao6 = new UltimaChanceAutorizacao
            {
                UltimaChanceProduto = ultimaChanceProduto2,
                CodigoBarras = "6",
                DataVenda = DateTime.Now,
                FlagSituacaoEnum = FlagSituacaoUltimaChanceAutorizacaoEnum.FinalizadoVendido,
                FlagTipoProdutoEnum = FlagTipoProdutoEnum.NaoMedicamento,
                MenorPreco = 21.79m,
                PercentualDesconto = 5m
            };
            
            var ultimaChanceAutorizacao7 = new UltimaChanceAutorizacao
            {
                UltimaChanceProduto = ultimaChanceProduto3,
                CodigoBarras = "7",
                DataVenda = DateTime.Now.AddDays(1),
                FlagSituacaoEnum = FlagSituacaoUltimaChanceAutorizacaoEnum.FinalizadoVendido,
                FlagTipoProdutoEnum = FlagTipoProdutoEnum.NaoMedicamentoAlimento,
                MenorPreco = 97.48m,
                PercentualDesconto = 15m
            };
            
            var ultimaChanceAutorizacao8 = new UltimaChanceAutorizacao
            {
                UltimaChanceProduto = ultimaChanceProduto3,
                CodigoBarras = "8",
                DataVenda = null,
                FlagSituacaoEnum = FlagSituacaoUltimaChanceAutorizacaoEnum.Vencido,
                FlagTipoProdutoEnum = FlagTipoProdutoEnum.NaoMedicamentoAlimento,
                MenorPreco = 97.48m,
                PercentualDesconto = 15m
            };

            context.UltimaChanceAutorizacao.AddRange(new[]
            {
                ultimaChanceAutorizacao1, ultimaChanceAutorizacao2, ultimaChanceAutorizacao3, ultimaChanceAutorizacao4,
                ultimaChanceAutorizacao5, ultimaChanceAutorizacao6, ultimaChanceAutorizacao7, ultimaChanceAutorizacao8
            });
            context.SaveChanges();
        }
    }
}