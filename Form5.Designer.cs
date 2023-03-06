namespace Assignment2
{
    partial class FormOrderDone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderDone));
            this.orderDoneGif = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderDoneGif)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDoneGif
            // 
            this.orderDoneGif.Image = global::Assignment2.Properties.Resources.orderdone;
            this.orderDoneGif.Location = new System.Drawing.Point(0, 0);
            this.orderDoneGif.Name = "orderDoneGif";
            this.orderDoneGif.Size = new System.Drawing.Size(726, 289);
            this.orderDoneGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orderDoneGif.TabIndex = 0;
            this.orderDoneGif.TabStop = false;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Lime;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHome.Location = new System.Drawing.Point(284, 315);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(147, 57);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Back To Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // FormOrderDone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment2.Properties.Resources.BACKGROUND;
            this.ClientSize = new System.Drawing.Size(725, 405);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.orderDoneGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOrderDone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Completed";
            ((System.ComponentModel.ISupportInitialize)(this.orderDoneGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox orderDoneGif;
        private System.Windows.Forms.Button buttonHome;
    }
}