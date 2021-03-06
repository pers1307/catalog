using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;
using Catalog.Entities;

namespace Catalog.Areas.CMS.Forms
{
    public class ProductForm
    {
        public ProductForm()
        {
            Name = "";
            Price = 0;
            Description = "";
        }
        
        public ProductForm(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Description = product.Description;
            ImageOnePath = product.ImageOne;
            ImageTwoPath = product.ImageTwo;
            ImageTreePath = product.ImageThree;
        }

        [Display(Name ="Название продукта")]
        [Required(ErrorMessage = "Это поле является обязательным")]
        public string Name { get; set; }

        [Display(Name ="Описание")]
        [Required(ErrorMessage = "Это поле является обязательным")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }

        [Display(Name ="Цена")]
        [Required(ErrorMessage = "Это поле является обязательным")]
        public decimal Price { get; set; }
        
        [DataType(DataType.Upload)]
        public HttpPostedFileBase ImageOne { get; set; }
        
        public string ImageOnePath { get; set; }
        
        [DataType(DataType.Upload)]
        public HttpPostedFileBase ImageTwo { get; set; }
        
        public string ImageTwoPath { get; set; }
        
        [DataType(DataType.Upload)]
        public HttpPostedFileBase ImageThree { get; set; }
        
        public string ImageTreePath { get; set; }
        
        public Product GetAsProduct()
        {
            return new Product()
            {
                Name        = Name,
                Description = Description,
                Price       = Price,
                ImageOne    = ImageOnePath,
                ImageTwo    = ImageTwoPath,
                ImageThree  = ImageTreePath,
            };
        }
    }
}