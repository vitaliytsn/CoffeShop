using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShop.Repository
{
    public abstract class IRepoEntity
    {
        public int Id { get; set; }
    }
}
