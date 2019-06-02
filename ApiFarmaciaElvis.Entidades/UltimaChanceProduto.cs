using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFarmaciaElvis.Entidades
{   
    [Table("ULTIMA_CHANCE_PRODUTO")]
    public class UltimaChanceProduto
    {
        private SimNao flagAutorizado = new SimNao();
        private int? quantidade;

        [Key]
        [Column("ULCH_SQ_PRODUTO")]
        [Display(Name = "Sequência do Produto")]
        public int? SequenciaProduto { get; set; }
                        
        [Required(ErrorMessage = "Código da Filial é obrigatório.")]
        [Column("FILI_CD_FILIAL")]
        [Display(Name = "Código da Filial")]
        public int? CodigoFilial { get; set; }

        [Required(ErrorMessage = "Código do Produto é obrigatório.")]
        [Column("PRME_CD_PRODUTO")]
        [Display(Name = "Código do Produto")]
        public int? CodigoProduto { get; set; }

        [Required(ErrorMessage = "Quantidade é obrigatória.")]
        [Column("ULCH_QUANTIDADE")]
        [Display(Name = "Quantidade")]
        public int? Quantidade
        {
            get
            {
                return this.quantidade;
            }

            set
            {
                if (value != null && value <= 0)
                {
                    throw new ArgumentException("Quantidade deve ser pelo menos 1.");
                }

                this.quantidade = value;
            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Lote é obrigatório.")]
        [MinLength(1, ErrorMessage = "O Lote deve possuir pelo menos {0} caracter(es).")]
        [MaxLength(50, ErrorMessage = "O Lote deve possuir no máximo {0} caracter(es).")]            
        [Column("ULCH_LOTE")]
        [Display(Name = "Lote")]
        public string Lote { get; set; }

        [Required(ErrorMessage = "Data de Vencimento é obrigatória.")]
        [Column("ULCH_DT_VENCIMENTO")]
        [Display(Name = "Data de Vencimento")]
        public DateTime? DataVencimento { get; set; }

        [NotMapped]
        public SimNaoEnum FlagAutorizadoEnum { get { return this.flagAutorizado.SimNaoEnum; } set { this.flagAutorizado.SimNaoEnum = value; } }

        [Required(ErrorMessage = "Flag Autorizado é obrigatória.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Flag Autorizado deve ter 1 caracter.")]
        [Column("ULCH_FL_AUTORIZADO")]
        [Display(Name = "Autorizado")]
        public string FlagAutorizado { get { return this.flagAutorizado.Abreviacao; } set { this.flagAutorizado.Abreviacao = value; } }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;

            if (obj == null) return false;

            if (obj.GetType() != this.GetType()) return false;

            UltimaChanceProduto other = (UltimaChanceProduto)obj;

            return object.Equals(this.SequenciaProduto, other.SequenciaProduto);
        }

        public override int GetHashCode()
        {
            return (this.SequenciaProduto ?? 0).GetHashCode();
        }

        public override string ToString()
        {
            return "{ " + 
                "SequenciaProduto = " + StringUtils.NullWordOrToStringValue(SequenciaProduto) + ", " +
                "CodigoFilial = " + StringUtils.NullWordOrToStringValue(CodigoFilial) + ", " +
                "CodigoProduto = " + StringUtils.NullWordOrToStringValue(CodigoProduto) + ", " +
                "Quantidade = " + StringUtils.NullWordOrToStringValue(Quantidade) + ", " +
                "Lote = " + StringUtils.NullWordOrToStringValue(Lote) + ", " +
                "DataVencimento = " + StringUtils.NullWordOrToStringValue(DataVencimento) + ", " +
                "FlagAutorizadoEnum = " + StringUtils.NullWordOrToStringValue(FlagAutorizadoEnum) + ", " +
                "FlagAutorizado = " + StringUtils.NullWordOrToStringValue(FlagAutorizado) + 
                " }";

        }
    }
}