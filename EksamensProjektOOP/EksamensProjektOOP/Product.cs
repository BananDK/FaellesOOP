using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EksamensProjektOOP
{
    class Product
    {
        private int id;
        private string name;
        private decimal price;
        private bool active;
        private bool canBeBoughtOnCredit;
        private DateTime seasonStartDate;
        private DateTime seasonEndDate;

        //constructor
        public Product(string Name, decimal Price, bool Active, bool CanBeBoughtOnCredit)
        {
            name = Name;
            price = Price;
            active = Active;
            canBeBoughtOnCredit = CanBeBoughtOnCredit;

        }
        //reading product file
        //public static List<Product> readProdFile()
        //{
        //    string fileName = @"C:/Users/nanna/source/repos/EksamensProjektOOP/products.csv";
        //    using (StreamReader sr = new StreamReader(fileName))
        //    {
        //        sr.ReadLine(); //springer første linje over

        //        string line = null;
        //        List<Product> productsList = new List<Product>();
        //        while ((line = sr.ReadLine()) != null)
        //        {
                    
        //            productsList.Add(new Product(line.Split(',')[1], Convert.ToDecimal(line.Split(';')[2]), Convert.ToBoolean(line.Split(';')[3]), Convert.ToBoolean(line.Split(';')[4])));

        //        }
        //        sr.Close();
        //        //HTML tags bør fjernes
        //        //Hver linie svarer til et produkt
        //        //Værdierne kommer altid i samme rækkefølge
        //        //Denne fil skal indlæses når stregsystemet startes, og aktive produkter skal vises i menuen
        //        //
        //    }
        //    return null;
        // }

        

        public int ID
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    name = value;
                }
            }
        }
        public decimal Price
        {
            get { return price; }
            set 
            { 
                //skal læses fra filen
                price = value; 
            }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public bool CanBeBoughtOnCredit
        {
            get { return canBeBoughtOnCredit; }
            set { canBeBoughtOnCredit = value; }
        }

        public override string ToString()
        {
            return $"{ID} {Name} {Price}";
        }
    }
}
