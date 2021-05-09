using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockAmount.Control
{
    public delegate void StockAmountControl();
    public class Product
    {
        int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }
        public Product()
        {
            
        }
        public event StockAmountControl StockControlEvent;
        public event StockAmountControl StockControlEnoughEvent;
        public string ProductName { get; set; }
        public int StockAmount {
            get { return _stock; }
            set { _stock = value;
                if(value <= 5 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
                if(value == 0 && StockControlEvent != null)
                {
                    StockControlEnoughEvent();     
                }
            }
        }
        public void Sell(int amount)
        {
            StockAmount -= amount;
                //MessageBox.Show("Ürün azalıyor " + StockAmount);
            
        }
    }
}
