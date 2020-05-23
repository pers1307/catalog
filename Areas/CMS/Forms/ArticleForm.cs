using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Catalog.Entities;

namespace Catalog.Areas.CMS.Forms
{
    public class ArticleForm
    {
        public ArticleForm()
        {
            Name = "";
            Parent = 0;
            Description = "";
        }
        
        public ArticleForm(Article article)
        {
            Name = article.Name;
            Parent = article.Parent;
            Description = article.Description;
        }
                
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

        public Article GetAsArticle()
        {
            return new Article()
            {
                Name = Name,
                Parent = Parent,
                Description = Description
            };
        }
    }
}