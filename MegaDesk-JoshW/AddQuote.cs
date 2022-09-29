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
            //how to pass objects to forms
            string errorMsg;

            // Validate the width
           if (!ValidWidth(widthTextField.Text, out errorMsg))
            {
                errorMsg = "Please enter a number between 24 and 96";
                this.errorProvider1.SetError(widthTextField, errorMsg);
                return;
            }

            // Validate the depth
            if (!ValidDepth(depthTextField.Text))
            {
                this.errorProvider1.SetError(depthTextField, "Please enter a number between 12 and 48");
                return;
            }

            // Create a desk object with the validated data
            int deskWidth = Int32.Parse(widthTextField.Text);
            int deskDepth = Int32.Parse(widthTextField.Text);
            int deskNumOfDrawers = Int32.Parse(NumOfDrawersBox.Text);
            Desk desk = new(deskWidth, deskDepth, deskNumOfDrawers, SurfaceMaterialBox.Text);
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
            string errorMsg;
            if (!ValidWidth(widthTextField.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected
                e.Cancel = true;
                widthTextField.Select(0, widthTextField.Text.Length);

                // Set the ErrorProvider error display. 
                this.errorProvider1.SetError(widthTextField, errorMsg);
            }
        }
        private bool ValidWidth(string text, out string errorMessage)
        {
            // Check blank
            if (text.Length == 0)
            {
                errorMessage = "Width is required";
                return false;
            }

            // Check alphanumeric
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    errorMessage = "Please enter a number";
                    return false;
                }
            }

            // Check correct range
            int numWidth = Int32.Parse(text);
            if (numWidth > 94 || numWidth < 24)
            {
                errorMessage = "Please enter a number between 24 and 94";
                return false;
            }

            // Looks like we're good
            errorMessage = "";
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
                return false;
            }

            // Check alphanumeric
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            // Check correct range
            int numWidth = Int32.Parse(text);
            if (numWidth > 48 || numWidth < 12)
            {
                return false;
            }


            // valid
            this.errorProvider1.SetError(depthTextField, "");
            return true;
        }
    }
}
