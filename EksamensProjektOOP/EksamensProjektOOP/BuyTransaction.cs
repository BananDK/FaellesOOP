using System;
using System.Collections.Generic;
using System.Text;


namespace EksamensProjektOOP
{
    class BuyTransaction
    {
        public User user;
        public Transaction transaction;
        public Product product;
        public class InsufficientCreditException : Exception
        {
            public InsufficientCreditException(string message) : base(message)
            {
            }
        }
        public void Product()
        {
            //produktet valgt i stregsystem
        }

        //public void Anount()
        //{
        //    //prisen på det próduct der er valgt
        //    //skal hente fra product
        //}

        public string toString(Product product, User user, Transaction transaction)
        {
            //fortæller at det er køb
            //returner beløb, bruger, tidspunkt, og trans ID
            return $"{product.Price}{user.UserName}{transaction.TransactionDate}{transaction.ID }";
        }
        
        public void validateCredit(Product product, User user)
        {
            if (product.Price > user.Balance)
            {
                throw new InsufficientCreditException("Too little money");
            }
            else
            {
                user.Balance -= product.Price;
            }
        }

        public decimal Execute()
        {
            //get balance fra bruger
            //exception ved overtræk
            //InsufficientCreditException(User, product)
            //giver besked om fejlen (for lidt penge)
            validateCredit(product, user);
            return user.Balance;
        }

    }
}
