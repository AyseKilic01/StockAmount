using StockAmount.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockAmount
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
            
            
        }
        void Update()
        {
            Product product = new Product();
            txtAmountHDD.Text = product.StockAmount.ToString();
        }
        Product hdd = new Product(20);
        private void btnSellHDD_Click(object sender, EventArgs e)
        {  
            hdd.ProductName = "Hard Disk";
            hdd.Sell(1);
            txtAmountHDD.Text = "";
            txtAmountHDD.Text = hdd.StockAmount.ToString();
            hdd.StockControlEvent += Hdd_StockControlEvent;
            hdd.StockControlEnoughEvent += Hdd_StockControlEnoughEvent;
        }

        private void Hdd_StockControlEvent()
        {
           
        }

        private void Hdd_StockControlEnoughEvent()
        {
            labelControl5.Text = "Hard Disk bitti !!!";
            btnSellHDD.Enabled = false;
            labelControl5.Visible = true;
        }

        Product gsm = new Product(20);
        private void btnSellGsm_Click(object sender, EventArgs e)
        {
            gsm.ProductName = "GSM";
            gsm.Sell(1);
            txtGsm.Text = gsm.StockAmount.ToString();
            gsm.StockControlEvent += Gsm_StockControlEvent;
            gsm.StockControlEnoughEvent += Gsm_StockControlEnoughEvent;
        }

        private void Gsm_StockControlEnoughEvent()
        {
            labelControl5.Text = "Ürün Bitti !!!";
            btnSellGsm.Enabled = false;
            labelControl5.Visible = true;
        }

        private void Gsm_StockControlEvent()
        {
            labelControl5.Text = "Gsm Stoğu Azalıyor !!!";
            labelControl5.Visible = true;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtGsm.Text = gsm.StockAmount.ToString();
            txtAmountHDD.Text = hdd.StockAmount.ToString();
        }
    }
}
