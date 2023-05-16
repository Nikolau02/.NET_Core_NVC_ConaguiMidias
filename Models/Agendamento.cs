using System.ComponentModel.DataAnnotations;

namespace TCC_Novo.Models
{
    public class Agendamento
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(150)]
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Negocio { get; set; }
        public string Redes { get; set; }
        public string Servico { get; set; }
    }
}