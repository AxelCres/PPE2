using System.ComponentModel.DataAnnotations;

namespace Blaguotech.Areas.Models
{
    public class ArticleModel
    {
        [Key, Range(1,1000)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Le champs est requis")]  
        public string Titre { get; set; }
        [Required(ErrorMessage = "Le champs est requis")]
        public string Auteur { get; set; }
        [Range(0, 5)]
        public decimal Note { get; set; }
    }
}
