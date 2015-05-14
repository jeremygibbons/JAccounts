using System.ComponentModel.DataAnnotations;
using System;

namespace JAccounts.Models
{
    public class Account
    {
        public uint AccountID { get; set; }
        public string Name { get; set; }
        public string BIC { get; set; }
        public string IBAN { get; set; }
        public bool IsActive { get; set; }
        [DataType(DataType.Date)]
        public DateTime OpenedOn { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ClosedOn { get; set; }
    }
}
