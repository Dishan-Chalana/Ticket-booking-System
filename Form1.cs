using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();

        }


        //when move hover image will pop up and when mouse leave to image will back to normal size
        //each poster buttons implemented separately
        private void buttonPoster1_MouseHover(object sender, EventArgs e) => buttonPoster1.Size = new Size(194, 243);
        private void buttonPoster1_MouseLeave(object sender, EventArgs e) => buttonPoster1.Size = new Size(165, 216);

        private void buttonPoster2_MouseHover(object sender, EventArgs e) => buttonPoster2.Size = new Size(194, 243);
        private void buttonPoster2_MouseLeave(object sender, EventArgs e) => buttonPoster2.Size = new Size(165, 216);

        private void buttonPoster3_MouseHover(object sender, EventArgs e) => buttonPoster3.Size = new Size(194, 243);
        private void buttonPoster3_MouseLeave(object sender, EventArgs e) => buttonPoster3.Size = new Size(165, 216);

        private void buttonPoster4_MouseHover(object sender, EventArgs e) => buttonPoster4.Size = new Size(194, 243);
        private void buttonPoster4_MouseLeave(object sender, EventArgs e) => buttonPoster4.Size = new Size(165, 216);

        private void buttonPoster5_MouseHover(object sender, EventArgs e) => buttonPoster5.Size = new Size(194, 243);
        private void buttonPoster5_MouseLeave(object sender, EventArgs e) => buttonPoster5.Size = new Size(165, 216);

        private void buttonPoster6_MouseHover(object sender, EventArgs e) => buttonPoster6.Size = new Size(194, 243);
        private void buttonPoster6_MouseLeave(object sender, EventArgs e) => buttonPoster6.Size = new Size(165, 216);

        private void buttonPoster7_MouseHover(object sender, EventArgs e) => buttonPoster7.Size = new Size(194, 243);
        private void buttonPoster7_MouseLeave(object sender, EventArgs e) => buttonPoster7.Size = new Size(165, 216);

        private void buttonPoster8_MouseHover(object sender, EventArgs e) => buttonPoster8.Size = new Size(194, 243);
        private void buttonPoster8_MouseLeave(object sender, EventArgs e) => buttonPoster8.Size = new Size(165, 216);



        //when mouse hover and leave from this lables color will change
        private void labelHelp_MouseHover(object sender, EventArgs e) => labelHelp.ForeColor = Color.White;
        private void labelHelp_MouseLeave(object sender, EventArgs e) => labelHelp.ForeColor = Color.DodgerBlue;

        private void labelContact_MouseHover(object sender, EventArgs e) => labelContact.ForeColor = Color.White;
        private void labelContact_MouseLeave(object sender, EventArgs e) => labelContact.ForeColor = Color.DodgerBlue;



        private void buttonPoster1_Click(object sender, EventArgs e)
        {
            FormTicket f2 = new FormTicket(labelPoster1.Text, buttonPoster1.BackgroundImage);   //pass movie name and image when click on poster using constructor
            f2.ShowDialog();    //to prevent click on FormMain while in FormTiket


        }

        private void buttonPoster2_Click(object sender, EventArgs e)
        {
            FormTicket f2 = new FormTicket(labelPoster2.Text, buttonPoster2.BackgroundImage);
            f2.ShowDialog();

        }

        private void buttonPoster3_Click(object sender, EventArgs e)
        {
            FormTicket f2 = new FormTicket(labelPoster3.Text, buttonPoster3.BackgroundImage);
            f2.ShowDialog();

        }

        private void buttonPoster4_Click(object sender, EventArgs e)
        {
            FormTicket f2 = new FormTicket(labelPoster4.Text, buttonPoster4.BackgroundImage);
            f2.ShowDialog();

        }

        private void buttonPoster5_Click(object sender, EventArgs e)
        {
            FormTicket f2 = new FormTicket(labelPoster5.Text, buttonPoster5.BackgroundImage);
            f2.ShowDialog();

        }

        private void buttonPoster6_Click(object sender, EventArgs e)
        {
            FormTicket f2 = new FormTicket(labelPoster6.Text, buttonPoster6.BackgroundImage);
            f2.ShowDialog();
        }

        private void buttonPoster7_Click(object sender, EventArgs e)
        {
            FormTicket f2 = new FormTicket(labelPoster7.Text, buttonPoster7.BackgroundImage);
            f2.ShowDialog();

        }

        private void buttonPoster8_Click(object sender, EventArgs e)
        {
            FormTicket f2 = new FormTicket(labelPoster8.Text, buttonPoster8.BackgroundImage);
            f2.ShowDialog();
        }

        //contact us and help massages
        private void labelHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tWelcome to the Online Movie tickets booking app. \n\nYou can choose your favourite movie and order tickets online. Your order will bring to your doorstep within 24h.\n\n*Please provide actual data for user inputs because all user inputs will check very crucially.");
        }

        private void labelContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you have any problem with the application, please contact us: \n\nHotline: 0754455835\nEmail: slonlinemovietickets@gmail.com \n\nThank you");
        }
    }
}
