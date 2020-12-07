namespace AulaPOOCelular.classe
{
    public class Celular
    {
        public string cor;
        public string tamanho;
        public bool energia;

        public bool Ligar()
        {
            return energia = true;
        }
        public bool Desligar()
        {
            return energia = false;
        }
        public string FazerLigação()
        {
            return "Discando...";
        }
        public string EnviandoMensagem()
        {
            return "Mensagem enviada";
        }

    }
}