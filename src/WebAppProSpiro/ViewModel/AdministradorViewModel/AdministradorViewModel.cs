using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProSpiro.ViewModel.AdministradorViewModel
{
    [Table("administrador")]
    public class AdministradorViewModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int id_pessoa { get; set; }

        public string senha { get; set; }

        public string remember_token { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Display(Name = "Estatura (Centimetros)")]
        public decimal Estatura { get; set; }

        [Required]
        [Display(Name = "Peso (Kilogramas)")]
        public decimal Peso { get; set; }

        [Required]
        [Display(Name = "IMC")]
        public decimal Imc { get; set; }

        [Required]
        [Display(Name = "Gênero")]
        public int Genero { get; set; }

        [Required]
        [Display(Name = "Idade")]
        public int Idade { get; set; }

        [Required]
        [Display(Name = "Fumante")]
        public int Fumante { get; set; }

        [Required]
        [Display(Name = "Ex-Fumante")]
        public int ExFumante { get; set; }

        [Display(Name = "Quando parou de fumar")]
       // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime QndParouFumar { get; set; }

        [Required]
        [Display(Name = "Convenio")]
        public string Convenio { get; set; }
    }
}
