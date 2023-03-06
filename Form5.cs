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
    public partial class FormOrderDone : Form
    {
        public FormOrderDone()
        {
            InitializeComponent();
        }


        private void buttonHome_Click(object sender, EventArgs e)
        {
            //close this form and retun to Main form
            this.Close();
            FormMain f1 = new FormMain();
            f1.Show();

        }
    }
}
