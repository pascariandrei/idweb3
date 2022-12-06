using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entities.Images;

namespace eUseControl.BusinessLogic.DBModel
{
    public class ImageContext : DbContext
    {
        public ImageContext() : base("name = Mydataidweb")
        {
        }

        public virtual DbSet<IDbTable> Images { get; set; }
    }
}
