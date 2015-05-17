namespace JAccounts.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using JAccounts.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<JAccounts.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "JAccounts.Models.ApplicationDbContext";
        }

        protected override void Seed(JAccounts.Models.ApplicationDbContext context)
        {
            context.AccountTypes.AddOrUpdate(p => p.Name,
                new AccountType
                {
                    ID = 1,
                    Name = "Checking Account"
                },
                new AccountType
                {
                    ID = 2,
                    Name = "Savings Account"
                }
                );

            context.Accounts.AddOrUpdate(p => p.Name,
                new Account
                {
                    Name = "La Poste Compte Courant",
                    AccountTypeID = 1,
                    BIC = "PSSTFRPPCNE",
                    IBAN = "FR6420041010071584335B03863P",
                    OpenedOn = new DateTime(2005, 11, 15),
                    IsActive = true
                },
                new Account
                {
                    Name = "SG Compte Courant",
                    AccountTypeID = 1,
                    BIC = "SOGEFRPP",
                    IBAN = "FR7630003041230005094405264",
                    OpenedOn = new DateTime(2010, 03, 26),
                    IsActive = true
                },
                new Account
                {
                    Name = "SG Livret A",
                    AccountTypeID = 2,
                    BIC = "SOGEFRPP",
                    IBAN = " FR7630003031800002048782369",
                    OpenedOn = new DateTime(2010, 03, 26),
                    ClosedOn = new DateTime(2011, 12, 5),
                    IsActive = false
                }
                );
        }
    }
}
