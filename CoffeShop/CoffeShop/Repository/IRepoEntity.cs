using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Repository
{
    public abstract class IRepoEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
