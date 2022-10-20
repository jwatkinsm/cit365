using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MegaDesk_JoshW
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }
        //back to main menu
        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
        private void SubmitOrder_Click(object sender, EventArgs e)
        {


            // Validate the width
           if (!ValidWidth(widthTextField.Text))
            {
                this.errorProvider1.SetError(widthTextField, "Please enter a number between 24 and 96");
                return;
            }

            // Validate the depth and send error
            if (!ValidDepth(depthTextField.Text))
            {
                this.errorProvider1.SetError(depthTextField, "Please enter a number between 12 and 48");
                return;
            }

            // Create a desk object with the validated data
            int deskWidth = Int32.Parse(widthTextField.Text);
            int deskDepth = Int32.Parse(widthTextField.Text);
            int deskNumOfDrawers = Int32.Parse(NumDrawerBox.Text);
            Desk desk = new Desk(deskWidth, deskDepth, deskNumOfDrawers, DeskMaterialBox.Text);
           
            int rushDays = Int32.Parse(RushOrderBox.Text);
            DeskQuote quote = new DeskQuote(NameTextField.Text, rushDays, desk);

            // Navigate to the view quote menu
            DisplayQuote viewQuote = new DisplayQuote(desk, quote); // TODO pass our desk object and quote information into the constructor of the new window
            viewQuote.Tag = this;
            viewQuote.Show(this);
            this.Hide();
        }

        private void widthTextField_Validating(object sender, CancelEventArgs e)
        { 
            try
            {
                // Check valid character
                if (!ValidWidth(widthTextField.Text))
                {
                    // If not, throw an exeption
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                this.errorProvider1.SetError(widthTextField, "Please enter a number between 24 and 96");
                
            }
        }
        private bool ValidWidth(string text)
        {
            // Check blank
            if (text.Length == 0)
            {
                widthTextField.BackColor = Color.LightPink;
                return false;
            }

            // Check alphanumeric
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    widthTextField.BackColor = Color.LightPink;
                    return false;
                }
            }

            // Check correct range
            int numWidth = Int32.Parse(text);
            if (numWidth > 96 || numWidth < 24)
            {
                widthTextField.BackColor = Color.LightPink;
                return false;
            }

            // Looks like we're good
            widthTextField.BackColor = Color.Silver;
            return true;
        }

        private void widthTextField_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(widthTextField, "");
        }

        private void depthTextField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Check valid character
                if (!ValidDepth(depthTextField.Text))
                {
                    // If not, throw an exeption
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                this.errorProvider1.SetError(depthTextField, "Please enter a number between 12 and 48");
                
            }
        }
        private bool ValidDepth(string text)
        {
            // Check if blank
            if (text.Length == 0)
            {
                depthTextField.BackColor = Color.LightPink;
                return false;
            }

            // Check alphanumeric
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    depthTextField.BackColor = Color.LightPink;
                    return false;
                }
            }

            // Check correct range
            int numWidth = Int32.Parse(text);
            if (numWidth > 48 || numWidth < 12)
            {
                depthTextField.BackColor = Color.LightPink;
                return false;
            }


            // valid
            depthTextField.BackColor = Color.Silver;
            this.errorProvider1.SetError(depthTextField, "");
            return true;
        }

        private void depthTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ((char)(Keys.Enter)) && (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")) && e.KeyChar != (char)(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
