using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensProjektOOP
{
    class InsertCashTransaction
    {
        public User user;
        public Product product;
        public Transaction transaction;
        

        public string toString()
        {
            //indbetaling af kontanter
            //beløbet der er indbetalt
            //hvem der har indbetalt
            //hvornår indbetalingen fandt sted
            //id på transactionen

            return ($" {transaction.Amount} {user.FirstName} {transaction.TransactionDate} {transaction.ID}");

        }

        public decimal execute()
        {
            //adder beløb 
            return user.Balance += transaction.Amount;
        }

    }
}
