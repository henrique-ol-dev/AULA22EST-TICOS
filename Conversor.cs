namespace Aula22
{
    public static class Conversor
    {
        //É pra fazer de real pra euro e de euro pra reais EURO=5,92
        private static float CotacaoDolar = 5.24f;
        public static float RealParaDolar(float valorRS){
            return valorRS / CotacaoDolar;

        }
        
        public static float DolarParaReais(float valorUS){
            return CotacaoDolar * valorUS;
        }
        
        // Euro ta aq embaixo
        

        // Coloca o valor da cotação aq
        private static float CotacaoEuro = 5.92f;
        public static float RealParaEuro(float valorRS){
            return valorRS / CotacaoEuro;

        }
   
        public static float EuroParaReais(float valorUS){
            return CotacaoEuro * valorUS;
        }
    }
}