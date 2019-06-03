namespace ApiFarmaciaElvis.Entidades.DTOs
{
    public class VendaPorPeriodoDTO
    {
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public decimal? ValorVendido { get; set; }

        public VendaPorPeriodoDTO()
        {

        }

        public VendaPorPeriodoDTO(int? ano, int? mes, decimal? valorVendido)
        {
            this.Ano = ano;
            this.Mes = mes;
            this.ValorVendido = valorVendido;
        }

        public override bool Equals(object obj)
        {
            if (obj == this) return true;

            if (obj == null) return false;

            if (obj.GetType() != this.GetType()) return false;

            VendaPorPeriodoDTO other = (VendaPorPeriodoDTO)obj;

            return (object.Equals(other.Ano, this.Ano) &&
                object.Equals(other.Mes, this.Mes) &&
                object.Equals(other.ValorVendido, this.ValorVendido));
        }

        public override int GetHashCode()
        {
            return (this.Ano ?? 0).GetHashCode() ^
                (this.Mes ?? 0).GetHashCode() ^
                (this.ValorVendido ?? 0).GetHashCode();
        }

        public override string ToString()
        {
            return "{ " + 
                "Ano = " + StringUtils.NullWordOrToStringValue(Ano) + ", " +
                "Mes = " + StringUtils.NullWordOrToStringValue(Mes) + ", " +
                "ValorVendido = " + StringUtils.NullWordOrToStringValue(ValorVendido) + 
                " }";
        }
    }
}
