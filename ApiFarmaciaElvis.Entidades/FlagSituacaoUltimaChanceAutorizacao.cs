using System;

namespace ApiFarmaciaElvis.Entidades
{
    public class FlagSituacaoUltimaChanceAutorizacao
    {
        private FlagSituacaoUltimaChanceAutorizacaoEnum flagSituacaoEnum;
        private string abreviacao;

        public static FlagSituacaoUltimaChanceAutorizacaoEnum AbreviacaoParaFlagSituacaoEnum(string abreviacao)
        {
            switch(abreviacao)
            {
                case "A":
                    return FlagSituacaoUltimaChanceAutorizacaoEnum.Ativo;
                case "F":
                    return FlagSituacaoUltimaChanceAutorizacaoEnum.FinalizadoVendido;
                case "C":
                    return FlagSituacaoUltimaChanceAutorizacaoEnum.Cancelado;
                case "V":
                    return FlagSituacaoUltimaChanceAutorizacaoEnum.Vencido;
                default:
                    throw new ArgumentException("Abreviação desconhecida: " + abreviacao + ".");
            }
        }

        public static string FlagSituacaoEnumParaAbreviacao(FlagSituacaoUltimaChanceAutorizacaoEnum flagSituacaoEnum)
        {
            switch(flagSituacaoEnum)
            {
                case FlagSituacaoUltimaChanceAutorizacaoEnum.Ativo:
                    return "A";
                case FlagSituacaoUltimaChanceAutorizacaoEnum.FinalizadoVendido:
                    return "F";
                case FlagSituacaoUltimaChanceAutorizacaoEnum.Cancelado:
                    return "C";
                case FlagSituacaoUltimaChanceAutorizacaoEnum.Vencido:
                    return "V";
                default:
                    throw new ArgumentException("Enumerado de Flag de Situação desconhecido.");
            }
        }

        public FlagSituacaoUltimaChanceAutorizacaoEnum FlagSituacaoEnum
        {
            get
            {
                return this.flagSituacaoEnum;
            }

            set
            {
                FlagSituacaoUltimaChanceAutorizacaoEnum flagSituacaoEnum = value;
                string abreviacao = FlagSituacaoUltimaChanceAutorizacao.FlagSituacaoEnumParaAbreviacao(flagSituacaoEnum);

                this.flagSituacaoEnum = flagSituacaoEnum;
                this.abreviacao = abreviacao;
            }
        }
        public string Abreviacao
        {
            get
            {
                return this.abreviacao;
            }

            set
            {
                string abreviacao = value;
                FlagSituacaoUltimaChanceAutorizacaoEnum flagSituacaoEnum = FlagSituacaoUltimaChanceAutorizacao.AbreviacaoParaFlagSituacaoEnum(abreviacao);

                this.abreviacao = abreviacao;
                this.flagSituacaoEnum = flagSituacaoEnum;
            }
        }

        public FlagSituacaoUltimaChanceAutorizacao()
        {
            this.FlagSituacaoEnum = FlagSituacaoUltimaChanceAutorizacaoEnum.Ativo;
        }

        public FlagSituacaoUltimaChanceAutorizacao(FlagSituacaoUltimaChanceAutorizacaoEnum flagSituacaoEnum): base()
        {
            this.FlagSituacaoEnum = flagSituacaoEnum;
        }

        public FlagSituacaoUltimaChanceAutorizacao(string abreviacao): base()
        {
            this.Abreviacao = abreviacao;
        }
    }
}