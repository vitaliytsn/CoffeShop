using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CoffeShop.Models.ViewModels
{
    public class ItemVM
    {
        public Item CurrentItem { get; set; }

        public IFormFile UploadImage { get; set; } = null;
    }
}
