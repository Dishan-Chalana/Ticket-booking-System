namespace Assignment2
{
    partial class FormTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicket));
            this.picBoxPoster = new System.Windows.Forms.PictureBox();
            this.labelmovie = new System.Windows.Forms.Label();
            this.labelPriceTag = new System.Windows.Forms.Label();
            this.rbGold = new System.Windows.Forms.RadioButton();
            this.rbSilver = new System.Windows.Forms.RadioButton();
            this.buttonBuyNow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxCinema = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPoster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPoster
            // 
            this.picBoxPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxPoster.Location = new System.Drawing.Point(54, 47);
            this.picBoxPoster.Name = "picBoxPoster";
            this.picBoxPoster.Size = new System.Drawing.Size(358, 432);
            this.picBoxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPoster.TabIndex = 0;
            this.picBoxPoster.TabStop = false;
            // 
            // labelmovie
            // 
            this.labelmovie.AutoSize = true;
            this.labelmovie.BackColor = System.Drawing.Color.Transparent;
            this.labelmovie.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmovie.ForeColor = System.Drawing.Color.White;
            this.labelmovie.Location = new System.Drawing.Point(575, 25);
            this.labelmovie.Name = "labelmovie";
            this.labelmovie.Size = new System.Drawing.Size(185, 42);
            this.labelmovie.TabIndex = 1;
            this.labelmovie.Text = "movie name";
            // 
            // labelPriceTag
            // 
            this.labelPriceTag.AutoSize = true;
            this.labelPriceTag.BackColor = System.Drawing.Color.Transparent;
            this.labelPriceTag.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceTag.ForeColor = System.Drawing.Color.White;
            this.labelPriceTag.Location = new System.Drawing.Point(521, 134);
            this.labelPriceTag.Name = "labelPriceTag";
            this.labelPriceTag.Size = new System.Drawing.Size(83, 18);
            this.labelPriceTag.TabIndex = 2;
            this.labelPriceTag.Text = "Ticket Price:";
            // 
            // rbGold
            // 
            this.rbGold.AutoSize = true;
            this.rbGold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbGold.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGold.ForeColor = System.Drawing.Color.Gold;
            this.rbGold.Location = new System.Drawing.Point(229, 29);
            this.rbGold.Name = "rbGold";
            this.rbGold.Size = new System.Drawing.Size(103, 25);
            this.rbGold.TabIndex = 3;
            this.rbGold.TabStop = true;
            this.rbGold.Text = "Gold Class";
            this.rbGold.UseVisualStyleBackColor = true;
            this.rbGold.CheckedChanged += new System.EventHandler(this.rbGold_CheckedChanged);
            // 
            // rbSilver
            // 
            this.rbSilver.AutoSize = true;
            this.rbSilver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSilver.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSilver.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.rbSilver.Location = new System.Drawing.Point(66, 29);
            this.rbSilver.Name = "rbSilver";
            this.rbSilver.Size = new System.Drawing.Size(109, 25);
            this.rbSilver.TabIndex = 4;
            this.rbSilver.TabStop = true;
            this.rbSilver.Text = "Silver Class";
            this.rbSilver.UseVisualStyleBackColor = true;
            this.rbSilver.CheckedChanged += new System.EventHandler(this.rbSilver_CheckedChanged);
            // 
            // buttonBuyNow
            // 
            this.buttonBuyNow.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonBuyNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuyNow.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuyNow.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBuyNow.Location = new System.Drawing.Point(518, 484);
            this.buttonBuyNow.Name = "buttonBuyNow";
            this.buttonBuyNow.Size = new System.Drawing.Size(131, 57);
            this.buttonBuyNow.TabIndex = 6;
            this.buttonBuyNow.Text = "Buy Now";
            this.buttonBuyNow.UseVisualStyleBackColor = false;
            this.buttonBuyNow.Click += new System.EventHandler(this.buttonBuyNow_Click);
            this.buttonBuyNow.MouseLeave += new System.EventHandler(this.buttonBuyNow_MouseLeave);
            this.buttonBuyNow.MouseHover += new System.EventHandler(this.buttonBuyNow_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(521, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Qty :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbGold);
            this.groupBox1.Controls.Add(this.rbSilver);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(516, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBoxCinema);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(516, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 90);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cinema:";
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCinema.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCinema.FormattingEnabled = true;
            this.comboBoxCinema.Items.AddRange(new object[] {
            "Scope Cinema",
            "Regal Cinema",
            "Savoy Cinema",
            "Nikado Cinema",
            "Royal Cinema",
            "Majestic Cinema",
            "9D Cinema"});
            this.comboBoxCinema.Location = new System.Drawing.Point(18, 35);
            this.comboBoxCinema.Name = "comboBoxCinema";
            this.comboBoxCinema.Size = new System.Drawing.Size(147, 29);
            this.comboBoxCinema.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.comboBoxTime);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(711, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 139);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date and Time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 37);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 1, 6, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 28);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Tag = "";
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 6, 0, 0, 0, 0);
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "10.00 AM",
            "1.00 PM",
            "4.00 PM",
            "7.00 PM"});
            this.comboBoxTime.Location = new System.Drawing.Point(31, 87);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(121, 29);
            this.comboBoxTime.TabIndex = 1;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAmount.Location = new System.Drawing.Point(571, 404);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(60, 28);
            this.numericUpDownAmount.TabIndex = 1;
            this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmount_ValueChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Oswald", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Lime;
            this.labelPrice.Location = new System.Drawing.Point(610, 136);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(86, 56);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "RS.0";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(521, 452);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(83, 18);
            this.labelError.TabIndex = 13;
            this.labelError.Text = "sampleError";
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment2.Properties.Resources.BACKGROUND;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(941, 565);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuyNow);
            this.Controls.Add(this.labelPriceTag);
            this.Controls.Add(this.labelmovie);
            this.Controls.Add(this.picBoxPoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Tickets";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPoster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPoster;
        private System.Windows.Forms.Label labelmovie;
        private System.Windows.Forms.Label labelPriceTag;
        private System.Windows.Forms.RadioButton rbGold;
        private System.Windows.Forms.RadioButton rbSilver;
        private System.Windows.Forms.Button buttonBuyNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxCinema;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelError;
    }
}