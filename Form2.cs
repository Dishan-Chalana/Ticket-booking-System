using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*********************
 * Name: Chalana K.A.D
 * Index No: ICT19810
 * Task: Assingnment 2
 * Module name: ITC 2303 Visual Application Programming 
 * Date: 08/01/2022
 *
 * Please provide actual data for user inputs because all user inputs will check very crucially.
 ***********************/

namespace Assignment2
{
    public partial class FormTicket : Form
    {
        //prices for ticket class
        private const int silver = 550;
        private const int gold = 900;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public FormTicket(String movieName, Image image)
        {

            InitializeComponent();
            labelmovie.Text = movieName;
            picBoxPoster.Image = image;
            numericUpDownAmount.ReadOnly = true; //to disable numericUpDown typing
            rbSilver.Checked = true;
            labelError.Hide();



        }

        private void rbGold_CheckedChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void rbSilver_CheckedChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            Calculate();

        }

        //calculate price for tikets
        private void Calculate()
        {
            if (rbSilver.Checked)
            {
                int qty = Convert.ToInt32(numericUpDownAmount.Value);
                int price = qty * silver;
                labelPrice.Text = "Rs." + price.ToString() + ".00";
            }
            else if (rbGold.Checked)
            {
                int qty = Convert.ToInt32(numericUpDownAmount.Value);
                int price = qty * gold;
                labelPrice.Text = "Rs." + price.ToString() + ".00";
            }
        }
        //show error lable when Cinama or Time comboboxs empty
        private void buttonBuyNow_Click(object sender, EventArgs e)
        {
            if (comboBoxTime.SelectedIndex == -1 && comboBoxCinema.SelectedIndex == -1)
            {
                labelError.Show();
                labelError.Text = "*Please select Cinema and Show time"; return;

            }
            else if (comboBoxTime.SelectedIndex == -1)
            {
                labelError.Show();
                labelError.Text = "*Please select Show time"; return;

            }
            else if (comboBoxCinema.SelectedIndex == -1)
            {
                labelError.Show();
                labelError.Text = "*Please select Cinema"; return;
            }
            else
            {
                labelError.Hide();
            }

            // pass order details to Form Status
            Order order = new Order();

            if (rbSilver.Checked)
            {
                order.ticket_class = "Silver";
            }
            else
            {
                order.ticket_class = "Gold";
            }
            order.movie = labelmovie.Text;
            order.price = labelPrice.Text;
            order.cinema = comboBoxCinema.Text;

            var dateTimeNow = dateTimePicker1.Value;
            var date = dateTimeNow.ToShortDateString();     // Return only date 00/00/0000
            order.date = date;

            order.qty = numericUpDownAmount.Value.ToString();
            order.time = comboBoxTime.Text;

            this.Hide();
            FormUserInfo f3 = new FormUserInfo(order);
            f3.ShowDialog();

        }

        //button hover animation
        private void buttonBuyNow_MouseHover(object sender, EventArgs e)
        {
            buttonBuyNow.ForeColor = Color.Black;
        }

        private void buttonBuyNow_MouseLeave(object sender, EventArgs e)
        {
            buttonBuyNow.ForeColor = Color.White;
        }




    }
    //to pass all userinputs via object
    public class Order
    {
        public string movie;
        public string ticket_class;
        public string price;
        public string cinema;
        public string qty;
        public string date;
        public string time;

        public Order()
        {

        }

    }

}






