using System.Data.Entity;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BussinesLogic.DBModel
{
    class UserContext : DbContext
    {
        public UserContext() : 
            base("name=Mydataidweb") // connectionstring name define in your web.config
        {
        }

        public virtual DbSet<UDbTable> Users { get; set; }
    }
}
