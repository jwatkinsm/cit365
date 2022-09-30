namespace MegaDesk_JoshW
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.widthTextField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.depthTextField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumDrawerBox = new System.Windows.Forms.ComboBox();
            this.DeskMaterialBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SubmitOrder = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.RushOrderBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // NameTextField
            // 
            this.NameTextField.Location = new System.Drawing.Point(91, 0);
            this.NameTextField.Name = "NameTextField";
            this.NameTextField.Size = new System.Drawing.Size(100, 20);
            this.NameTextField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desk Width";
            // 
            // widthTextField
            // 
            this.widthTextField.Location = new System.Drawing.Point(91, 60);
            this.widthTextField.Name = "widthTextField";
            this.widthTextField.Size = new System.Drawing.Size(100, 20);
            this.widthTextField.TabIndex = 3;
            this.widthTextField.Validating += new System.ComponentModel.CancelEventHandler(this.widthTextField_Validating);
            this.widthTextField.Validated += new System.EventHandler(this.widthTextField_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "desk Depth";
            // 
            // depthTextField
            // 
            this.depthTextField.Location = new System.Drawing.Point(91, 146);
            this.depthTextField.Name = "depthTextField";
            this.depthTextField.Size = new System.Drawing.Size(100, 20);
            this.depthTextField.TabIndex = 5;
            this.depthTextField.TextChanged += new System.EventHandler(this.depthTextField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Drawers";
            // 
            // NumDrawerBox
            // 
            this.NumDrawerBox.DisplayMember = "0";
            this.NumDrawerBox.FormattingEnabled = true;
            this.NumDrawerBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.NumDrawerBox.Location = new System.Drawing.Point(79, 210);
            this.NumDrawerBox.Name = "NumDrawerBox";
            this.NumDrawerBox.Size = new System.Drawing.Size(121, 21);
            this.NumDrawerBox.TabIndex = 7;
            // 
            // DeskMaterialBox
            // 
            this.DeskMaterialBox.FormattingEnabled = true;
            this.DeskMaterialBox.Location = new System.Drawing.Point(79, 269);
            this.DeskMaterialBox.Name = "DeskMaterialBox";
            this.DeskMaterialBox.Size = new System.Drawing.Size(121, 21);
            this.DeskMaterialBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Desk Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "order processing";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(283, 363);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(34, 363);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(120, 363);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(197, 363);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.Location = new System.Drawing.Point(527, 300);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.Size = new System.Drawing.Size(75, 23);
            this.SubmitOrder.TabIndex = 15;
            this.SubmitOrder.Text = "Submit Order";
            this.SubmitOrder.UseVisualStyleBackColor = true;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(623, 300);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 16;
            this.BackBtn.Text = "Main Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RushOrderBox
            // 
            this.RushOrderBox.AutoCompleteCustomSource.AddRange(new string[] {
            "none",
            "3",
            "5",
            "7"});
            this.RushOrderBox.FormattingEnabled = true;
            this.RushOrderBox.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.RushOrderBox.Location = new System.Drawing.Point(369, 363);
            this.RushOrderBox.Name = "RushOrderBox";
            this.RushOrderBox.Size = new System.Drawing.Size(121, 21);
            this.RushOrderBox.TabIndex = 17;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RushOrderBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SubmitOrder);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeskMaterialBox);
            this.Controls.Add(this.NumDrawerBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depthTextField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.widthTextField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextField);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox widthTextField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox depthTextField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NumDrawerBox;
        private System.Windows.Forms.ComboBox DeskMaterialBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button SubmitOrder;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox RushOrderBox;
    }
}