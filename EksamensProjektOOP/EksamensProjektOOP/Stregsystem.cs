using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensProjektOOP
{
    class Stregsystem
    {
       
       
        public void BuyProduct( User user, Product product)
        {
            //  udfører logikken for et køber et produkt på en brugers konto, ved brug af en transaktion
            //brugernavn brugeren
            //produkt id
            //tjek for om der er nok penge
            //lav transaction

             

        }

        public void AddCreditsToAccount(User user, Product Amount)
        {
            // indsætter et beløb på en brugers konto, via en transaktion
        }

        public void ExecuteTransaction(Transaction transaction)
        {
            // hjælpemetode til at eksekvere transaktioner, og sørge for at de bliver
            // tilføjet til en liste af udførte transaktioner.
        }

        public string GetProductByID(Product id)
        {
            //Finder og returnerer det unikke produkt i listen over produkter ud fra et produkt id.
            return "";
        }

        public void GetUsers()
        {
            //Brugere der overholder predicate
        }

        public string GetUserByUsername(string username)
        {

            //Finder og returnerer den unikke bruger i brugerlisten ud fra brugernavn.
            return "";

        }

        public void GetTransaction(User user, int count)
        {
            //Finder et angivet (via parameter) antal transaktioner relateret til en given specifik bruger.
        }

        public string ActiveProducts(Product active)
        {
            //aktive produkter i stregsystemet på nuværende tidspunkt
            return "";
        }

    }
}
