namespace MegaDesk_JoshW
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddQuoteBtn = new System.Windows.Forms.Button();
            this.ViewQuotesBtn = new System.Windows.Forms.Button();
            this.SearchQuotesBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuoteBtn
            // 
            this.AddQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteBtn.Location = new System.Drawing.Point(23, 73);
            this.AddQuoteBtn.Name = "AddQuoteBtn";
            this.AddQuoteBtn.Size = new System.Drawing.Size(85, 36);
            this.AddQuoteBtn.TabIndex = 0;
            this.AddQuoteBtn.Text = "Add Quote";
            this.AddQuoteBtn.UseVisualStyleBackColor = true;
            this.AddQuoteBtn.Click += new System.EventHandler(this.AddQuoteBtn_Click);
            // 
            // ViewQuotesBtn
            // 
            this.ViewQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotesBtn.Location = new System.Drawing.Point(23, 115);
            this.ViewQuotesBtn.Name = "ViewQuotesBtn";
            this.ViewQuotesBtn.Size = new System.Drawing.Size(85, 36);
            this.ViewQuotesBtn.TabIndex = 1;
            this.ViewQuotesBtn.Text = "View Quotes";
            this.ViewQuotesBtn.UseVisualStyleBackColor = true;
            this.ViewQuotesBtn.Click += new System.EventHandler(this.ViewQuotesBtn_Click);
            // 
            // SearchQuotesBtn
            // 
            this.SearchQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesBtn.Location = new System.Drawing.Point(23, 157);
            this.SearchQuotesBtn.Name = "SearchQuotesBtn";
            this.SearchQuotesBtn.Size = new System.Drawing.Size(85, 36);
            this.SearchQuotesBtn.TabIndex = 2;
            this.SearchQuotesBtn.Text = "Search Quotes";
            this.SearchQuotesBtn.UseVisualStyleBackColor = true;
            this.SearchQuotesBtn.Click += new System.EventHandler(this.SearchQuotesBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(23, 199);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(85, 36);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(182, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(129, 29);
            this.title.TabIndex = 4;
            this.title.Text = "MegaDesk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk_JoshW.Properties.Resources.pngegg__1_;
            this.pictureBox1.Location = new System.Drawing.Point(169, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 189);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 253);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SearchQuotesBtn);
            this.Controls.Add(this.ViewQuotesBtn);
            this.Controls.Add(this.AddQuoteBtn);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteBtn;
        private System.Windows.Forms.Button ViewQuotesBtn;
        private System.Windows.Forms.Button SearchQuotesBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

