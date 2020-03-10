using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_2
{
    class CandyBox
    {
        public static int CompareAsc(CandyBox c1, CandyBox c2)
        {
            return c1.NumberOfCandies.CompareTo(c2.NumberOfCandies);
        }

        public static int CompareDesc(CandyBox c1, CandyBox c2)
        {
            return c2.NumberOfCandies.CompareTo(c1.NumberOfCandies);
        }

        private int numberOfCandies;
        private string taste;

        public int NumberOfCandies { get => numberOfCandies; set => numberOfCandies = value; }
        public string Taste { get => taste; set => taste = value; }

        public CandyBox(int count, string taste)
        {
            numberOfCandies = count;
            this.taste = taste;
        }

        public CandyBox(int count)
        {
            numberOfCandies = count;
            taste = "chocolate";
        }

        public CandyBox(string taste)
        {
            this.taste = taste;
            numberOfCandies = 10;
        }

        public override string ToString()
        {
            return ($"Box of candies tase:{taste}, count:{numberOfCandies}");
        }
    }
}
