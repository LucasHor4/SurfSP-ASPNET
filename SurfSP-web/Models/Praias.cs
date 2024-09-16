namespace SurfSP_web.Models
{
    public class Praias
    {
        public int idPraia {  get; set; }
        public string nomePraia { get; set; }
        public string descricaoPraia { get; set; }
        public string imgPraia { get; set; }

        public Praias(int idPraia, string nomePraia, string descricaoPraia, string imgPraia)
        {
            idPraia = 0;
            nomePraia = string.Empty;
            descricaoPraia = string.Empty;
            imgPraia = string.Empty;
        }
    }
}
