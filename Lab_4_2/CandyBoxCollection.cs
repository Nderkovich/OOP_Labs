using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_2
{
    delegate void Sorter(int i);
    class CandyBoxCollection: IEnumerable<CandyBox>
    {
        private Sorter sequence;
        private List<CandyBox> candyBoxes;
        private List<string> tastes = new List<string>()
        {
            "chocolate", "lime", "peach", "apple"
        };

        public CandyBoxCollection()
        {
            candyBoxes = new List<CandyBox>();
        }

        public CandyBoxCollection(int size)
        {
            candyBoxes = new List<CandyBox>();
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                candyBoxes.Add(new CandyBox(rand.Next(1, 50), tastes[rand.Next(0, tastes.Count())]));
            }
        }

        public IEnumerable<CandyBox> LimeAndPeach()
        {
            var result = candyBoxes.Where(t => t.Taste == "lime" || t.Taste == "peach");
            return result;
        }

        public IEnumerable<CandyBox> ChocalteMoreThanTen()
        {
            var result = candyBoxes.Where(t => t.Taste == "chocolate").Where(p => p.NumberOfCandies > 10);
            return result;
        }

        public IEnumerable<CandyBox> ALotOfCandies()
        {
            var result = candyBoxes.Where(t => t.NumberOfCandies > 30);
            return result;
        }

        public IEnumerable<CandyBox> SorterList(int order)
        {
            List<CandyBox> result = candyBoxes.ToList();
            if (order == 0)
            {
                result.Sort(CandyBox.CompareAsc);
            }
            else
            {
                result.Sort(CandyBox.CompareDesc);
            }
            return result;
        }

        public IEnumerator<CandyBox> GetEnumerator()
        {
            foreach (var box in candyBoxes)
            {
                yield return box;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
