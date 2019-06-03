using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFarmaciaElvis.Entidades.DTOs
{
    public class ReportsDTO
    {
        public IList<VendaPorPeriodoDTO> VendasPorPeriodo { get; set; }
        public IList<VendaPorCategoriaDTO> VendasPorCategoria { get; set; }
        public IList<VendaPorProdutoDTO> VendasPorProduto { get; set; }
    }
}
