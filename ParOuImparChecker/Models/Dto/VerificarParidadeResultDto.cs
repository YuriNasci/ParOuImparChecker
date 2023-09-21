namespace ParOuImparChecker.Models.Dto
{
    public class VerificarParidadeResultDto
    {
        public VerificarParidadeResultDto()
        {
        }

        public string Mensagem { get; set; }
        public bool Vitoria { get; set; }
        public int NumeroEntrada { get; set; }
        public string Aposta { get; set; }
        public int NumeroAleatorioGerado { get; set; }
        public int Soma { get; set; }
    }
}