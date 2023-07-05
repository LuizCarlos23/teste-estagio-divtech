using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud.Models {
    public enum Specialty : int {
        Commerce = 0,
        Service = 1,
        Industy = 2 
    }

    public class Supplier {
        [Key]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "É permitido no máximo 100 caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [MinLength(14, ErrorMessage = "É permitido no mínimo 14 caracteres"), MaxLength(14, ErrorMessage = "É permitido no máximo 14 caracteres")]
        [RegularExpression(@"^\d+$", ErrorMessage = "É permitido apenas números")]
        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }

        [Display(Name = "Especialidade")]
        public Specialty Specialty { get; set; }

        [MinLength(8, ErrorMessage = "É permitido no mínimo 8 caracteres"), MaxLength(8, ErrorMessage = "É permitido no máximo 8 caracteres")]
        [RegularExpression(@"^\d+$", ErrorMessage = "É permitido apenas números")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [MaxLength(255, ErrorMessage = "É permitido no máximo 255 caracteres")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }
    }
}