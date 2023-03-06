using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

    public partial class FormUserInfo : Form
    {

        bool isEmptyDelivery = true;
        bool isEmptyPayment = true;
        public FormUserInfo(Order order)
        {

            InitializeComponent();
            this.Size = new Size(800, 450);     //this change Form's size at run time
            paymentForm.Hide();      //user payment form will hidden at start
            paymentForm.Location = new Point(12, 20);       //payment form will move to same location as delivery details form

            groupBoxPlaceOrder.Hide();
            groupBoxPlaceOrder.Location = new Point(57, 42);

            labelMovie.Text = order.movie;
            groupBoxDelivery.Hide();
            labelOrderDetails.Text = "\nCinema:- " + order.cinema + "\nTickets:- " + order.qty + " " + order.ticket_class + " Class Tikets\nShow Time:-" + order.date + " at " + order.time;

            buttonBuy.Text = "Buy (" + order.price + ")";   //set buy button text like "Buy (Rs.0.00)"


        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))    //only get numbers as user input
            {
                e.Handled = true;
            }

            if (txtMobile.Text.Length > 9)  //user can only enter 10 numbers as mobile no
            {
                e.Handled = true;
            }
        }

        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (txtCardNo.Text.Length > 15)
            {
                e.Handled = true;
            }
        }

        private void txtExpMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (txtExpMonth.Text.Length > 1)
            {
                e.Handled = true;
            }
        }

        private void txtExpYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (txtExpYear.Text.Length > 3)
            {
                e.Handled = true;
            }
        }

        private void txtCvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (txtCvv.Text.Length > 2)
            {
                e.Handled = true;
            }
        }



        private void txtCname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))       //only get letters as user input
            {
                e.Handled = true;
            }
            if (txtCname.Text.Length > 20)      //user can only enter 20 letters as Card holder name
            {
                e.Handled = true;
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtAddress.Text.Length > 60)
            {
                e.Handled = true;
            }

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtName.Text.Length > 30)
            {
                e.Handled = true;
            }
        }



        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtCity.Text.Length > 20)
            {
                e.Handled = true;
            }
        }
        public static bool Check(string s)   //method for check user inputs are empty or only spaces.return true if user input only spaces or empty
        {
            return String.IsNullOrWhiteSpace(s);
        }

        private void buttonPTPayment_Click(object sender, EventArgs e)

        {
            //check user delivery data is valid or not
            if (Check(txtName.Text) || Check(txtAddress.Text) || Check(txtCity.Text) || Check(txtMobile.Text) || txtMobile.Text.Length < 10)
            {
                isEmptyDelivery = true;
                groupBoxDelivery.Hide();
            }
            else
            {
                isEmptyDelivery = false;

            }
            FormMsgBox f4 = new FormMsgBox(isEmptyDelivery);        //pass bool isEmptyDelivery value to FormMsgBox
            f4.ShowDialog();

            if (f4.Visible == false && isEmptyDelivery == false)    //after user delivery info validation compleate thiss groupBoxDelivery will show
            {
                labelDeliveryInfo.Text = txtName.Text + "\n" + txtAddress.Text + ",\n" + txtCity.Text + ".\n" + txtMobile.Text;
                groupBoxDelivery.Show();
                deliveryForm.Hide();
                paymentForm.Show();     // after validation success all payment infomation will show on leftside of form


            }



        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAddCard_Click(object sender, EventArgs e)
        {
            //check user delivery data is valid or not
            if ((rbMaster.Checked == true || rbVisa.Checked == true) && txtCardNo.Text.Length == 16 && txtExpMonth.Text.Length == 2 && txtExpYear.Text.Length == 4 && txtCvv.Text.Length == 3 && !(Check(txtCname.Text)))
            {
                isEmptyPayment = false;
            }
            else
            {
                isEmptyPayment = true;

            }
            FormMsgBox f4 = new FormMsgBox(isEmptyPayment);     //pass bool isEmptyDelivery value to FormMsgBox
            f4.ShowDialog();

            if (f4.Visible == false && isEmptyDelivery == false && isEmptyPayment == false)
            {
                paymentForm.Hide();
                groupBoxPlaceOrder.Show();      // after validation success all payment infomation and order details, show final buy button
            }

        }


        //clear buttons
        private void labelClear1_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtMobile.Clear();
        }

        private void labelClear2_Click(object sender, EventArgs e)
        {
            txtCardNo.Clear();
            txtExpMonth.Clear();
            txtExpYear.Clear();
            txtCvv.Clear();
            txtCname.Clear();
        }

        //lable mouse hover animation(color changes)
        private void labelClear2_MouseHover(object sender, EventArgs e)
        {
            labelClear2.ForeColor = Color.Red;
        }

        private void labelClear2_MouseLeave(object sender, EventArgs e)
        {
            labelClear2.ForeColor = Color.Gray;
        }

        private void labelClear1_MouseHover(object sender, EventArgs e)
        {
            labelClear1.ForeColor = Color.Red;
        }

        private void labelClear1_MouseLeave(object sender, EventArgs e)
        {
            labelClear1.ForeColor = Color.Gray;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            FormOrderDone f5 = new FormOrderDone();
            f5.ShowDialog();
            this.Hide();
        }

        //button mouse hover animations(font color change)
        private void buttonPTPayment_MouseHover(object sender, EventArgs e)
        {
            buttonPTPayment.ForeColor = Color.Black;
        }

        private void buttonPTPayment_MouseLeave(object sender, EventArgs e)
        {
            buttonPTPayment.ForeColor = Color.White;
        }

        private void buttonAddCard_MouseHover(object sender, EventArgs e)
        {
            buttonAddCard.ForeColor = Color.Black;
        }

        private void buttonAddCard_MouseLeave(object sender, EventArgs e)
        {
            buttonAddCard.ForeColor = Color.White;
        }

        private void buttonBuy_MouseHover(object sender, EventArgs e)
        {
            buttonBuy.BackColor = Color.DarkOrange;
        }

        private void buttonBuy_MouseLeave(object sender, EventArgs e)
        {
            buttonBuy.BackColor = Color.Gold;
        }
    }












}
