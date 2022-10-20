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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        //navigation button controls
        #region buttons
        //close application
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //open search quotes page
        private void SearchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            Hide();
        }

        //open view all quotes page
        private void ViewQuotesBtn_Click(object sender, EventArgs e)
        {
            ViewAllquotes viewViewAllquotes = new ViewAllquotes();
            viewViewAllquotes.Tag = this;
            viewViewAllquotes.Show(this);
            Hide();
        }
        //open add quote page
        private void AddQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            Hide();
        }
        #endregion
    }
}
