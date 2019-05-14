using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrudEscaFolDy.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Required (ErrorMessage ="CampoRequerido")]
        [StringLength(50, MinimumLength =3 , ErrorMessage ="el nombre debe tener 3 a 50 caracter ")]
        public string Nombre { get; set; }
        [StringLength (248)]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}
