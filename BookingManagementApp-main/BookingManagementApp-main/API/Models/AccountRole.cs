using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingManagementApp.Controllers
{
    public class AccountRole 
    {
        [Key]
        public Guid Guid { get; set; }
        
        public Guid AccounGuid { get; set; }
        
        public Guid RoleGuid { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
