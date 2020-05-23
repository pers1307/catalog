using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Catalog.Areas.CMS.Forms
{
    public class ArticleForm
    {
        [Display(Name ="Название категории")]
        [Required(ErrorMessage = "Это поле является обязательным")]
        public string Name { get; set; }
        
        [Display(Name ="Родительская категория")]
        [Required(ErrorMessage = "Это поле является обязательным")]
        public int Parent { get; set; }
        
        [Display(Name ="Описание")]
        [Required(ErrorMessage = "Это поле является обязательным")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }
    }
}