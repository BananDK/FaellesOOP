using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using System.Collections.Generic;


namespace EksamensProjektOOP
{
    public delegate void UserBalanceNotification(User user, decimal balance);
    public class User
    {
        private int Id;
        private string firstName;
        private string lastName;
        private string userName;
        private string email;
        private decimal balance;
        public UserBalanceNotification UserBalanceNotification;

        // Constructor
        public User(int id, string FirstName, string LastName, string UserName, decimal Balance, string Email)
        {
            Id = id;
            firstName = FirstName;
            lastName = LastName;
            userName = UserName;
            email = Email;
            balance = Balance;
        }

        public int ID
        {
            get { return Id; }
            set
            {
                Id = value;
            }
        }


        //property for firstName
        // vi antager at den ikke er tom
        public string FirstName
        {
            get { return firstName; }
            set
            {
  
                if (String.IsNullOrEmpty(value))
                { 
                    throw new ArgumentNullException();
                }
                else
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    lastName = value;
                }
            }
        }

        //Regex til at validere username indeholder tal, små bogstaver og/eller _
        public string UserName
        {
            get { return userName; }
            set
            {
                Regex r = new Regex("[a-z0-9_] + ^");
                if (r.IsMatch(userName))
                {
                    userName = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }

        }


        public string Email
        {
            get { return email; }
            set
            {

                //splitter i local og domæne, hvis der er mere end 2, så er det ikke valid
                //skal valideres de enkelte dele
                //samme som username, bare med flere krav
                if (email.Contains('@'))
                {

                    string[] splitMail = email.Split('@');
                    Console.WriteLine(email);

                    if (splitMail.Length == 2)
                    {
                        string local = splitMail[0];
                        string domain = splitMail[1];
                        Console.WriteLine(local);
                        Console.WriteLine(domain);
                        Regex rLocal = new Regex("[a-zA-Z0-9._-]+^");
                        if (rLocal.IsMatch(local))
                        {
                            //domæne navn må ikke starte med _ eller .
                            //domæne skal indeholde et .
                            Regex rDomain = new Regex("^[a-zA-Z0-9]+ [a-zA-Z0-9.-] [.] [a-z]+$");
                            if (rDomain.IsMatch(domain))
                            {
                                email = value;
                                Console.WriteLine("sucess");
                            }
                            else
                            {
                                throw new ArgumentException();
                            }

                        }
                        else
                        {
                            throw new ArgumentException();
                        }
                    }
                }
            }
        }


        public decimal Balance
        {
            get { return balance; }

            set
            {
                void addBalance(decimal p)
                {
                    balance += p;
                    balance = value;
                    
                }
                void removeBalance(decimal q)
                {
                    balance -= q;
                    if (balance > 50)
                    {
                        Console.WriteLine("your balance is under 50 kr.");
                    }
                    balance = value;
                }

                //balanceManager b = new balanceManager(addBalance);
                //balanceManager c = new balanceManager(removeBalance);

                //decimal balance = 10;
                ////delegates: valider balance med delegate
                //decimal addBalance(decimal p)
                //{
                //    balance += p;
                //    return balance
                //}

                //decimal removeBalance(decimal q)
                //{
                //    balance -= q;
                //    if (balance > 50)
                //    {
                //        Console.WriteLine("your balance is under 50 kr.");
                //    }
                //    return balance;
                //}


                //decimal getBalance()
                //{
                //    return balance;
                //}

                //balanceManager b = null;
                //b += addBalance;
                //b += removeBalance;


            }
        }

        //$ tillader at man kan sætte variabler direkte ind i strengen, uden alle plusserne
        public string toString()
        {
            return $"{firstName} {lastName} {email}";
        }

        public int compareTo(User other)
        {
            return Id.CompareTo(other.ID);
        }

        //Auto Equals Skal nok ændres
        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Id == user.Id &&
                   firstName == user.firstName &&
                   lastName == user.lastName &&
                   userName == user.userName &&
                   email == user.email &&
                   balance == user.balance &&
                   ID == user.ID &&
                   FirstName == user.FirstName &&
                   LastName == user.LastName &&
                   UserName == user.UserName &&
                   Email == user.Email &&
                   Balance == user.Balance;

        }

        //Auto Hashcode Skal nok ændres
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(firstName);
            hash.Add(lastName);
            hash.Add(userName);
            hash.Add(email);
            hash.Add(balance);
            hash.Add(ID);
            hash.Add(FirstName);
            hash.Add(LastName);
            hash.Add(UserName);
            hash.Add(Email);
            hash.Add(Balance);
            return hash.ToHashCode();
        }
    }
}
