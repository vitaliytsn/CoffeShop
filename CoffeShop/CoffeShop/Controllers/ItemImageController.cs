using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Data;
using CoffeShop.Models;
using CoffeShop.Repository;
using Microsoft.AspNetCore.Mvc;

using Microsoft.ApplicationInsights.AspNetCore.Extensions;


using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;


namespace CoffeShop.Controllers
{
    public class ItemImageController : Controller
    {
        private readonly IRepository<ItemImage, CoffeShopContext> _itemImageRepository;
        public ItemImageController(IRepository<ItemImage, CoffeShopContext> itemImageRepository)
        {
            _itemImageRepository = itemImageRepository;
        }
        public FileResult GetImage(string ImageId, int Width, int Height)
        {
            int w = Width;
            int h = Height;
            if (w == 0) w = 50;
            if (h == 0) h = 50;

            int width = w;
            int height = h;



            ItemImage itemImage = _itemImageRepository.GetByQuery(x => x.Id == Convert.ToInt32(ImageId)).FirstOrDefault();
            if (itemImage != null)
            {

                MemoryStream stream = new MemoryStream(itemImage.image);

                //Create the image from stream
                System.Drawing.Image image = System.Drawing.Image.FromStream(stream);


                double coeficient = 1;
                if ((double)width / image.VerticalResolution > (double)height / image.HorizontalResolution)
                    coeficient = (double)height / image.HorizontalResolution;
                else
                    coeficient = (double)width / image.VerticalResolution;
                var destRect = new Rectangle(0, 0, Convert.ToInt32(image.HorizontalResolution * coeficient), Convert.ToInt32(image.VerticalResolution * coeficient));

                var destImage = new Bitmap(Convert.ToInt32(image.HorizontalResolution * coeficient), Convert.ToInt32(image.VerticalResolution * coeficient));

                destImage.SetResolution(Convert.ToInt32(image.HorizontalResolution * coeficient), Convert.ToInt32(image.VerticalResolution * coeficient));

                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }


                MemoryStream memoryStream = new MemoryStream();

                destImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                return File(memoryStream.ToArray(), "image/png");
            }
            else return null;
           
        }
    }
}