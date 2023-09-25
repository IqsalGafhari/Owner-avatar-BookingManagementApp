﻿using System.ComponentModel.DataAnnotations;

namespace BookingManagementApp.Controllers
{
    public class Account 
    {
        [Key]
        public Guid Guid { get; set; }
        public string Password { get; set; }
        public bool IsDeleted {  get; set; }
        public int OTP {  get; set; }
        public bool IsUsed {  get; set; }
        public DateTime ExpiredTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
