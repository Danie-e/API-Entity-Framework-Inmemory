namespace API_Entity_Framework_Inmemory.Models
{
    public class Usuario
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int codigoDePessoa { get; set; }
        public string lembreteDeSenha { get; set; }
        public int idade { get; set; }
        public string sexo { get; set; }
    }
}
