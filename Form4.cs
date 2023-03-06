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
    public partial class FormMsgBox : Form
    {
        bool isEmpty;

        public FormMsgBox(bool isEmpty)
        {
            InitializeComponent();
            buttonOK.Hide();
            this.isEmpty = isEmpty;

        }



        private void FormMsgBox_Load(object sender, EventArgs e)
        {

        }

        private async void FormMsgBox_Shown(object sender, EventArgs e)
        {
            await Task.Delay(3000);     //show loading gif for 3 seconds



            if (isEmpty == true)     //show error msg and gif when user inputs invalid
            {
                picBoxGif.Image = global::Assignment2.Properties.Resources.error;
                labelStatus.Text = "Fill all required informations\ncorrectly";
                labelStatus.ForeColor = Color.Red;
                buttonOK.Show(); //need to press OK to return to edit
            }
            else
            {
                //show sucsess msg and gif when user inputs valid
                picBoxGif.Image = global::Assignment2.Properties.Resources.done;
                labelStatus.Text = "\tSuccessfully saved..!";
                labelStatus.ForeColor = Color.LimeGreen;
                await Task.Delay(5000);//when user inputs valid this Form will automatically close
                this.Hide();

            }

        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close(); //when click on ok button this form will close
        }
    }
}
