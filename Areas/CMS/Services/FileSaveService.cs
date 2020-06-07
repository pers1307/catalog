using System.Drawing;
using System.Web;
using Kaliko.ImageLibrary;
using Kaliko.ImageLibrary.Scaling;

namespace Catalog.Areas.CMS.Services
{
    public static class FileSaveService
    {
        private const string FILE_PATH = "~/Files/";
        
        public static string SaveFile(HttpPostedFileBase image)
        {
            // Проверить уникальность названия файла
            
            // если есть файл, то добавить к нему временную метку
            
            // сохранить файл
            
            // вернуть путь к файлу
            
//            form.ImageOne.SaveAs(Server.MapPath("~/Files/" + fileName));
            
            KalikoImage image = new KalikoImage("garden.jpg");

            // Create thumbnail by cropping
            KalikoImage thumb = image.Scale(new CropScaling(128, 128));
//            thumb.SaveJPG("thumbnail-crop.jpg", 99);

            // Create thumbnail by fitting
            thumb = image.Scale(new FitScaling(128, 128));
//            thumb.SaveJPG("thumbnail-fit.jpg", 99);

            // Create thumbnail by padding. Pad with Color.Wheat
            image.BackgroundColor = Color.Wheat;
            thumb = image.Scale(new PadScaling(128, 128));
//            thumb.SaveJPG("thumbnail-pad.jpg", 99);



            return "";
        }
    }
}