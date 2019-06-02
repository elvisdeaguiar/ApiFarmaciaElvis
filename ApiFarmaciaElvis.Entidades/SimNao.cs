using System;

namespace ApiFarmaciaElvis.Entidades
{
    public class SimNao
    {
        private string abreviacao;
        private SimNaoEnum simNaoEnum;

        public static string SimNaoEnumParaAbreviacao(SimNaoEnum simNaoEnum)
        {
            switch(simNaoEnum)
            {
                case SimNaoEnum.Nao:
                    return "N";

                case SimNaoEnum.Sim:
                    return "S";

                default:
                    throw new ArgumentException("Enumerado Sim/Não desconhecido.");
            }
        }

        public static SimNaoEnum AbreviacaoParaSimNaoEnum(string abreviacao)
        {
            if (abreviacao == "S") return SimNaoEnum.Sim;

            if (abreviacao == "N") return SimNaoEnum.Nao;

            throw new ArgumentException("Abreviação Sim/Não desconhecida: " + abreviacao + ".");
        }

        public string Abreviacao
        {
            get
            {
                return this.abreviacao;                
            }

            set
            {
                string candidatoAAbreviacao = value;
                SimNaoEnum simNaoEnum = SimNao.AbreviacaoParaSimNaoEnum(candidatoAAbreviacao);
                string abreviacao = candidatoAAbreviacao;

                this.abreviacao = abreviacao;
                this.simNaoEnum = SimNaoEnum;
            }
        }
        
        public SimNaoEnum SimNaoEnum
        {
            get
            {
                return this.simNaoEnum;
            }

            set
            {
                SimNaoEnum simNaoEnum = value;
                string abreviacao = SimNao.SimNaoEnumParaAbreviacao(simNaoEnum);

                this.simNaoEnum = simNaoEnum;
                this.abreviacao = abreviacao;
            }
        }

        public SimNao()
        {
            this.SimNaoEnum = SimNaoEnum.Nao;
        }

        public SimNao(SimNaoEnum simNaoEnum): base()
        {
            this.SimNaoEnum = simNaoEnum;
        }

        public SimNao(string abreviacao): base()
        {
            this.Abreviacao = abreviacao;
        }
    }
}
