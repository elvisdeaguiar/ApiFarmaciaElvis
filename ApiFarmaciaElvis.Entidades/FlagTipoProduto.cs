using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFarmaciaElvis.Entidades
{
    public class FlagTipoProduto
    {
        private FlagTipoProdutoEnum flagTipoProdutoEnum;

        private string abreviacao;

        public static string FlagTipoProdutoEnumParaAbreviacao(FlagTipoProdutoEnum flagTipoProdutoEnum)
        {
            switch(flagTipoProdutoEnum)
            {
                case FlagTipoProdutoEnum.Medicamento:
                    return "M";
                case FlagTipoProdutoEnum.NaoMedicamento:
                    return "NM";
                case FlagTipoProdutoEnum.NaoMedicamentoAlimento:
                    return "NMA";
                default:
                    throw new ArgumentException("Enumerado da Flag de Tipo de Produto desconhecido.");
            }
        }

        public static FlagTipoProdutoEnum AbreviacaoParaFlagTipoProdutoEnum(string abreviacao)
        {
            switch(abreviacao)
            {
                case "M":
                    return FlagTipoProdutoEnum.Medicamento;
                case "NM":
                    return FlagTipoProdutoEnum.NaoMedicamento;
                case "NMA":
                    return FlagTipoProdutoEnum.NaoMedicamentoAlimento;
                default:
                    throw new ArgumentException("Abreviação de Tipo de Produto desconhecida: " + abreviacao + ".");
            }
        }

        public FlagTipoProdutoEnum FlagTipoProdutoEnum
        {
            get
            {
                return this.flagTipoProdutoEnum;
            }

            set
            {
                FlagTipoProdutoEnum flagTipoProdutoEnum = value;
                string abreviacao = FlagTipoProduto.FlagTipoProdutoEnumParaAbreviacao(flagTipoProdutoEnum);

                this.flagTipoProdutoEnum = flagTipoProdutoEnum;
                this.abreviacao = abreviacao;
            }
        }

        public string Abreviacao
        {
            get
            {
                return this. abreviacao;
            }

            set
            {
                string candidataAAbreviacao = value;
                FlagTipoProdutoEnum flagTipoProdutoEnum = FlagTipoProduto.AbreviacaoParaFlagTipoProdutoEnum(candidataAAbreviacao);
                string abreviacao = candidataAAbreviacao;

                this.abreviacao = abreviacao;
                this.flagTipoProdutoEnum = flagTipoProdutoEnum;
            }
        }

        public FlagTipoProduto()
        {
            this.FlagTipoProdutoEnum = FlagTipoProdutoEnum.Medicamento;
        }

        public FlagTipoProduto(FlagTipoProdutoEnum flagTipoProdutoEnum): base()
        {
            this.FlagTipoProdutoEnum = flagTipoProdutoEnum;
        }

        public FlagTipoProduto(string abreviacao): base()
        {
            this.Abreviacao = abreviacao;
        }
    }
}
