using System.Collections.Generic;

namespace NumberDecomposer.Models
{
    public class NumberDecomposition
    {
        public NumberDecomposition()
        {
            this.Dividers = new List<int>();
            this.PrimeDividers = new List<int>();
        }

        private int _Number;
        public int Number
        {
            get
            {
                return this._Number;
            }
            set
            {
                this._Number = value;
                this.Dividers = FindDividers();
                this.Dividers.
                    ForEach(x =>
                    {
                        if (AmountOfDividers(x) <= 2)
                        {
                            this.PrimeDividers.Add(x);
                        }
                    });
            }
        }
        public List<int> Dividers { get; set; }
        public List<int> PrimeDividers { get; set; }

        private List<int> FindDividers()
        {
            List<int> dividers = new List<int>();
            for (int i = 1; i <= this._Number; i++)
            {
                if (this._Number % i == 0)
                    dividers.Add(i);
            }
            return dividers;
        }

        private int AmountOfDividers(int N)
        {
            int dividers = 0;
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    dividers++;
                }
            }
            return dividers;
        }
    }
}
