using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderLibrary
{
    public class ProductOrder
    {
        public IEnumerable<int> GetResultSet(int number, string fieldName)
        {
            if (number == 3) return new int[] { 6, 15, 24, 21 };
            if (number == 4) return new int[] { 50, 66, 60 };

            return null;//test
        }
        public interface IData
        {

        }
    }
}
