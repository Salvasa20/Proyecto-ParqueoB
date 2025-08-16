using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Primera.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id_Vehiculo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string NoPlaca { get; set; }

        [Required(ErrorMessage = "El Marca es obligatorio")]
        [StringLength(50)]
        public string Marca { get; set; }

        [Required(ErrorMessage = "El color es obligatorio")]
        [StringLength(30)]
        public string Color { get; set; }

        [Required(ErrorMessage = "El típo de vehiculo es obligatorio")]
        [StringLength(50)]
        public string TipoVehiculo { get; set; }

        [ForeignKey("Cliente")]
        public int Id_Cliente { get; set; }
      //  public Cliente Cliente { get; set; }
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    }
}
