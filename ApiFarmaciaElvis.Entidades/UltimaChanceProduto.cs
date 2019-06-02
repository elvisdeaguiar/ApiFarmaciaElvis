using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFarmaciaElvis.Entidades
{
    public class UltimaChanceProduto
    {
        [Table("ULTIMA_CHANCE_PRODUTO")]
        public class UltimaChanceProduto
        {
            [Key]
            [Column("ULCH_SQ_PRODUTO")]
            public int SequenciaProduto { get; set; }

            [Column("FILI_CD_FILIAL")]
            public int CodigoFilial { get; set; }

            [Column("PRME_CD_PRODUTO")]
            public int CodigoProduto { get; set; }

            [Column("ULCH_QUANTIDADE")]
            public int Quantidade { get; set; }

            [MinLength(1, ErrorMessage = "O Lote deve possuir pelo menos {0} caracter(es).")]
            [MaxLength(50, ErrorMessage = "O Lote deve possuir no máximo {0} caracter(es).")]
            [Required(AllowEmptyStrings = false)]
            [Column("ULCH_LOTE")]
            public string Lote { get; set; }

            [Required(ErrorMessage = "Data de Vencimento é obrigatória.")]
            [Column("ULCH_DT_VENCIMENTO")]
            public DateTime DataVencimento { get; set; }

            [Required(ErrorMessage = "Flag de Autorizado é obrigatória.")]
            [Column("ULCH_FL_AUTORIZADO")]
            public SimNaoAbreviado FlagAutorizado { get; set; }

            public UltimaChanceProduto()
            {
                this.FlagAutorizado = SimNaoAbreviado.N;
            }

            public override bool Equals(object obj)
            {
                if (this == obj) return true;

                if (obj == null) return false;

                if (obj.GetType() != this.GetType())
                {
                    return false;
                }

                UltimaChanceProduto other = (UltimaChanceProduto)obj;

                return (this.SequenciaProduto == other.SequenciaProduto);
            }

            public override int GetHashCode()
            {
                return this.SequenciaProduto.GetHashCode();
            }

            public override string ToString()
            {
                return "{ " +
                    "SequenciaProduto = " + SequenciaProduto + ", " +
                    "CodigoFilial = " + CodigoFilial + ", " +
                    "CodigoProduto = " + CodigoProduto + ", " +
                    "Quantidade = " + Quantidade + ", " +
                    "Lote = " + Lote + ", " +
                    "DataVencimento = " + DataVencimento + ", " +
                    "FlagAutorizado = " + FlagAutorizado +
                    " }";
            }
        }
    }
}
