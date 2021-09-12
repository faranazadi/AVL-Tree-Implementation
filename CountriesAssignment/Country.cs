using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAssignment
{
    //Implements IComparable interface
    class Country : IComparable
    {
        //Class members
        /*private string name;
        private double gdpGrowth;
        private double inflation;
        private double tradeBalance;
        private double hdiRanking;*/

        //Class constructor
        public Country(string name, double gdpGrowth, double inflation, double tradeBalance, double hdiRanking)
        {
            Name = name;
            GDPGrowth = gdpGrowth;
            Inflation = inflation;
            TradeBalance = tradeBalance;
            HDIRanking = hdiRanking;
        }

        //Getters and setters
        public string Name
        {
            get;
            set;
        }

        public double GDPGrowth
        {
            get;
            set;
        }

        public double Inflation
        {
            get;
            set;
        }

        public double TradeBalance
        {
            get;
            set;
        }

        public double HDIRanking
        {
            get;
            set;
        }

        public Country[] MainTradePartners
        {
            get;
            set;
        }

        /*public string Name
        {
            get { return Name; }
            set { name = value; }
        }

        public double GDPGrowth
        {
            get { return gdpGrowth; }
            set { gdpGrowth = value; }
        }

        public double Inflation
        {
            get { return inflation; }
            set { inflation = value; }
        }

        public double TradeBalance
        {
            get { return tradeBalance; }
            set { tradeBalance = value; }
        }

        public double HDIRanking
        {
            get { return hdiRanking; }
            set { hdiRanking = value; }
        }

        public Country[] TradingPartners
        {
            get;
            set;
        }*/

        //String representation of Country
        public override string ToString()
        {
            return Name; 
        }

        //Required because of the IComparable interface
        //Compares two instances of Country
        public int CompareTo(object other)
        {
            Country temp = (Country)other;
            return Name.CompareTo(temp.Name);
        }


    }
}
