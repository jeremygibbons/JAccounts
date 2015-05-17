using System.ComponentModel.DataAnnotations;

namespace JAccounts.Models
{
    public class AccountType
    {
        [Key] public int ID { get; set; }
        public string Name { get; set; }
    }
}
