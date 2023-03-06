namespace Assignment2
{
    partial class FormUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserInfo));
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMovie = new System.Windows.Forms.Label();
            this.deliveryForm = new System.Windows.Forms.GroupBox();
            this.labelClear1 = new System.Windows.Forms.Label();
            this.buttonPTPayment = new System.Windows.Forms.Button();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.paymentForm = new System.Windows.Forms.GroupBox();
            this.labelClear2 = new System.Windows.Forms.Label();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExpYear = new System.Windows.Forms.TextBox();
            this.txtExpMonth = new System.Windows.Forms.TextBox();
            this.rbMaster = new System.Windows.Forms.RadioButton();
            this.rbVisa = new System.Windows.Forms.RadioButton();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.groupBoxDelivery = new System.Windows.Forms.GroupBox();
            this.labelDeliveryInfo = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.groupBoxPlaceOrder = new System.Windows.Forms.GroupBox();
            this.pictureBoxPbar = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.deliveryForm.SuspendLayout();
            this.paymentForm.SuspendLayout();
            this.groupBoxDelivery.SuspendLayout();
            this.groupBoxPlaceOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPbar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOrderDetails
            // 
            this.labelOrderDetails.AutoSize = true;
            this.labelOrderDetails.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderDetails.Location = new System.Drawing.Point(25, 81);
            this.labelOrderDetails.Name = "labelOrderDetails";
            this.labelOrderDetails.Size = new System.Drawing.Size(100, 63);
            this.labelOrderDetails.TabIndex = 2;
            this.labelOrderDetails.Text = "---Sample ----\r\n---Order---\r\n---Details---\r\n";
            this.labelOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelMovie);
            this.groupBox1.Controls.Add(this.labelOrderDetails);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(675, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Order Details";
            // 
            // labelMovie
            // 
            this.labelMovie.AutoSize = true;
            this.labelMovie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovie.Location = new System.Drawing.Point(40, 38);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(137, 24);
            this.labelMovie.TabIndex = 4;
            this.labelMovie.Text = "--movie name--";
            this.labelMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deliveryForm
            // 
            this.deliveryForm.BackColor = System.Drawing.Color.Transparent;
            this.deliveryForm.Controls.Add(this.labelClear1);
            this.deliveryForm.Controls.Add(this.buttonPTPayment);
            this.deliveryForm.Controls.Add(this.txtMobile);
            this.deliveryForm.Controls.Add(this.txtCity);
            this.deliveryForm.Controls.Add(this.txtAddress);
            this.deliveryForm.Controls.Add(this.label4);
            this.deliveryForm.Controls.Add(this.label3);
            this.deliveryForm.Controls.Add(this.label2);
            this.deliveryForm.Controls.Add(this.label1);
            this.deliveryForm.Controls.Add(this.txtName);
            this.deliveryForm.Location = new System.Drawing.Point(12, 20);
            this.deliveryForm.Name = "deliveryForm";
            this.deliveryForm.Size = new System.Drawing.Size(556, 387);
            this.deliveryForm.TabIndex = 4;
            this.deliveryForm.TabStop = false;
            this.deliveryForm.Text = "Fill in your Delivery Infomation";
            // 
            // labelClear1
            // 
            this.labelClear1.AutoSize = true;
            this.labelClear1.BackColor = System.Drawing.Color.Transparent;
            this.labelClear1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClear1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelClear1.Location = new System.Drawing.Point(403, 334);
            this.labelClear1.Name = "labelClear1";
            this.labelClear1.Size = new System.Drawing.Size(58, 18);
            this.labelClear1.TabIndex = 9;
            this.labelClear1.Text = "Clear all";
            this.labelClear1.Click += new System.EventHandler(this.labelClear1_Click);
            this.labelClear1.MouseLeave += new System.EventHandler(this.labelClear1_MouseLeave);
            this.labelClear1.MouseHover += new System.EventHandler(this.labelClear1_MouseHover);
            // 
            // buttonPTPayment
            // 
            this.buttonPTPayment.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonPTPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPTPayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPTPayment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonPTPayment.Location = new System.Drawing.Point(164, 304);
            this.buttonPTPayment.Name = "buttonPTPayment";
            this.buttonPTPayment.Size = new System.Drawing.Size(223, 53);
            this.buttonPTPayment.TabIndex = 8;
            this.buttonPTPayment.Text = "Proceed to payment";
            this.buttonPTPayment.UseVisualStyleBackColor = false;
            this.buttonPTPayment.Click += new System.EventHandler(this.buttonPTPayment_Click);
            this.buttonPTPayment.MouseLeave += new System.EventHandler(this.buttonPTPayment_MouseLeave);
            this.buttonPTPayment.MouseHover += new System.EventHandler(this.buttonPTPayment_MouseHover);
            // 
            // txtMobile
            // 
            this.txtMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobile.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(164, 249);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(297, 28);
            this.txtMobile.TabIndex = 7;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // txtCity
            // 
            this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCity.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(164, 203);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(297, 28);
            this.txtCity.TabIndex = 6;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(164, 116);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(297, 62);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mobile:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Street Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact Name:";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(164, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 28);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // paymentForm
            // 
            this.paymentForm.BackColor = System.Drawing.Color.Transparent;
            this.paymentForm.Controls.Add(this.label13);
            this.paymentForm.Controls.Add(this.label12);
            this.paymentForm.Controls.Add(this.label11);
            this.paymentForm.Controls.Add(this.label10);
            this.paymentForm.Controls.Add(this.labelClear2);
            this.paymentForm.Controls.Add(this.buttonAddCard);
            this.paymentForm.Controls.Add(this.label9);
            this.paymentForm.Controls.Add(this.txtExpYear);
            this.paymentForm.Controls.Add(this.txtExpMonth);
            this.paymentForm.Controls.Add(this.rbMaster);
            this.paymentForm.Controls.Add(this.rbVisa);
            this.paymentForm.Controls.Add(this.txtCname);
            this.paymentForm.Controls.Add(this.txtCvv);
            this.paymentForm.Controls.Add(this.label5);
            this.paymentForm.Controls.Add(this.label6);
            this.paymentForm.Controls.Add(this.label7);
            this.paymentForm.Controls.Add(this.label8);
            this.paymentForm.Controls.Add(this.txtCardNo);
            this.paymentForm.Location = new System.Drawing.Point(17, 428);
            this.paymentForm.Name = "paymentForm";
            this.paymentForm.Size = new System.Drawing.Size(556, 387);
            this.paymentForm.TabIndex = 5;
            this.paymentForm.TabStop = false;
            this.paymentForm.Text = "Fill in your Payment Infomation";
            this.paymentForm.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // labelClear2
            // 
            this.labelClear2.AutoSize = true;
            this.labelClear2.BackColor = System.Drawing.Color.Transparent;
            this.labelClear2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClear2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelClear2.Location = new System.Drawing.Point(413, 347);
            this.labelClear2.Name = "labelClear2";
            this.labelClear2.Size = new System.Drawing.Size(58, 18);
            this.labelClear2.TabIndex = 10;
            this.labelClear2.Text = "Clear all";
            this.labelClear2.Click += new System.EventHandler(this.labelClear2_Click);
            this.labelClear2.MouseLeave += new System.EventHandler(this.labelClear2_MouseLeave);
            this.labelClear2.MouseHover += new System.EventHandler(this.labelClear2_MouseHover);
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonAddCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddCard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddCard.Location = new System.Drawing.Point(175, 322);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(217, 49);
            this.buttonAddCard.TabIndex = 9;
            this.buttonAddCard.Text = "Add Card";
            this.buttonAddCard.UseVisualStyleBackColor = false;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            this.buttonAddCard.MouseLeave += new System.EventHandler(this.buttonAddCard_MouseLeave);
            this.buttonAddCard.MouseHover += new System.EventHandler(this.buttonAddCard_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(215, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "/";
            // 
            // txtExpYear
            // 
            this.txtExpYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpYear.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpYear.Location = new System.Drawing.Point(233, 177);
            this.txtExpYear.Name = "txtExpYear";
            this.txtExpYear.Size = new System.Drawing.Size(52, 28);
            this.txtExpYear.TabIndex = 10;
            this.txtExpYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpYear_KeyPress);
            // 
            // txtExpMonth
            // 
            this.txtExpMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpMonth.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpMonth.Location = new System.Drawing.Point(175, 177);
            this.txtExpMonth.Name = "txtExpMonth";
            this.txtExpMonth.Size = new System.Drawing.Size(34, 28);
            this.txtExpMonth.TabIndex = 7;
            this.txtExpMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpMonth_KeyPress);
            // 
            // rbMaster
            // 
            this.rbMaster.AutoSize = true;
            this.rbMaster.BackColor = System.Drawing.Color.Transparent;
            this.rbMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMaster.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaster.Location = new System.Drawing.Point(336, 56);
            this.rbMaster.Name = "rbMaster";
            this.rbMaster.Size = new System.Drawing.Size(82, 25);
            this.rbMaster.TabIndex = 9;
            this.rbMaster.TabStop = true;
            this.rbMaster.Text = "Master";
            this.rbMaster.UseVisualStyleBackColor = false;
            // 
            // rbVisa
            // 
            this.rbVisa.AutoSize = true;
            this.rbVisa.BackColor = System.Drawing.Color.Transparent;
            this.rbVisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVisa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVisa.Location = new System.Drawing.Point(177, 56);
            this.rbVisa.Name = "rbVisa";
            this.rbVisa.Size = new System.Drawing.Size(60, 25);
            this.rbVisa.TabIndex = 8;
            this.rbVisa.TabStop = true;
            this.rbVisa.Text = "Visa";
            this.rbVisa.UseVisualStyleBackColor = false;
            // 
            // txtCname
            // 
            this.txtCname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCname.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCname.Location = new System.Drawing.Point(175, 253);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(298, 28);
            this.txtCname.TabIndex = 7;
            this.txtCname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCname_KeyPress);
            // 
            // txtCvv
            // 
            this.txtCvv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCvv.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCvv.Location = new System.Drawing.Point(419, 180);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(58, 28);
            this.txtCvv.TabIndex = 6;
            this.txtCvv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCvv_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Card Holder Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(301, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Security Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Expiration date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Card Number:";
            
            // 
            // txtCardNo
            // 
            this.txtCardNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCardNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNo.Location = new System.Drawing.Point(175, 111);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(299, 28);
            this.txtCardNo.TabIndex = 0;
            this.txtCardNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNo_KeyPress);
            // 
            // groupBoxDelivery
            // 
            this.groupBoxDelivery.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDelivery.Controls.Add(this.labelDeliveryInfo);
            this.groupBoxDelivery.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDelivery.Location = new System.Drawing.Point(675, 234);
            this.groupBoxDelivery.Name = "groupBoxDelivery";
            this.groupBoxDelivery.Size = new System.Drawing.Size(311, 173);
            this.groupBoxDelivery.TabIndex = 6;
            this.groupBoxDelivery.TabStop = false;
            this.groupBoxDelivery.Text = "Your Delivery Details";
            // 
            // labelDeliveryInfo
            // 
            this.labelDeliveryInfo.AutoSize = true;
            this.labelDeliveryInfo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeliveryInfo.Location = new System.Drawing.Point(61, 50);
            this.labelDeliveryInfo.Name = "labelDeliveryInfo";
            this.labelDeliveryInfo.Size = new System.Drawing.Size(100, 63);
            this.labelDeliveryInfo.TabIndex = 2;
            this.labelDeliveryInfo.Text = "---Sample ----\r\n---Delivery---\r\n---Details---";
            this.labelDeliveryInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.Gold;
            this.buttonBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBuy.Location = new System.Drawing.Point(85, 180);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(350, 73);
            this.buttonBuy.TabIndex = 10;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            this.buttonBuy.MouseLeave += new System.EventHandler(this.buttonBuy_MouseLeave);
            this.buttonBuy.MouseHover += new System.EventHandler(this.buttonBuy_MouseHover);
            // 
            // groupBoxPlaceOrder
            // 
            this.groupBoxPlaceOrder.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPlaceOrder.Controls.Add(this.pictureBoxPbar);
            this.groupBoxPlaceOrder.Controls.Add(this.buttonBuy);
            this.groupBoxPlaceOrder.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlaceOrder.Location = new System.Drawing.Point(579, 428);
            this.groupBoxPlaceOrder.Name = "groupBoxPlaceOrder";
            this.groupBoxPlaceOrder.Size = new System.Drawing.Size(512, 315);
            this.groupBoxPlaceOrder.TabIndex = 11;
            this.groupBoxPlaceOrder.TabStop = false;
            this.groupBoxPlaceOrder.Text = "Place your order";
            // 
            // pictureBoxPbar
            // 
            this.pictureBoxPbar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPbar.Image = global::Assignment2.Properties.Resources.progress_bar;
            this.pictureBoxPbar.Location = new System.Drawing.Point(6, 27);
            this.pictureBoxPbar.Name = "pictureBoxPbar";
            this.pictureBoxPbar.Size = new System.Drawing.Size(520, 105);
            this.pictureBoxPbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPbar.TabIndex = 11;
            this.pictureBoxPbar.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(184, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "xx";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(242, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "xxxx";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(437, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "xxx";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(327, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "*Must have 16 Numbers";
            // 
            // FormUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment2.Properties.Resources.payment_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 902);
            this.Controls.Add(this.groupBoxPlaceOrder);
            this.Controls.Add(this.groupBoxDelivery);
            this.Controls.Add(this.paymentForm);
            this.Controls.Add(this.deliveryForm);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete your order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.deliveryForm.ResumeLayout(false);
            this.deliveryForm.PerformLayout();
            this.paymentForm.ResumeLayout(false);
            this.paymentForm.PerformLayout();
            this.groupBoxDelivery.ResumeLayout(false);
            this.groupBoxDelivery.PerformLayout();
            this.groupBoxPlaceOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelOrderDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMovie;
        private System.Windows.Forms.GroupBox deliveryForm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox paymentForm;
        private System.Windows.Forms.RadioButton rbMaster;
        private System.Windows.Forms.RadioButton rbVisa;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExpYear;
        private System.Windows.Forms.TextBox txtExpMonth;
        private System.Windows.Forms.Button buttonPTPayment;
        private System.Windows.Forms.GroupBox groupBoxDelivery;
        private System.Windows.Forms.Label labelDeliveryInfo;
        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.Label labelClear1;
        private System.Windows.Forms.Label labelClear2;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.GroupBox groupBoxPlaceOrder;
        private System.Windows.Forms.PictureBox pictureBoxPbar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}