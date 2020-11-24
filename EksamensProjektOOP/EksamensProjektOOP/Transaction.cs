using System;
using System.Collections.Generic;
using System.Text;
using EksamensProjektOOP;
using System.IO;

namespace EksamensProjektOOP
{

    class Transaction 
    {
        private string iD;
        private DateTime transactionDate;
        private decimal amount;
        public User user;

        //constructor
        public Transaction( User user, string iD, DateTime transactionDate, decimal amount)
        {
            this.user = TransactionUser;
            iD = ID;
            transactionDate = TransactionDate;
            amount = Amount;
        }

        //skal laves om
        public string ID
        {
            get { return iD; }

            set
            {
                iD = Guid.NewGuid().ToString();
            }
               
        }


        public User TransactionUser
        {
            get { return TransactionUser; }
            set
            {
                //vær obs på at det ikke må være null
                TransactionUser = value;
            }
        }

        //get current local date
        public DateTime TransactionDate
        {
            get { return transactionDate; }
            set
            {
                DateTime.Now.ToShortTimeString();
            }

        }

        //negative beløb hæves
        //positive beløb sættes ind
        public decimal Amount
        {
            get { return amount; }
            set
            {
                amount = value;
               
            }
        }

        public string toString()
        {
            return $"{iD} {TransactionUser} {amount} {transactionDate}";
        }

        public void execute()
        {
            //kan enten insertcash transaction
            // eller buytransaction



        }

    }
}
