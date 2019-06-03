using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFarmaciaElvis.Entidades
{
    [Table("ULTIMA_CHANCE_AUTORIZACAO")]
    public class UltimaChanceAutorizacao
    {
        private FlagSituacaoUltimaChanceAutorizacao flagSituacao = new FlagSituacaoUltimaChanceAutorizacao();

        private decimal? percentualDesconto;

        private FlagTipoProduto flagTipoProduto = new FlagTipoProduto();

        [Key]
        [Column("ULCH_SQ_AUTORIZACAO")]
        [Display(Name = "Sequência da Autorização")]
        public int? SequenciaAutorizacao { get; set; }

        [Required(ErrorMessage = "Última Chance do Produto é obrigatória.")]
        [ForeignKey("ULCH_SQ_PRODUTO")]
        [Display(Name = "Última Chance do Produto")]
        public virtual UltimaChanceProduto UltimaChanceProduto { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Código de Barras é obrigatório.")]
        [MinLength(1, ErrorMessage = "Código de Barras deve ter pelo menos {0} caracter(es).")]
        [MaxLength(20, ErrorMessage = "Código de Barras deve ter no máximo {0} caracter(es).")]
        [Column("ULCH_CD_BARRAS")]
        [Display(Name = "Código de Barras")]
        public string CodigoBarras { get; set; }

        [NotMapped]        
        public FlagSituacaoUltimaChanceAutorizacaoEnum FlagSituacaoEnum
        {
            get
            {
                return this.flagSituacao.FlagSituacaoEnum;
            }

            set
            {
                this.flagSituacao.FlagSituacaoEnum = value;
            }
        }

        [Required(ErrorMessage = "Situação da Última Chance de Autorização é obrigatória.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Flag de Situação deve ter 1 caracter.")]
        [Column("ULCH_FL_SITUACAO")]
        [Display(Name = "Situação")]
        public string FlagSituacao
        {
            get
            {
                return this.flagSituacao.Abreviacao;
            }

            set
            {
                this.flagSituacao.Abreviacao = value;
            }
        }

        [Required(ErrorMessage = "Data de Venda é obrigatória.")]
        [Column("ULCH_DH_VENDA")]
        [Display(Name = "Data de Venda")]
        public DateTime? DataVenda { get; set; }

        [Required(ErrorMessage = "Menor Preço é obrigatório.")]
        [Column("ULCH_MENOR_PRECO")]
        [Display(Name = "Menor Preço")]
        public decimal? MenorPreco { get; set; }

        [Required(ErrorMessage = "Preço de Venda é obrigatório.")]
        [Column("ULCH_PRECO_VENDA")]
        [Display(Name = "Preço de Venda")]
        public decimal? PrecoVenda { get; set; }
                
        [Column("ULCH_PERCENTUAL_DESCONTO")]
        [Display(Name = "Percentual de Desconto")]
        public decimal? PercentualDesconto { get; set; }

        [NotMapped]
        public FlagTipoProdutoEnum FlagTipoProdutoEnum
        {
            get { return this.flagTipoProduto.FlagTipoProdutoEnum; }
            set { this.flagTipoProduto.FlagTipoProdutoEnum = value; }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "")]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Flag de Tipo de Produto deve ter entre 1 e 3 caracteres.")]
        [Column("ULCH_FL_TIPO_PRODUTO")]
        [Display(Name = "Tipo de Produto")]
        public string FlagTipoProduto
        {
            get
            {
                return this.flagTipoProduto.Abreviacao;
            }

            set
            {
                this.flagTipoProduto.Abreviacao = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;

            if (obj == null) return false;

            if (this.GetType() != obj.GetType()) return false;

            UltimaChanceAutorizacao other = (UltimaChanceAutorizacao)obj;

            return object.Equals(this.SequenciaAutorizacao, other.SequenciaAutorizacao);
        }

        public override int GetHashCode()
        {
            return (this.SequenciaAutorizacao ?? 0).GetHashCode();
        }

        public override string ToString()
        {
            return "{ " + 
                "SequenciaAutorizacao = " + StringUtils.NullWordOrToStringValue(SequenciaAutorizacao) + ", " +
                "UltimaChanceProduto = " + StringUtils.NullWordOrToStringValue(UltimaChanceProduto) + ", " +
                "CodigoBarras = " + StringUtils.NullWordOrToStringValue(CodigoBarras) + ", " +
                "FlagSituacaoEnum = " + StringUtils.NullWordOrToStringValue(FlagSituacaoEnum) + ", " +
                "FlagSituacao = " + StringUtils.NullWordOrToStringValue(FlagSituacao) + ", " +
                "DataVenda = " + StringUtils.NullWordOrToStringValue(DataVenda) + ", " +
                "MenorPreco = " + StringUtils.NullWordOrToStringValue(MenorPreco) + ", " +
                "PrecoVenda = " + StringUtils.NullWordOrToStringValue(PrecoVenda) + ", " +
                "PercentualDesconto = " + StringUtils.NullWordOrToStringValue(PercentualDesconto) + ", " +
                "FlagTipoProdutoEnum = " + StringUtils.NullWordOrToStringValue(FlagTipoProdutoEnum) + ", " +
                "FlagTipoProduto = " + StringUtils.NullWordOrToStringValue(FlagTipoProduto) + 
                " }";
        }
    }
}