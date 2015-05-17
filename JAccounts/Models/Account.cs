using System.ComponentModel.DataAnnotations;
using System;

namespace JAccounts.Models
{
    public class Account
    {
        [Key] public int ID { get; set; }
        public int ApplicationUserID { get; set; }
        public int AccountTypeID { get; set; }
        public string Name { get; set; }
        public string BIC { get; set; }
        public string IBAN { get; set; }
        public bool IsActive { get; set; }
        [DataType(DataType.Date)]
        public DateTime OpenedOn { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ClosedOn { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual AccountType AccountType { get; set; }
    }
}
