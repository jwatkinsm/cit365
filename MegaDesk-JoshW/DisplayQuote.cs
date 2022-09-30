using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_JoshW
{
    public partial class DisplayQuote : Form
    {
        public Desk desk;
        public DeskQuote quote;
        public DisplayQuote(Desk desk, DeskQuote quote)
        {
            this.desk = desk;
            this.quote = quote;
            InitializeComponent();

            //fields to values
            label1.Text ="Name: " + quote.CustomerName;
            label2.Text ="Date: " + quote.QuoteDate;
            label3.Text ="Starting Price: " + quote.BaseDeskPrice.ToString();
            label4.Text ="Desk size: " + desk.DeskSize().ToString();
            label5.Text ="Drawer Cost: " + quote.CalculateDrawerCost(desk).ToString();
            label6.Text ="Material cost: " + quote.SurfaceMaterialCost(desk).ToString();
            label7.Text ="Shipping: " + quote.CalculateRushOrder(desk).ToString();
            label8.Text ="Total: " + quote.TotalPrice(desk).ToString();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show(this);
            Hide();
        }
    }
}
