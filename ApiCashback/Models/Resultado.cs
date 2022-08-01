namespace ApiCashback.Models
{
    public class Resultado
    {
        public string? Acao { get; set; }
        private List<string> _Inconsistencias = new List<string>();

        public bool Sucesso
        {
            get { return _Inconsistencias == null || Inconsistencias.Count == 0; }
        }

        public List<string> Inconsistencias
        {
            get { return _Inconsistencias; }
        }
    }
}
