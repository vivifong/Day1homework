using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrder
{
    public class Product
    {
        private int SumSetindex=0;
        //private int[] SumSet = new int[100];
        private List<int> SumSet = new List<int>();
        private IDataIn _DataIn;
        private int Sum;

        public Product() { }
        public Product(IDataIn DataIn)
        {
            this._DataIn = DataIn;   
        }
        public List<int> ProductCount(int num,string fieldName)
        {
            var Data = this._DataIn.GetResultSet(fieldName);                     
            int Dataindex = 0;
            //double datarow = 11.0;
            //Decimal temp = (Math.Ceiling(Convert.ToDecimal(11 / num)));
            int temp =Convert.ToInt32(11 / num);
            if ((11 % num) != 0)
            {
                temp++;
            }
          for (int x = 0; x < temp; x++)
            {
                Sum = 0;
                for (int i = 0; i < num; i++)
                {
                    try
                    {
                        Sum += Data.ToArray()[Dataindex];
                        Dataindex++;
                    }
                    catch
                    {
                        break;
                    }                                   
                }
                SumSet.Add(Sum);
                //SumSetindex++;
            }                
            
            return SumSet;//test
        }
        //public IEnumerable<int> GetResultSet(int number, string fieldName)//泛型介面？
        //{
        //    //if (number == 3) return new int[] { 6, 15, 24, 21 };
        //    //if (number == 4) return new int[] { 50, 66, 60 };
        //    int
        //    return null;//test
        //}
    }
    public class GetRssultSet : IDataIn
    {
        public IEnumerable<int> GetResultSet(string filename)
        {
            //取得外部資料商品訂單資料
            throw new NotImplementedException();
        }
    }

    public interface IDataIn
    {
        IEnumerable<int> GetResultSet(String filename);
    }
   
}
