using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_rab_3_CherevkoG.S_BPI_23_02
{
    public static class ComboBoxFiller
    {
        public static List<int> GetFValues1()
        {
            return new List<int> { 4, 5, 6, 7, 8, 9 };
        }

        public static List<int> GetFValues2()
        {
            return new List<int> { 10, 20, 30, 40 };
        }

        public static List<int> GetCValues3()
        {
            return new List<int> { 0, 1 };
        }

        public static List<int> GetDValues3()
        {
            return new List<int> { -1, 0, 1 };
        }

        public static List<int> GetCValues4()
        {
            return new List<int> { 0, 1, 2, 3, 4, 5 };
        }

        public static List<int> GetNKValues()
        {
            return new List<int> { 1, 2, 3, 4, 5, 10, 15, 20 };
        }

        public static List<double> GetOtherValues()
        {
            return new List<double> { 0.1, 0.5, 1.0, 1.5, 2.0, 2.5, 3.0, 5.0, 10.0 };
        }
    }
}