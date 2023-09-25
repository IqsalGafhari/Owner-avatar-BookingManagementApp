namespace API.Models;
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
