using System.ComponentModel.DataAnnotations.Schema;
namespace API.Models;
{
    public class AccountRole 
    {
        
        public Guid Guid { get; set; }
        
        public Guid AccounGuid { get; set; }
        
        public Guid RoleGuid { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
