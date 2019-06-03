using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFarmaciaElvis.Entidades.DTOs
{
    public class VendaPorCategoriaDTO
    {
        public string Categoria { get; set; }
        public decimal? ValorVendido { get; set; }

        public VendaPorCategoriaDTO()
        {

        }

        public VendaPorCategoriaDTO(string categoria, decimal? valorVendido)
        {
            this.Categoria = categoria;
            this.ValorVendido = valorVendido;
        }

        public override bool Equals(object obj)
        {
            if (obj == this) return true;

            if (obj == null) return false;

            if (obj.GetType() != this.GetType()) return false;

            VendaPorCategoriaDTO other = (VendaPorCategoriaDTO)obj;

            return (string.Equals(this.Categoria, other.Categoria, StringComparison.OrdinalIgnoreCase) &&
                object.Equals(this.ValorVendido, other.ValorVendido));
        }

        public override int GetHashCode()
        {
            return (this.Categoria ?? "").ToLower().GetHashCode() ^
                (this.ValorVendido ?? 0).GetHashCode();
        }

        public override string ToString()
        {
            return "{ " + 
                "Categoria = " + StringUtils.NullWordOrToStringValue(Categoria) + ", " +
                "ValorVendido = " + StringUtils.NullWordOrToStringValue(ValorVendido) + 
                " }";
        }
    }
}