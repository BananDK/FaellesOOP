using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensProjektOOP
{

    class SeasonalProduct : Product
    {
        public DateTime SeasonStartDate { get; set; }
        public DateTime SeasonEndDate { get; set; }

        public SeasonalProduct(string aName, decimal aPrice, bool aActive, bool aCanBeBoughtOnCredit, DateTime aSeasonStartDate, DateTime aSeasonEndDate) : base(aName, aPrice, aActive, aCanBeBoughtOnCredit)
        {
            SeasonStartDate = aSeasonStartDate;
            SeasonEndDate = aSeasonEndDate;
        }
    }
}
