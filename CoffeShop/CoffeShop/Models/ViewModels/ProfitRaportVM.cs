using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.Models
{
    public class ProfitRaportVM:IRepoEntity
    {

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }
    }
}
