namespace ApiFarmaciaElvis.Entidades.DTOs
{
    public class VendaPorProdutoDTO
    {
        public int? CodigoProduto { get; set; }
        public int? Quantidade { get; set; }

        public VendaPorProdutoDTO()
        {

        }

        public VendaPorProdutoDTO(int? codigoProduto, int? quantidade)
        {
            this.CodigoProduto = codigoProduto;
            this.Quantidade = quantidade;
        }

        public override bool Equals(object obj)
        {
            if (obj == this) return true;

            if (obj == null) return false;

            if (obj.GetType() != this.GetType()) return false;

            VendaPorProdutoDTO other = (VendaPorProdutoDTO)obj;

            return object.Equals(this.CodigoProduto, other.CodigoProduto) &&
                object.Equals(this.Quantidade, other.Quantidade);
        }

        public override int GetHashCode()
        {
            return (this.CodigoProduto ?? 0).GetHashCode() ^
                (this.Quantidade ?? 0).GetHashCode();
        }

        public override string ToString()
        {
            return "{ " + 
                "CodigoProduto = " + StringUtils.NullWordOrToStringValue(CodigoProduto) + ", " +
                "Quantidade = " + StringUtils.NullWordOrToStringValue(Quantidade) + 
                " }";
        }
    }
}
