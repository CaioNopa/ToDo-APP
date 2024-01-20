using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyToDoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Title { get; set; }

        [DisplayName("Concluído")]
        public bool Done { get; set; }

        [DisplayName("Criado Em")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DisplayName("Última Atualização")]
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        
        [DisplayName("Usuário")]
        public string? User { get; set; }
    }
}

